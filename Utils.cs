using System;
using System.Data;
using System.Xml;
using System.IO;
using System.Data.OleDb;
//using System.Math;

namespace LMSWarehouse
{
    class Utils
    {
        public string ImportPath = @"c:\temp\";


        public string ImportPOOrderXML(string XML, int warehouseID, int CompanyID)
        {

            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(XML);

                XmlNodeList MasterNodeList = xmlDoc.SelectNodes("/PO/DocumentList");
                Wrapper WS = new Wrapper();

                for (int x = 0; x < MasterNodeList.Count; x++)
                {
                    string Date = "";
                    string DocNum = "";
                    string CartonNumber = "";
                    string ProductCode = "";
                    string ProductDesc = "";
                    string Qty = "";
                    string Weight = "";
                    int OrderID;

                    XmlNodeList childNode = MasterNodeList[x].SelectNodes("Document/Date");
                    Date = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("Document/DocNum");
                    DocNum = childNode[0].InnerText;


                    DataSet ds = WS.SetStockOrder(0, warehouseID, 1, 2, 'P' + DocNum, CompanyID, "Purchase",
                        "Colibri Towelling (W/Cape) (PTY) LTD", "Colibri Towels", "17 Crompton Street", "Strand", "Strand", "7140", "City Couriers", "6 Koets Street",
                        "Tygerberg Business Park", "Parow", "Bellville South", "7000", DocNum, DocNum, "");
                    OrderID = int.Parse(ds.Tables[0].Rows[0]["StockOrder_ID"].ToString());


                    XmlNodeList ItemList = MasterNodeList[x].SelectNodes("Document/Items/Carton");

                    int PrevProduct = 0;
                    int ProdQty = 0;
                    int OrderDetailID = 0;
                    int OrderBatchID = 0;

                    for (int y = 0; y < ItemList.Count; y++)
                    {
                        XmlNodeList Item = ItemList[y].SelectNodes("CartonNumber");
                        CartonNumber = Item[0].InnerText;

                        Item = ItemList[y].SelectNodes("ProdCode");
                        ProductCode = Item[0].InnerText;

                        Item = ItemList[y].SelectNodes("ProdDesc");
                        ProductDesc = Item[0].InnerText;

                        Item = ItemList[y].SelectNodes("Qty");
                        Qty = Item[0].InnerText;

                        Item = ItemList[y].SelectNodes("Weight");
                        Weight = Item[0].InnerText;



                        WS.SetProduct(ProductCode, 1, 1, ProductDesc,
                        ProductDesc, 1, 0, int.Parse(Math.Truncate(double.Parse(Qty)).ToString()), 1, -1, 0, 0, 1, 0);
                        DataSet dp = WS.GetProductDetail(0, ProductCode, 0);
                        int ProductID = 0;
                        if (dp.Tables[0].Rows.Count > 0)
                        {
                            ProductID = int.Parse(dp.Tables[0].Rows[0]["Product_ID"].ToString());
                        }
                        ProdQty = ProdQty + int.Parse(Math.Truncate(double.Parse(Qty)).ToString());




                        if (ProductID != PrevProduct)
                        {
                            if (OrderBatchID != 0)
                            {
                                WS.UpdateStockDetail(OrderDetailID, ProdQty, OrderBatchID);
                                ProdQty = 0;
                            }
                            OrderDetailID = WS.SetStockDetail(OrderID, ProductID, ProdQty, 0);
                            OrderBatchID = WS.SetStockOrderBatch(ProductID, ProductCode, 1, 1, 1,
                                double.Parse(Weight), 0, int.Parse(Math.Truncate(double.Parse(Qty)).ToString()),
                                DocNum, DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd")), 
                                DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd")), 
                                DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd")));
                            PrevProduct = ProductID;
                        }

                        WS.SetItem(ProductID, OrderBatchID, CartonNumber, 1, 1, 1, double.Parse(Weight), int.Parse(Math.Truncate(double.Parse(Qty)).ToString()));

                    }
                    WS.UpdateStockDetail(OrderDetailID, ProdQty, OrderBatchID);
                }


            }
            catch (System.Exception ex)
            {
                return ex.Message.ToString();

                //ret = "<response>" +
                //        "<status>FAILURE</status>" +
                //        "<message>ERROR IN DATA FIELD:" + ex.Message.ToString() + "</message>" +
                //        "</response>";
            }
            return "Success";

        }


