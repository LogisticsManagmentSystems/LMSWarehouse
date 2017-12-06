using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ReportEngine.Barcoding
{
	public enum Subsets
	{
		SUBSETA,
		SUBSETB,
		SUBSETC
	}

	public class Barcode128 : Barcode
	{
		private readonly int[,] ASCIItoCode128SubsetAB = new int[,]{{64,  65,  66,  67,  68,  69,  70,  71,  72,  73,  74,  75,  76,  77,  78,  79,
											 80,  81,  82,  83,  84,  85,  86,  87,  88,  89,  90,  91,  92,  93,  94,  95,
											  0,   1,   2,   3,   4,   5,   6,   7,   8,   9,  10,  11,  12,  13,  14,  15,
											 16,  17,  18,  19,  20,  21,  22,  23,  24,  25,  26,  27,  28,  29,  30,  31,
											 32,  33,  34,  35,  36,  37,  38,  39,  40,  41,  42,  43,  44,  45,  46,  47,
											 48,  49,  50,  51,  52,  53,  54,  55,  56,  57,  58,  59,  60,  61,  62,  63,
											 -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											 -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											 -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											 -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											 -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											 -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											 -1,  -1,  -1,  95,  96,  97,  98,  99, 100, 101, 102, 103, 104, 105, 106},
											{-1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											 -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											  0,   1,   2,   3,   4,   5,   6,   7,   8,   9,  10,  11,  12,  13,  14,  15,
											 16,  17,  18,  19,  20,  21,  22,  23,  24,  25,  26,  27,  28,  29,  30,  31,
											 32,  33,  34,  35,  36,  37,  38,  39,  40,  41,  42,  43,  44,  45,  46,  47,
											 48,  49,  50,  51,  52,  53,  54,  55,  56,  57,  58,  59,  60,  61,  62,  63,
											 64,  65,  66,  67,  68,  69,  70,  71,  72,  73,  74,  75,  76,  77,  78,  79,
											 80,  81,  82,  83,  84,  85,  86,  87,  88,  89,  90,  91,  92,  93,  94,  -1,
											 -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											 -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											 -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											 -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,  -1,
											 -1,  -1,  -1,  95,  96,  97,  98,  99, 100, 101, 102, 103, 104, 105, 106}};

		private Subsets _currentSubset;
		private int _currentXDrawPosition;
		private float _narrowBarPixelWidth;

		#region CheckDigit
		long CheckDigit
		{
			get
			{
				long	nSum=0,nCode128Char,nNextChar,nWeight;
				Subsets nCurrentSubset = Subsets.SUBSETA;
				int nCharacterPosition;

				// start character
				if (_currentSubset==Subsets.SUBSETA)
				{
					nSum = 103;
					nCurrentSubset = Subsets.SUBSETA;
				}
				else if (_currentSubset == Subsets.SUBSETB)
				{
					nSum = 104;
					nCurrentSubset = Subsets.SUBSETB;
				}
				else if (_currentSubset == Subsets.SUBSETC)
				{
					nSum = 105;
					nCurrentSubset = Subsets.SUBSETC;
				}

				// intialize the values
				nCharacterPosition = 0;
				nWeight = 1;

				while (nCharacterPosition<(_message.Length))
				{
					// if SUBSETC
					if (nCurrentSubset == Subsets.SUBSETC)
					{
						// if it's a switch to SUBSETA - same character in all subsets
						if (ASCIItoCode128SubsetAB[(int)Subsets.SUBSETA,_message[nCharacterPosition]] == 101)
						{
							// we're switching to subsetA
							nCode128Char = 101;
							
							// add the change subset character to the sum
							nSum+= (nWeight*nCode128Char);
							
							// we've moved one message character
							nCharacterPosition++;

							// we've moved one weight value
							nWeight++;

							// actually change the subset
							nCurrentSubset = Subsets.SUBSETA;
						}
						// if it's a switch to SUBSETB - same character in all subsets
						else if (ASCIItoCode128SubsetAB[(int)Subsets.SUBSETA,_message[nCharacterPosition]] == 100)
						{
							// we're switching to subset B
							nCode128Char = 100;
							
							// add the change subset character to the sum
							nSum+= (nWeight*nCode128Char);
							
							// we've moved one message character
							nCharacterPosition++;

							// we've moved one weight value
							nWeight++;

							// actually switch the subset
							nCurrentSubset = Subsets.SUBSETB;
						}
						// it's FNC1 - just print it out
						else if (ASCIItoCode128SubsetAB[(int)Subsets.SUBSETA,_message[nCharacterPosition]] == 102)
						{
							// we're switching to subset B
							nCode128Char = 102;
							
							// add the change subset character to the sum
							nSum+= (nWeight*nCode128Char);
							
							// we've moved one message character
							nCharacterPosition++;

							// we've moved one weight value
							nWeight++;
						}
						// its a digit - process two at a time
						else
						{
							string		csTemp;

							// get the next two characters
							csTemp = _message.Substring(nCharacterPosition, 2); // m_csMessage.Mid(nCharacterPosition,2);

							// convert them to longs
							nCode128Char = long.Parse(csTemp);// atol((const char *)csTemp);

							// add the weighted balue
							nSum += (nWeight*nCode128Char);

							// we've moved two message characters
							nCharacterPosition += 2;

							// we've moved one weight value
							nWeight++;
						}
					}
					// it's SUBSETA or SUBSETB
					else 
					{
						// handle upper ASCII characters if necessary
						long nTemp2 = _message[nCharacterPosition];
						if (nTemp2<-1)
							nTemp2 = nTemp2&255;
						
						// retrieve the message character
						nCode128Char = ASCIItoCode128SubsetAB[(int)nCurrentSubset,nTemp2];

						// add the weighted value to our sum
						nSum+= (nWeight*nCode128Char);

						// we've moved one character position
						nCharacterPosition++;

						// we've moved one weight value
						nWeight++;

						// if switch in SUBSETA
						if (nCurrentSubset == Subsets.SUBSETA)
						{
							if (nCode128Char==100)
								nCurrentSubset = Subsets.SUBSETB;
							else if (nCode128Char==99)
								nCurrentSubset = Subsets.SUBSETC;
						}
						// if switch in SUBSETB
						else if (nCurrentSubset == Subsets.SUBSETB)
						{
							if (nCode128Char==101)
								nCurrentSubset = Subsets.SUBSETA;
							else if (nCode128Char==99)
								nCurrentSubset = Subsets.SUBSETC;
						}
						// handle single character switch
						else if (nCode128Char==98)
						{
							// shift subsets for the next character only
							if (nCurrentSubset == Subsets.SUBSETA)
								nNextChar = ASCIItoCode128SubsetAB[(int)Subsets.SUBSETB,_message[nCharacterPosition]];
							else
								nNextChar = ASCIItoCode128SubsetAB[(int)Subsets.SUBSETA,_message[nCharacterPosition]];

							// add weighted value to the sum
							nSum += (nWeight*nNextChar);

							// since we've handled two characters advance position and weight again
							nCharacterPosition++;
							nWeight++;
						}
					}
				}

				// return the modulus
				return (nSum%103);
			}
		}
		#endregion CheckDigit

		public Barcode128(string message, Subsets subset) : base(message, Symbology.COD128)
		{
			_currentSubset = subset;

			// code 128
			_symbology = Symbology.COD128;
		}

		private void DrawBitmap(Graphics graphics, int height)
		{
			long	nChar,nNextChar,nCheckDigit;

			_currentXDrawPosition = 0;

			// calculate the check digit
			nCheckDigit = CheckDigit;
			
			// draw start character for current subset
			if (_currentSubset==Subsets.SUBSETA)
				DrawPattern(graphics, RetrievePattern(103), height);
			else if (_currentSubset == Subsets.SUBSETB)
				DrawPattern(graphics, RetrievePattern(104), height);
			else if (_currentSubset == Subsets.SUBSETC)
				DrawPattern(graphics, RetrievePattern(105), height);
			
			// initialize position in message	
			int nCharacterPosition = 0;

			while (nCharacterPosition < _message.Length)
			{
				if (_currentSubset == Subsets.SUBSETC)
				{
					// if it's a switch to subsetA - same character (103) for all subsets
					if (ASCIItoCode128SubsetAB[(int)Subsets.SUBSETA,_message[nCharacterPosition]] == 101)
					{
						// draw the startA code
						DrawPattern(graphics, RetrievePattern(101), height);

						// we've moved one message character
						nCharacterPosition++;

						// actually change the subset
						_currentSubset = Subsets.SUBSETA;
					}
					// if it's a switch to subsetB - same character (104) for all subsets
					else if (ASCIItoCode128SubsetAB[(int)Subsets.SUBSETA,_message[nCharacterPosition]] == 100)
					{
						// draw the startB code
						DrawPattern(graphics, RetrievePattern(100), height);

						// we've moved one message character
						nCharacterPosition++;

						// actually change the subset
						_currentSubset = Subsets.SUBSETB;
					}
					// it's FNC1 - just print it out
					else if (ASCIItoCode128SubsetAB[(int)Subsets.SUBSETA,_message[nCharacterPosition]] == 102)
					{
						// draw the FNC1
						DrawPattern(graphics, RetrievePattern(100), height);

						// we've moved one message character
						nCharacterPosition++;
					}
					// it's a digit - pull two at a time
					else
					{
						string		csTemp;

						// get the next two characters
						csTemp = _message.Substring(nCharacterPosition, 2); //m_csMessage.Mid(nCharacterPosition,2);

						// convert them to longs
						nChar = long.Parse(csTemp);// atol((const char *)csTemp);

						// draw the code 128 character
						DrawPattern(graphics, RetrievePattern(nChar), height);

						// we've moved two message characters
						nCharacterPosition += 2;
					}
				}
				// we're in SUBSETA or SUBSETB
				else
				{
					// handle upper ASCII characters if necessary
					long nTemp2 = _message[nCharacterPosition];
					if (nTemp2<-1)
						nTemp2 = nTemp2&255;
					
					// retrieve the message character
					nChar = ASCIItoCode128SubsetAB[(int)_currentSubset,nTemp2];

					// draw the char
					DrawPattern(graphics, RetrievePattern(nChar), height);

					// we've moved one character position
					nCharacterPosition++;

					// if switch in SUBSETA
					if (_currentSubset== Subsets.SUBSETA)
					{
						if (nChar==100)
							_currentSubset = Subsets.SUBSETB;
						else if (nChar==99)
							_currentSubset = Subsets.SUBSETC;
					}
					// if switch in SUBSETB
					else if (_currentSubset == Subsets.SUBSETB)
					{
						if (nChar==101)
							_currentSubset = Subsets.SUBSETA;
						else if (nChar==99)
							_currentSubset = Subsets.SUBSETC;
					}
					// if a shift character
					else if (nChar==98)
					{
						// shift subsets for the next character only
						if (_currentSubset == Subsets.SUBSETA)
							nNextChar = ASCIItoCode128SubsetAB[(int)Subsets.SUBSETB,_message[nCharacterPosition]];
						else
							nNextChar = ASCIItoCode128SubsetAB[(int)Subsets.SUBSETA,_message[nCharacterPosition]];

						// draw the shifted character
						DrawPattern(graphics, RetrievePattern(nChar), height);

						// since we've handled two characters advance character position again
						nCharacterPosition++;
					}
				}
			}

			// draw check digit
			DrawPattern(graphics, RetrievePattern(nCheckDigit), height);
			
			// draw stop character
			DrawPattern(graphics, RetrievePattern(106), height);

			return;
		}

		public static Image DrawBarcode(string message, Subsets subset, int height)
		{
			Barcode128 barcode = new Barcode128(message, subset);
			return barcode.DrawImage(height);
		}

		public System.Drawing.Image DrawImage(int height)
		{
			//int pixelHeight = (int)((nYAxisDpi * height) + 0.5);

			_narrowBarPixelWidth = BarcodeLineWidth;//(int)((96 * 0.012) + 0.5);
			_finalBarcodePixelWidth = ((_message.Length * 11) + 34) * (int)_narrowBarPixelWidth;

			Bitmap bitmap = new Bitmap(_finalBarcodePixelWidth, height);

			Image image = Image.FromHbitmap(bitmap.GetHbitmap());

			Graphics graphics = Graphics.FromImage(image);

			graphics.DrawRectangle(new Pen(Color.White), 0, 0, _finalBarcodePixelWidth, height);

			
			// draw bitmap into memory device context
			DrawBitmap(graphics, height);

			return image;
		}

		void DrawPattern(Graphics graphics, string csPattern, int height)
		{

			// initialize X pixel value
			//nXPixel = _startingXPixel;
			
			for (int ct=0;ct<csPattern.Length;ct++)
			{
				Pen pen = new Pen((csPattern[ct] == 'b') ? Color.Black : Color.White);
				pen.Width = _narrowBarPixelWidth;
				graphics.DrawLine(pen, _currentXDrawPosition, 0, _currentXDrawPosition, height);
				// X value for loop
				//for (nXPixel=0;nXPixel<1;nXPixel++)
				//{
					// Y value for loop
					//for (nYPixel=0;nYPixel<((int)((96 * height) + 0.5));nYPixel++)
					//{
					//    // if this is a bar
					//    if (csPattern[i]=='b')
					//        graphics.DrawLine(new Pen(Color.Black),nXPixel,nYPixel, nXPixel,nYPixel);// .SetPixelV(nXPixel,nYPixel,COLORBLACK);
					//    else
					//        graphics.DrawLine(new Pen(Color.Black), nXPixel, nYPixel, nXPixel, nYPixel);
					//}
				//}

				// advance the starting position
				_currentXDrawPosition += (int)_narrowBarPixelWidth;
			}
		}

		private string RetrievePattern(long c)
		{
			string csCharPattern = string.Empty;
			
			switch (c)
			{
				case 0:
					csCharPattern = "bbsbbssbbss";
					break;
				case 1:
					csCharPattern = "bbssbbsbbss";
					break;
				case 2:
					csCharPattern = "bbssbbssbbs";
					break;
				case 3:
					csCharPattern = "bssbssbbsss";
					break;
				case 4:
					csCharPattern = "bssbsssbbss";
					break;
				case 5:
					csCharPattern = "bsssbssbbss";
					break;
				case 6:
					csCharPattern = "bssbbssbsss";
					break;
				case 7:
					csCharPattern = "bssbbsssbss";
					break;
				case 8:
					csCharPattern = "bsssbbssbss";
					break;
				case 9:
					csCharPattern = "bbssbssbsss";
					break;
				case 10:
					csCharPattern = "bbssbsssbss";
					break;
				case 11:
					csCharPattern = "bbsssbssbss";
					break;
				case 12:
					csCharPattern = "bsbbssbbbss";
					break;
				case 13:
					csCharPattern = "bssbbsbbbss";
					break;
				case 14:
					csCharPattern = "bssbbssbbbs";
					break;
				case 15:
					csCharPattern = "bsbbbssbbss";
					break;
				case 16:
					csCharPattern = "bssbbbsbbss";
					break;
				case 17:
					csCharPattern = "bssbbbssbbs";
					break;
				case 18:
					csCharPattern = "bbssbbbssbs";
					break;
				case 19:
					csCharPattern = "bbssbsbbbss";
					break;
				case 20:
					csCharPattern = "bbssbssbbbs";
					break;
				case 21:
					csCharPattern = "bbsbbbssbss";
					break;
				case 22:
					csCharPattern = "bbssbbbsbss";
					break;
				case 23:
					csCharPattern = "bbbsbbsbbbs";
					break;
				case 24:
					csCharPattern = "bbbsbssbbss";
					break;
				case 25:
					csCharPattern = "bbbssbsbbss";
					break;
				case 26:
					csCharPattern = "bbbssbssbbs";
					break;
				case 27:
					csCharPattern = "bbbsbbssbss";
					break;
				case 28:
					csCharPattern = "bbbssbbsbss";
					break;
				case 29:
					csCharPattern = "bbbssbbssbs";
					break;
				case 30:
					csCharPattern = "bbsbbsbbsss";
					break;
				case 31:
					csCharPattern = "bbsbbsssbbs";
					break;
				case 32:
					csCharPattern = "bbsssbbsbbs";
					break;
				case 33:
					csCharPattern = "bsbsssbbsss";
					break;
				case 34:
					csCharPattern = "bsssbsbbsss";
					break;
				case 35:
					csCharPattern = "bsssbsssbbs";
					break;
				case 36:
					csCharPattern = "bsbbsssbsss";
					break;
				case 37:
					csCharPattern = "bsssbbsbsss";
					break;
				case 38:
					csCharPattern = "bsssbbsssbs";
					break;
				case 39:
					csCharPattern = "bbsbsssbsss";
					break;
				case 40:
					csCharPattern = "bbsssbsbsss";
					break;
				case 41:
					csCharPattern = "bbsssbsssbs";
					break;
				case 42:
					csCharPattern = "bsbbsbbbsss";
					break;
				case 43:
					csCharPattern = "bsbbsssbbbs";
					break;
				case 44:
					csCharPattern = "bsssbbsbbbs";
					break;
				case 45:
					csCharPattern = "bsbbbsbbsss";
					break;
				case 46:
					csCharPattern = "bsbbbsssbbs";
					break;
				case 47:
					csCharPattern = "bsssbbbsbbs";
					break;
				case 48:
					csCharPattern = "bbbsbbbsbbs";
					break;
				case 49:
					csCharPattern = "bbsbsssbbbs";
					break;
				case 50:
					csCharPattern = "bbsssbsbbbs";
					break;
				case 51:
					csCharPattern = "bbsbbbsbsss";
					break;
				case 52:
					csCharPattern = "bbsbbbsssbs";
					break;
				case 53:
					csCharPattern = "bbsbbbsbbbs";
					break;
				case 54:
					csCharPattern = "bbbsbsbbsss";
					break;
				case 55:
					csCharPattern = "bbbsbsssbbs";
					break;
				case 56:
					csCharPattern = "bbbsssbsbbs";
					break;
				case 57:
					csCharPattern = "bbbsbbsbsss";
					break;
				case 58:
					csCharPattern = "bbbsbbsssbs";
					break;
				case 59:
					csCharPattern = "bbbsssbbsbs";
					break;
				case 60:
					csCharPattern = "bbbsbbbbsbs";
					break;
				case 61:
					csCharPattern = "bbssbssssbs";
					break;
				case 62:
					csCharPattern = "bbbbsssbsbs";
					break;
				case 63:
					csCharPattern = "bsbssbbssss";
					break;
				case 64:
					csCharPattern = "bsbssssbbss";
					break;
				case 65:
					csCharPattern = "bssbsbbssss";
					break;
				case 66:
					csCharPattern = "bssbssssbbs";
					break;
				case 67:
					csCharPattern = "bssssbsbbss";
					break;
				case 68:
					csCharPattern = "bssssbssbbs";
					break;
				case 69:
					csCharPattern = "bsbbssbssss";
					break;
				case 70:
					csCharPattern = "bsbbssssbss";
					break;
				case 71:
					csCharPattern = "bssbbsbssss";
					break;
				case 72:
					csCharPattern = "bssbbssssbs";
					break;
				case 73:
					csCharPattern = "bssssbbsbss";
					break;
				case 74:
					csCharPattern = "bssssbbssbs";
					break;
				case 75:
					csCharPattern = "bbssssbssbs";
					break;
				case 76:
					csCharPattern = "bbssbsbssss";
					break;
				case 77:
					csCharPattern = "bbbbsbbbsbs";
					break;
				case 78:
					csCharPattern = "bbssssbsbss";
					break;
				case 79:
					csCharPattern = "bsssbbbbsbs";
					break;
				case 80:
					csCharPattern = "bsbssbbbbss";
					break;
				case 81:
					csCharPattern = "bssbsbbbbss";
					break;
				case 82:
					csCharPattern = "bssbssbbbbs";
					break;
				case 83:
					csCharPattern = "bsbbbbssbss";
					break;
				case 84:
					csCharPattern = "bssbbbbsbss";
					break;
				case 85:
					csCharPattern = "bssbbbbssbs";
					break;
				case 86:
					csCharPattern = "bbbbsbssbss";
					break;
				case 87:
					csCharPattern = "bbbbssbsbss";
					break;
				case 88:
					csCharPattern = "bbbbssbssbs";
					break;
				case 89:
					csCharPattern = "bbsbbsbbbbs";
					break;
				case 90:
					csCharPattern = "bbsbbbbsbbs";
					break;
				case 91:
					csCharPattern = "bbbbsbbsbbs";
					break;
				case 92:
					csCharPattern = "bsbsbbbbsss";
					break;
				case 93:
					csCharPattern = "bsbsssbbbbs";
					break;
				case 94:
					csCharPattern = "bsssbsbbbbs";
					break;
				case 95:
					csCharPattern = "bsbbbbsbsss";
					break;
				case 96:
					csCharPattern = "bsbbbbsssbs";
					break;
				case 97:
					csCharPattern = "bbbbsbsbsss";
					break;
				case 98:
					csCharPattern = "bbbbsbsssbs";
					break;
				case 99:
					csCharPattern = "bsbbbsbbbbs";
					break;
				case 100:
					csCharPattern = "bsbbbbsbbbs";
					break;
				case 101:
					csCharPattern = "bbbsbsbbbbs";
					break;
				case 102:
					csCharPattern = "bbbbsbsbbbs";
					break;
				case 103:
					csCharPattern = "bbsbssssbss";
					break;
				case 104:
					csCharPattern = "bbsbssbssss";
					break;
				case 105:
					csCharPattern = "bbsbssbbbss";
					break;
				case 106:
					csCharPattern = "bbsssbbbsbsbb";
					break;
			}

			return csCharPattern;
		}

		//void LoadData(string csMessage, double dNarrowBar, double dFinalHeight, Graphics graphics, int nStartingXPixel, int nStartingYPixel, Subsets nStartingSubset)
		//{
		//    // call base class version
		//    base.LoadData(csMessage, dNarrowBar, dFinalHeight, graphics, nStartingXPixel, nStartingYPixel,1);

		//    // set additional data
		//    _currentSubset = nStartingSubset;
		//}
	}
}
