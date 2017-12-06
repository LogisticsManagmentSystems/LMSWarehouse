using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ReportEngine.Barcoding
{
	public enum Symbology
	{
	   COD128
	}

	public class Barcode
	{
		protected string _message;
		protected int _finalBarcodePixelWidth;
		protected Symbology _symbology;

		public long BarcodePixelHeight
		{
			get
			{
				return _finalBarcodePixelWidth;
			}
		}

		public long BarcodePixelWidth
		{
			get
			{
				return _finalBarcodePixelWidth;
			}
		}

		protected int _barcodeLineWidth = 1;

		public int BarcodeLineWidth
		{
			get { return _barcodeLineWidth; }
			set { _barcodeLineWidth = value; }
		}


		public Barcode(string message, Symbology symbology)
		{
			_message = message;
			_symbology = symbology;
		}
	}
}