        public string ImportSOOrderXML(string XML, int warehouseID, int CompanyID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(XML);

                XmlNodeList MasterNodeList = xmlDoc.SelectNodes("/SO/Order");
                if (MasterNodeList.Count == 0)
                    MasterNodeList = xmlDoc.SelectNodes("/SO/OrderList/Order");


                Wrapper WS = new Wrapper();

                for (int x = 0; x < MasterNodeList.Count; x++)
                {

                    string DeliveryAddress1 = "";
                    string DeliveryAddress2 = "";
                    string DeliveryAddress3 = "";
                    string DeliveryCustomerCode = "";
                    string DeliveryAddressee = "";
                    string DeliveryCustomerName = "";
                    string DeliveryDate = "";
                    string DeliveryPostalCode = "";
                    string OrderDate = "";
                    string OrderNum = "";
                    string OrderType = "";
                    string ReleaseNum = "";

                    //string DocNum = "";
                    //string CartonNumber = "";
                    string ProductCode = "";
                    //string ProductDesc = "";
                    string Qty = "";
                    //string Weight = "";
                    int OrderID;

                    XmlNodeList childNode = MasterNodeList[x].SelectNodes("DeliveryAddress1");
                    if (childNode.Count > 0)
                        DeliveryAddress1 = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("DeliveryAddress2");
                    if (childNode.Count > 0)
                        DeliveryAddress2 = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("DeliveryAddress3");
                    if (childNode.Count > 0)
                        DeliveryAddress3 = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("DeliveryCustomerCode");
                    if (childNode.Count > 0)
                        DeliveryCustomerCode = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("DeliveryAddressee");
                    if (childNode.Count > 0)
                        DeliveryAddressee = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("DeliveryCustomerName");
                    if (childNode.Count > 0)
                        DeliveryCustomerName = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("DeliveryDate");
                    if (childNode.Count > 0)
                        DeliveryDate = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("DeliveryPostalCode");
                    if (childNode.Count > 0)
                        DeliveryPostalCode = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("OrderDate");
                    if (childNode.Count > 0)
                        OrderDate = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("OrderNum");
                    if (childNode.Count > 0)
                        OrderNum = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("OrderType");
                    if (childNode.Count > 0)
                        OrderType = childNode[0].InnerText;

                    childNode = MasterNodeList[x].SelectNodes("ReleaseNum");
                    if (childNode.Count > 0)
                        ReleaseNum = childNode[0].InnerText;

                    DataSet ds = WS.SetStockOrder(0, warehouseID, 1, 1, 'S' + ReleaseNum, CompanyID, "Sale",
                        "City Couriers", "6 Koets Street", "Tygerberg Business Park", "Parow", "Bellville South", "7000",
                        DeliveryAddressee, DeliveryCustomerName, DeliveryAddress1, DeliveryAddress2, DeliveryAddress3,
                        DeliveryPostalCode, OrderNum, DeliveryCustomerCode, "");
                    OrderID = int.Parse(ds.Tables[0].Rows[0]["StockOrder_ID"].ToString());


                    XmlNodeList ItemList = MasterNodeList[x].SelectNodes("Items");

                    int OrderDetailID = 0;

                    for (int y = 0; y < ItemList.Count; y++)
                    {
                        XmlNodeList Item = ItemList[y].SelectNodes("Product/ProdCode");
                        ProductCode = Item[0].InnerText;

                        Item = ItemList[y].SelectNodes("Product/Qty");
                        Qty = Item[0].InnerText;

                        //WS.SetProduct(ProductCode, 1, 1, ProductDesc,
                        //ProductDesc, 1, 0, int.Parse(Math.Truncate(double.Parse(Qty)).ToString()), 1, -1, 0, 0, 1, 0);
                        DataSet dp = WS.GetProductDetail(0, ProductCode, 0);
                        int ProductID = 0;
                        if (dp.Tables[0].Rows.Count > 0)
                        {
                            ProductID = int.Parse(dp.Tables[0].Rows[0]["Product_ID"].ToString());
                            OrderDetailID = WS.SetStockDetail(OrderID, ProductID, int.Parse(Math.Truncate(double.Parse(Qty)).ToString()), 0);
                        }
                        else
                        {
                            dp = WS.GetProductDetail(0, "UNKNOWN", 0);
                            if (dp.Tables[0].Rows.Count > 0)
                            {
                                ProductID = int.Parse(dp.Tables[0].Rows[0]["Product_ID"].ToString());
                                OrderDetailID = WS.SetStockDetail(OrderID, ProductID, int.Parse(Math.Truncate(double.Parse(Qty)).ToString()), 0);
                            }
                        }

                    }
                }


            }
            catch (System.Exception ex)
            {
                return ex.Message.ToString();

                //ret = "<response>" +
                //        "<status>FAILURE</status>" +
                //        "<message>ERROR IN DATA FIELD:" + ex.Message.ToString() + "</message>" +
                //        "</response>";
            }
            return "Success";

        }


