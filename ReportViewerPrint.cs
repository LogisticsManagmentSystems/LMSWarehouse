using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;
using System.Windows.Forms;
using System.Data;
using ReportEngine.Barcoding;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;

namespace LMSWarehouse
{
    class ReportViewerPrint
    {
        private IList<Stream> m_streams;
        private int m_currentPageIndex;

        private Wrapper WS = new Wrapper();


        public void PrintDN(int OrderID)
        {

            //create n report object om die data in te lees - dit vervang basies die reportviewer
            LocalReport LReport = new LocalReport();
            LReport.ReportEmbeddedResource = @"LMSWarehouse.RepDeliveryNote.rdlc";

            LReport.EnableExternalImages = true;


            DataSet d1 = WS.GetStockOrderFull(OrderID);


            d1.Tables[0].Columns.Add("Barcode", System.Type.GetType("System.Byte[]"));
            foreach (DataRow dr in d1.Tables[0].Rows)
            {
                MemoryStream ms = new MemoryStream();
                Image img = null;
                Barcode128 barcode = new Barcode128(dr["OrderReference"].ToString(), Subsets.SUBSETB);
                barcode.BarcodeLineWidth = 1;
                img = barcode.DrawImage(14);
                //hier convert ek die image na byte array sodat mens dit nie hoef te save nie (dynamic)
                img.Save(ms, ImageFormat.Jpeg);
                //allocate die byte 
                byte[] b = ms.ToArray();
                dr["Barcode"] = b;

            }



            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Report_sp_stock_GetStockOrderFull";
            rds.Value = d1.Tables[0];
            LReport.DataSources.Add(rds);



            Export(LReport);
            m_currentPageIndex = 0;
            Print();
            Dispose1();

        }


        private void Export(LocalReport report)
        {
            //stel die margins en file format
            string deviceInfo =
              "<DeviceInfo>" +
              "  <OutputFormat>EMF</OutputFormat>" +
              "  <PageWidth>8.5in</PageWidth>" +
              "  <PageHeight>11in</PageHeight>" +
              "  <MarginTop>0.25in</MarginTop>" +
              "  <MarginLeft>0.25in</MarginLeft>" +
              "  <MarginRight>0.25in</MarginRight>" +
              "  <MarginBottom>0.25in</MarginBottom>" +
              "</DeviceInfo>";

            Warning[] warnings;

            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;

        }

        //private void Export(LocalReport report)
        //{
        //    //stel die margins en file format
        //    //string deviceInfo =
        //    //  "<DeviceInfo>" +
        //    //  "  <OutputFormat>EMF</OutputFormat>" +
        //    //  "  <PageWidth>8.5in</PageWidth>" +
        //    //  "  <PageHeight>11in</PageHeight>" +
        //    //  "  <MarginTop>0.25in</MarginTop>" +
        //    //  "  <MarginLeft>0.25in</MarginLeft>" +
        //    //  "  <MarginRight>0.25in</MarginRight>" +
        //    //  "  <MarginBottom>0.25in</MarginBottom>" +
        //    //  "</DeviceInfo>";

        //    Warning[] warnings;

        //    m_streams = new List<Stream>();
        //    report.Render("PDF", null, CreateStream,
        //       out warnings);
        //    //            report.Render("Image", deviceInfo, CreateStream,
        //    //               out warnings);
        //    foreach (Stream stream in m_streams)
        //        stream.Position = 0;

        //}


        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);
            ev.Graphics.DrawImage(pageImage, ev.PageBounds);
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        //Generic print programs start here
        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {

            try
            {
                Stream stream = new FileStream(@"C:\LMSWarehouse\DNote." + fileNameExtension, FileMode.Create);
                //Stream stream = new FileStream(@"C:\" + OrderID.ToString() + "." + fileNameExtension, FileMode.Create);
                //Stream stream = new FileStream(@"C:\logidata\temp\" + WBID.ToString() + "." + fileNameExtension, FileMode.Create);
                //Stream stream = new FileStream(@"C:\ZDev\CityCouriers\Uploader\Uploader\Images\" + name + "." + fileNameExtension, FileMode.Create);
                m_streams.Add(stream);
                return stream;
            }
            catch
            {
                Stream stream = new FileStream(@"C:\LMSWarehouse\DNote." + DateTime.Now.ToString("yyyyMMddhhmmss") + fileNameExtension, FileMode.Create);
                //Stream stream = new FileStream(@"C:\" + OrderID.ToString() + "." + fileNameExtension, FileMode.Create);
                //Stream stream = new FileStream(@"C:\logidata\temp\" + WBID.ToString() + "." + fileNameExtension, FileMode.Create);
                //Stream stream = new FileStream(@"C:\ZDev\CityCouriers\Uploader\Uploader\Images\" + name + "." + fileNameExtension, FileMode.Create);
                m_streams.Add(stream);
                return stream;

            }
        }


        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                return;
            PrintDocument printDoc = new PrintDocument();
            string strDefaultPrinter = printDoc.PrinterSettings.PrinterName;

            printDoc.PrinterSettings.PrinterName = strDefaultPrinter;
            if (!printDoc.PrinterSettings.IsValid)
            {
                string msg = String.Format(
                   "Can't find printer \"{0}\".", strDefaultPrinter);
                MessageBox.Show(msg, "Print Error");
                return;
            }
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
            try
            {
                printDoc.Print();
            }
            catch (System.Exception e)
            {
                MessageBox.Show("Printer Selected not accessable!!!" + e.Message);
            }

        }

        public void Dispose1()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }
    }


}