        public string ExportLogidata(int StockOrderID)
        {
            string Result = "Export Failed";

            Wrapper WS = new Wrapper();
            DataSet ds = WS.GetExportData(StockOrderID);
            string OrderRef = ds.Tables[0].Rows[0]["OrderReference"].ToString();
            if (WS.IsTest())
                OrderRef = "Test" + OrderRef;
            int OrderID = WS.AddOrderColibri(OrderRef,
                ds.Tables[0].Rows[0]["CustomerReference"].ToString(), ds.Tables[0].Rows[0]["Name"].ToString(),
                ds.Tables[0].Rows[0]["Address2"].ToString(), ds.Tables[0].Rows[0]["Address3"].ToString(),
                ds.Tables[0].Rows[0]["Address4"].ToString(), ds.Tables[0].Rows[0]["PostalCode"].ToString(),
                ds.Tables[0].Rows.Count.ToString(), ds.Tables[0].Rows[0]["shipperReference"].ToString());


            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                WS.AddColibriParcel(ds.Tables[0].Rows[x]["ItemBarCode"].ToString(),
                    OrderID, int.Parse(ds.Tables[0].Rows[x]["Weight"].ToString()));

            }

            Result = "Success";
            return Result;
        }


        public string ExportSOORderXML(int StockOrderID)
        {
            string Result = "Export Failed";

            Wrapper WS = new Wrapper();

            XmlDocument xmldoc = new XmlDocument();
            //XmlNode node;
            XmlElement element;
            XmlElement ChildElement;
            XmlElement DataElement;
            XmlElement Body;
            //XmlText xmltext;

            DataSet ds = WS.GetExportData(StockOrderID);


            element = xmldoc.CreateElement("COL");
            xmldoc.AppendChild(element);

            DataElement = xmldoc.CreateElement("PickList");
            element.AppendChild(DataElement);

            element = xmldoc.CreateElement("Order");
            DataElement.AppendChild(element);



            DataElement = xmldoc.CreateElement("OrderNum");
            DataElement.InnerText = ds.Tables[0].Rows[0]["shipperReference"].ToString();
            element.AppendChild(DataElement);

            DataElement = xmldoc.CreateElement("ReleaseNum");
            DataElement.InnerText = ds.Tables[0].Rows[0]["OrderReference"].ToString().Replace("S", "");
            element.AppendChild(DataElement);

            DataElement = xmldoc.CreateElement("OrderDate");
            DataElement.InnerText = DateTime.Now.ToString("yyyy.MM.dd");
            element.AppendChild(DataElement);

            DataElement = xmldoc.CreateElement("DeliveryCustomerCode");
            DataElement.InnerText = ds.Tables[0].Rows[0]["CustomerReference"].ToString();
            element.AppendChild(DataElement);


            ChildElement = xmldoc.CreateElement("Items");
            element.AppendChild(ChildElement);

            Body = ChildElement;

            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {


                element = Body;


                ChildElement = xmldoc.CreateElement("Carton");
                element.AppendChild(ChildElement);

                element = ChildElement;

                ChildElement = xmldoc.CreateElement("ProdCode");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["SKU"].ToString();
                element.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("CartonNumber");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["ItemBarCode"].ToString();
                element.AppendChild(ChildElement);



            }

            Result = xmldoc.OuterXml;
            xmldoc.Save(ImportPath + "PL" + ds.Tables[0].Rows[0]["OrderReference"].ToString().Replace("S", "") + ".xml");
            return Result;
        }


        public string ExportSOORderXMLTT(int StockOrderID)
        {
            string Result = "Export Failed";

            Wrapper WS = new Wrapper();

            XmlDocument xmldoc = new XmlDocument();
            XmlNode Rootelement;
            XmlElement element;
            XmlElement ChildElement;
            XmlElement DataElement;
            XmlElement Body;
            XmlAttribute AttributeX;
            //XmlText xmltext;

            DataSet ds = WS.GetExportDataTT(StockOrderID);


            Rootelement = xmldoc.CreateElement("Shipped_Products_Customers");
            xmldoc.AppendChild(Rootelement);

            AttributeX = xmldoc.CreateAttribute("xmlns");
            AttributeX.Value = "http://TomTom.BizTalk.Schemas.IE_SPC.IE_SPC_2";
            Rootelement.Attributes.Append(AttributeX);

            element = xmldoc.CreateElement("CNTRLAREA");
            Rootelement.AppendChild(element);

            DataElement = xmldoc.CreateElement("SENDER");
            element.AppendChild(DataElement);

            ChildElement = xmldoc.CreateElement("LOGICALID");
            ChildElement.InnerText = "Imperial Express";
            DataElement.AppendChild(ChildElement);

            ChildElement = xmldoc.CreateElement("REFERENCEID");
            ChildElement.InnerText = "45205313";
            DataElement.AppendChild(ChildElement);

            DataElement = xmldoc.CreateElement("RECIPIENT");
            element.AppendChild(DataElement);

            ChildElement = xmldoc.CreateElement("LOGICALID");
            ChildElement.InnerText = "TOMTOMDIS";
            DataElement.AppendChild(ChildElement);

            DataElement = xmldoc.CreateElement("DATETIME");
            element.AppendChild(DataElement);

            AttributeX = xmldoc.CreateAttribute("qualifier");
            AttributeX.Value = "DOCUMENT";
            DataElement.Attributes.Append(AttributeX);

            DateTime CurrentTime = DateTime.Now;

            ChildElement = xmldoc.CreateElement("YEAR");
            ChildElement.InnerText = CurrentTime.ToString("yyyy"); 
            DataElement.AppendChild(ChildElement);

            ChildElement = xmldoc.CreateElement("MONTH");
            ChildElement.InnerText = CurrentTime.ToString("MM"); 
            DataElement.AppendChild(ChildElement);

            ChildElement = xmldoc.CreateElement("DAY");
            ChildElement.InnerText = CurrentTime.ToString("dd"); 
            DataElement.AppendChild(ChildElement);

            ChildElement = xmldoc.CreateElement("HOUR");
            ChildElement.InnerText = CurrentTime.ToString("hh"); 
            DataElement.AppendChild(ChildElement);

            ChildElement = xmldoc.CreateElement("MINUTE");
            ChildElement.InnerText = CurrentTime.ToString("mm"); 
            DataElement.AppendChild(ChildElement);

            ChildElement = xmldoc.CreateElement("SECOND");
            ChildElement.InnerText = CurrentTime.ToString("ss"); 
            DataElement.AppendChild(ChildElement);

            ChildElement = xmldoc.CreateElement("TIMEZONE");
            ChildElement.InnerText = "+0200";
            DataElement.AppendChild(ChildElement);

            // I'm leaving out Optional parameters
            DataElement = xmldoc.CreateElement("FILE_DETAIL");
            element.AppendChild(DataElement);

            ChildElement = xmldoc.CreateElement("FILE_TYPE");
            ChildElement.InnerText = "D";
            DataElement.AppendChild(ChildElement);

            ChildElement = xmldoc.CreateElement("JOB_ID");
            DataElement.AppendChild(ChildElement);

            ChildElement = xmldoc.CreateElement("FILE_NUMBER");
            ChildElement.InnerText = "1";
            DataElement.AppendChild(ChildElement);

            ChildElement = xmldoc.CreateElement("ROWS_PROCESSED");
            ChildElement.InnerText = ds.Tables[0].Rows.Count.ToString();
            DataElement.AppendChild(ChildElement);



            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {

                DataElement = xmldoc.CreateElement("LINE");
                element.AppendChild(DataElement);

                ChildElement = xmldoc.CreateElement("Contract");
                ChildElement.InnerText = "Imperial Jetpark";
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Order_No");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["OrderReference"].ToString().Substring(1,ds.Tables[0].Rows[x]["OrderReference"].ToString().Length-1);
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Line_No");
                ChildElement.InnerText = x+1.ToString();
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Order_Cust_Ref");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["CustomerReference"].ToString();
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Customer_Po_No");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["shipperReference"].ToString();
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Consignment_Id");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["StockOrder_ID"].ToString();
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Pallet_ID");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["StockOrder_ID"].ToString();
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Carton_Type");
                ChildElement.InnerText = "TOM 12";
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Parcelno");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["Item_ID"].ToString();
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Pwrparcelno");
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Serial_No");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["ItemBarCode"].ToString();
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Alt_Serial_Num");
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Part_No");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["SKU"].ToString();
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Purch_Order_No");
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Shop_Order_No");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["CustomerReference"].ToString();
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Customer_Po_No");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["OrderReference"].ToString();
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Return_Order_No");
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Last_Scan_Date");
                ChildElement.InnerText = CurrentTime.ToString("yyyyMMdd");
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Last_Scan_App");
                ChildElement.InnerText = "Imperial Warehouse";
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("COUNTRY");
                ChildElement.InnerText = "ZA";
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("CUSTOMER_NAME");
                ChildElement.InnerText = ds.Tables[0].Rows[x]["AddressName"].ToString();
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("Serial_No_Connected_Device");
                DataElement.AppendChild(ChildElement);

                ChildElement = xmldoc.CreateElement("PartNoDataAssyversion");
                DataElement.AppendChild(ChildElement);
            }

            Result = xmldoc.OuterXml;
            xmldoc.Save(ImportPath + "TomTom" + ds.Tables[0].Rows[0]["OrderReference"].ToString().Replace("S", "") + ".xml");
            return Result;
        }



        public string ExportFLSalesOrder(int StockOrderID)
        {
            string Result = "Export Failed";

            Wrapper WS = new Wrapper();

            DataSet ds = WS.GetExportDataSKU(StockOrderID);

            if (ds.Tables[0].Rows.Count > 0)
            {

                File.Create("C:\\LMSWarehouse\\temp\\" + ds.Tables[0].Rows[0]["OrderReference"].ToString() + ".csv").Dispose();
                TextWriter tw = new StreamWriter("C:\\LMSWarehouse\\temp\\" + ds.Tables[0].Rows[0]["OrderReference"].ToString()+".csv");

                Double AmountTotal = 0;
                for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                {
                    AmountTotal = AmountTotal + Double.Parse(ds.Tables[0].Rows[x]["Amount"].ToString());  
                }
                //tw.WriteLine("The next line!");
                



                for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                {
                    string Line = "";
                    Line = StockOrderID.ToString();// ds.Tables[0].Rows[x]["OrderReference"].ToString();
                    Line = Line + "," + DateTime.Parse(ds.Tables[0].Rows[x]["DateOrder"].ToString()).ToString("dd/MM/yyyy");
                    Line = Line + "," + DateTime.Now.ToString("dd/MM/yyyy");
                    Line = Line + "," + ds.Tables[0].Rows[x]["CustomerReference"].ToString();
                    Line = Line + ",ZAR," + Math.Round(AmountTotal,2).ToString();                    
                    Line = Line + "," + ds.Tables[0].Rows[x]["sku"].ToString();
                    Line = Line + "," + ds.Tables[0].Rows[x]["ProductCode"].ToString();
                    Line = Line + "," + ds.Tables[0].Rows[x]["ProductDescription"].ToString();
                    Line = Line + "," + ds.Tables[0].Rows[x]["QTYFinal"].ToString();                  
                    Line = Line + ",EA,STANDARD_RATE,14";
                    double Excl = Double.Parse(ds.Tables[0].Rows[x]["Amount"].ToString()) / 1.14;
                    Line = Line + "," + (Math.Round(Excl, 2)).ToString();
                    Line = Line + "," + Math.Round(Double.Parse(ds.Tables[0].Rows[x]["Amount"].ToString()),2).ToString();
                    Line = Line + ",,,1,";
                    Line = Line + "," + ds.Tables[0].Rows[x]["ShipperReference"].ToString();

                    tw.WriteLine(Line);

                }
                tw.Close();
                Result = "Success";                
            }
            return Result;
        }



        public string ImportPOOrderXLS(string Excelfile, int warehouseID, int CompanyID)
        {

            try
            {

                // XmlDocument xmlDoc = new XmlDocument();
                //xmlDoc.LoadXml(XML);

                //XmlNodeList MasterNodeList = xmlDoc.SelectNodes("/PO/DocumentList");
                Wrapper WS = new Wrapper();

                //for (int x = 0; x < MasterNodeList.Count; x++)

                string Date = "";
                string DocNum = "";
                string Reference = "";
                string PrevDocNum = "";
                string CartonNumber = "";
                string ProductCode = "";
                //string ProductDesc = "";
                string Qty = "";
                string Weight = "";
                int OrderID = 0;



                int PrevProduct = 0;
                int ProdQty = 0;
                int OrderDetailID = 0;
                int OrderBatchID = 0;

                //XmlNodeList childNode = MasterNodeList[x].SelectNodes("Document/Date");
                //Date = childNode[0].InnerText;

                //childNode = MasterNodeList[x].SelectNodes("Document/DocNum");
                //DocNum = childNode[0].InnerText;

                DataTable ExcelData = GetExcelData(Excelfile);
                for (int x = 0; x < ExcelData.Rows.Count; x++)
                {
                    DocNum = ExcelData.Rows[x]["Customer Purchase Order"].ToString();
                    Reference = ExcelData.Rows[x]["TomTom Order Number"].ToString();

                    if (DocNum != PrevDocNum)
                    {
                        DataSet ds = WS.SetStockOrder(0, warehouseID, 1, 2, 'P' + DocNum, CompanyID, "Purchase",
                            "Tom Tom", "Gauteng", "South Africa", "", "", "", "Imperial Express", "No. 4 Struwig Street",
                            "Jet Park", "Boksburg", "South Africa", "2000", Reference, Reference, "");
                        OrderID = int.Parse(ds.Tables[0].Rows[0]["StockOrder_ID"].ToString());
                        PrevDocNum = DocNum;
                    }


                    //XmlNodeList ItemList = MasterNodeList[x].SelectNodes("Document/Items/Carton");


                    //for (int y = 0; y < ItemList.Count; y++)
                    //{
                    //XmlNodeList Item = ItemList[y].SelectNodes("CartonNumber");
                    //CartonNumber = Item[0].InnerText;

                    //Item = ItemList[y].SelectNodes("ProdCode");
                    ProductCode = ExcelData.Rows[x]["TomTom Article (SKU) Part #"].ToString();


                    //Item = ItemList[y].SelectNodes("ProdDesc");
                    //ProductDesc = Item[0].InnerText;

                    //Item = ItemList[y].SelectNodes("Qty");
                    Qty = "1";// Item[0].InnerText;

                    //Item = ItemList[y].SelectNodes("Weight");
                    Weight = "1";// Item[0].InnerText;



                    //WS.SetProduct(ProductCode, 1, 1, ProductDesc,
                    //ProductDesc, 1, 0, int.Parse(Math.Truncate(double.Parse(Qty)).ToString()), 1, -1, 0, 0, 1, 0);
                    DataSet dp = WS.GetProductDetail(0, ProductCode, 0);
                    int ProductID = 0;
                    if (dp.Tables[0].Rows.Count > 0)
                    {
                        ProductID = int.Parse(dp.Tables[0].Rows[0]["Product_ID"].ToString());
                    }
                    ProdQty = ProdQty + int.Parse(Math.Truncate(double.Parse(Qty)).ToString());




                    if (ProductID != PrevProduct)
                    {
                        if (OrderBatchID != 0)
                        {
                            WS.UpdateStockDetail(OrderDetailID, ProdQty, OrderBatchID);
                            ProdQty = 0;
                        }
                        OrderDetailID = WS.SetStockDetail(OrderID, ProductID, ProdQty, 0);
                        OrderBatchID = WS.SetStockOrderBatch(ProductID, ProductCode, 1, 1, 1,
                            double.Parse(Weight), 0, int.Parse(Math.Truncate(double.Parse(Qty)).ToString()),
                            DocNum, DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd")),
                            DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd")),
                            DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd")));
                        PrevProduct = ProductID;
                    }

                    WS.SetItem(ProductID, OrderBatchID, CartonNumber, 1, 1, 1, double.Parse(Weight), int.Parse(Math.Truncate(double.Parse(Qty)).ToString()));

                    //}

                }
                WS.UpdateStockDetail(OrderDetailID, ProdQty, OrderBatchID);


            }
            catch (System.Exception ex)
            {
                return ex.Message.ToString();

                //ret = "<response>" +
                //        "<status>FAILURE</status>" +
                //        "<message>ERROR IN DATA FIELD:" + ex.Message.ToString() + "</message>" +
                //        "</response>";
            }
            return "Success";

        }


        private DataTable GetExcelData(string filePath)
        {
            DataTable dt = new DataTable();
            string extension = Path.GetExtension(filePath);
            //string header = "YES";//rbHeaderYes.Checked ? "YES" : "NO";
            string sheetName;
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

            //Get the name of the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    con.Close();
                }
            }

            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {

                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();
                        //Populate DataGridView.
                    }
                }
            }
            return dt;
        }


        //private DataTable GetExcelDataNoOLE(string filePath)
        //{
        //    Excel.Application xlApp = new Excel.Application();

        //    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
        //    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
        //    Excel.Range xlRange = xlWorksheet.UsedRange;

        //    int rowCount = xlRange.Rows.Count;
        //    int colCount = xlRange.Columns.Count;
        //    string Kund = "";

        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Name", typeof(string));
        //    dt.Columns.Add("Age", typeof(int));

        //    DataRow dr = dt.NewRow();

            
        //    string[] Rowheaders =  new string[colCount];

        //    for (int i = 1; i <= rowCount; i++)
        //    {
        //        dr = dt.NewRow();
        //        for (int j = 1; j <= colCount; j++)
        //        {
        //            if ((j == 1) && (i > 1))                    
        //            {

        //                if (i == 1)
        //                {
        //                    if (xlRange.Cells[i, j].Value2.ToString().trim() != "")
        //                    {
        //                        dt.Columns.Add(xlRange.Cells[i, j].Value2.ToString().trim(), typeof(string));
        //                        Rowheaders[j - 1] = xlRange.Cells[i, j].Value2.ToString().trim();
        //                    }
        //                }
        //                else
        //                {
        //                    if ((xlRange.Cells[i, j].Value2.ToString().trim() != "") && (j <= Rowheaders.Length))
        //                    {
        //                        dr[Rowheaders[j-1]] = xlRange.Cells[i, j].Value2.ToString().trim();
        //                        Rowheaders[j - 1] = xlRange.Cells[i, j].Value2.ToString().trim();
        //                    }
        //                }
        //                //MySqlConnection conn = new MySqlConnection(databas);

        //                Kund = xlRange.Cells[i, j].Value2.ToString();
        //            }
                    
        //        }
                
        //        dt.Rows.Add(dr);
        //        //...
        //    }
        //    xlApp.Workbooks.Close();

        //    return dt;
            
            

        //}
    }
}
