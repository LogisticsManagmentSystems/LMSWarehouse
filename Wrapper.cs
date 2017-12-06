using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LMSWarehouse
{
    class Wrapper
    {

        public string GetConnection()
        {
            //string constring = "Password=Mosselbaai1;Persist Security Info=True;Connect Timeout=80000;User ID=kgsfreight;Initial Catalog=_lmswms_kgsfreight;Data Source=41.185.13.102,1444;Min Pool Size=5;Max Pool Size=5000";
            //string constring = @"Password=Mosselbaai1;Persist Security Info=True;User ID=christo;Initial Catalog=LMSWMSFL_BU;Data Source=41.185.18.178";
            string constring = "Password=mosselbaai;Persist Security Info=True;Connect Timeout=1800;User ID=christocc;Initial Catalog=lmswmsFL;Data Source=41.185.18.34,1444;Min Pool Size=5;Max Pool Size=2000";
            //string constring = "Password=Mosselbaai1;Persist Security Info=True;Connect Timeout=1800;User ID=christo;Initial Catalog=lmswmsTEST;Data Source=41.185.18.34,1444;Min Pool Size=5;Max Pool Size=2000";
            //string constring = "Password=Mosselbaai1;Persist Security Info=True;Connect Timeout=30000;User ID=christo;Initial Catalog=_lmswms_kgsfreight_BU;Data Source=41.185.18.178;Min Pool Size=5;Max Pool Size=2000";
            //string constring = "Password=Lmswms123456;Persist Security Info=True;Connect Timeout=80000;User ID=Lmswms;Initial Catalog=lmswms;Data Source=winsqlr01.cpt.wa.co.za;Min Pool Size=5;Max Pool Size=5000";
            //string constring = "Password=Mosselbaai1;Persist Security Info=True;Connect Timeout=80000;User ID=kgsfreight;Initial Catalog=_lmswms_kgsfreight;Data Source=41.185.13.102,1444;Min Pool Size=5;Max Pool Size=5000";
            //string constring = @"Password=Mosselbaai1;Persist Security Info=True;User ID=christoim;Initial Catalog=_lmswmsim;Data Source=winsqlr01.cpt.wa.co.za";
            //string constring = @"Password=Edrian1;Persist Security Info=True;User ID=edrian;Initial Catalog=_lmswms_isci;Data Source=41.185.13.101";
            //string constring = @"Password=melkbos;Persist Security Info=True;User ID=mobile;Initial Catalog=lmswms;Data Source=sql.sauce-ing.com,1444";
            //string constring = @"Password=Melkbos123;Persist Security Info=True;User ID=sa;Initial Catalog=Shopping;Data Source=(local)\LMS";
            //string LData = @"Password=mosselbaai;Persist Security Info=True;User ID=christocc;Initial Catalog=Logidatacc;Data Source=41.186.18.34,1444";
            return constring;
        }

        public string GetLDConnection()
        {
            string LData = @"Password=mosselbaai;Persist Security Info=True;Connect Timeout=9000000;User ID=christocc;Initial Catalog=logidatacc;Data Source=41.185.18.34,1444;Min Pool Size=5;Max Pool Size=2000";
            return LData;
        }



        public bool IsTest()
        {
            bool result = false;
            string constring = GetConnection();
            if (constring.Contains("TEST"))
            {
                result = true;
            }
            return result;
        }


        public int AddOrderColibri(string OrdNo, string CustomerCref, string CustomerName, string Address1,
           string Address2, string Address3, string PCode, string QTY, string AltOrderNo)
        {
            string constring = GetLDConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[AddOrderColibri]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@OrdNo", OrdNo);
            sqlCommand.Parameters.AddWithValue("@CustomerCref", CustomerCref);
            sqlCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
            sqlCommand.Parameters.AddWithValue("@Address1", Address1);
            sqlCommand.Parameters.AddWithValue("@Address2", Address2);
            sqlCommand.Parameters.AddWithValue("@Address3", Address3);
            sqlCommand.Parameters.AddWithValue("@PCode", PCode);
            sqlCommand.Parameters.AddWithValue("@QTY", @QTY);
            sqlCommand.Parameters.AddWithValue("@AltOrderNo", AltOrderNo);
            sqlCommand.Parameters.Add("@NID", SqlDbType.Int).Direction = ParameterDirection.Output;
            
            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

            return Convert.ToInt32(sqlCommand.Parameters["@NID"].Value);
        }

        public void AddColibriParcel(string Transfer, int OrderID, int Weight)
        {
            string constring = GetLDConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[AddColibriParcel]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Transfer", Transfer);
            sqlCommand.Parameters.AddWithValue("@OrderID", OrderID);
            sqlCommand.Parameters.AddWithValue("@Weight", Weight);
            
            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

        }






        #region Bin Region

        public void SetBin(int BinID, string BinDescription, int BinLocationID, int BinRowID,
             int BinColumnID, int BinLevelID, int WarehouseID)
        {
            string constring = GetConnection();
            

            SqlConnection con = new SqlConnection(constring);

            SqlCommand sqlCommand = new SqlCommand("[sp_bin_SetBin]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pBinID = new SqlParameter("@BinID", SqlDbType.Int);
            SqlParameter pBinDescription = new SqlParameter("@BinDescription", SqlDbType.VarChar, 50);
            SqlParameter pBinLocationID = new SqlParameter("@BinLocationID", SqlDbType.Int);
            SqlParameter pBinRowID = new SqlParameter("@BinRowID", SqlDbType.Int);
            SqlParameter pBinColumnID = new SqlParameter("@BinColumnID", SqlDbType.Int);
            SqlParameter pBinLevelID = new SqlParameter("@BinLevelID", SqlDbType.Int);
            SqlParameter pWarehouseID = new SqlParameter("@WarehouseID", SqlDbType.Int);

            pBinID.Value = BinID;
            pBinDescription.Value = BinDescription;
            pBinLocationID.Value = BinLocationID;
            pBinRowID.Value = BinRowID;
            pBinColumnID.Value = BinColumnID;
            pBinLevelID.Value = BinLevelID;
            pWarehouseID.Value = WarehouseID;

            sqlCommand.Parameters.Add(pBinID);
            sqlCommand.Parameters.Add(pBinDescription);
            sqlCommand.Parameters.Add(pBinLocationID);
            sqlCommand.Parameters.Add(pBinRowID);
            sqlCommand.Parameters.Add(pBinColumnID);
            sqlCommand.Parameters.Add(pBinLevelID);
            sqlCommand.Parameters.Add(pWarehouseID);

            try
            {
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                con.Close();
            }

        }              

        public DataSet GetWarehouse(int CompanyID)
        {

            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("sp_bin_GetWarehouses", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pCompanyID = new SqlParameter("@CompanyID", SqlDbType.Int);

            pCompanyID.Value = CompanyID;

            da.SelectCommand.Parameters.Add(pCompanyID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetBinLocation(int WarehouseID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("sp_bin_GetBinLocations", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pWarehouseID = new SqlParameter("@WarehouseID", SqlDbType.Int);

            pWarehouseID.Value = WarehouseID;

            da.SelectCommand.Parameters.Add(pWarehouseID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetBinLevels(int WarehouseID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("sp_bin_GetBinLevels", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pWarehouseID = new SqlParameter("@WarehouseID", SqlDbType.Int);

            pWarehouseID.Value = WarehouseID;

            da.SelectCommand.Parameters.Add(pWarehouseID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetBinColumn(int BinLocationID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("sp_bin_GetBinColumn", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pBinLocationID = new SqlParameter("@BinLocationID", SqlDbType.Int);

            pBinLocationID.Value = BinLocationID;

            da.SelectCommand.Parameters.Add(pBinLocationID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetBinRow(int BinLocationID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("sp_bin_GetBinRows", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pBinLocationID = new SqlParameter("@BinLocationID", SqlDbType.Int);

            pBinLocationID.Value = BinLocationID;

            da.SelectCommand.Parameters.Add(pBinLocationID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetBins(int WarehouseID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_bin_GetBinDetail]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pWarehouseID = new SqlParameter("@WarehouseID", SqlDbType.Int);

            pWarehouseID.Value = WarehouseID;

            da.SelectCommand.Parameters.Add(pWarehouseID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        #endregion

        #region Product

        public DataSet GetProducts(int Company, int Brand, int CategoryID, int WebFlag, int ActiveFlag, int ShowSubs, int WarehouseID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_prod_GetProducts]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pCompany = new SqlParameter("@Company", SqlDbType.Int);
            SqlParameter pBrand = new SqlParameter("@Brand", SqlDbType.Int);
            SqlParameter pCategoryID = new SqlParameter("@CategoryID", SqlDbType.Int);
            SqlParameter pWebFlag = new SqlParameter("@WebFlag", SqlDbType.Int);
            SqlParameter pActiveFlag = new SqlParameter("@ActiveFlag", SqlDbType.Int);
            SqlParameter pShowSubs = new SqlParameter("@ShowSubs", SqlDbType.Int);
            SqlParameter pWarehouseID = new SqlParameter("@WarehouseID", SqlDbType.Int);

            pCompany.Value = Company;
            pBrand.Value = Brand;
            pCategoryID.Value = CategoryID;
            pWebFlag.Value = WebFlag;
            pActiveFlag.Value = ActiveFlag;
            pShowSubs.Value = ShowSubs;
            pWarehouseID.Value = WarehouseID;

            da.SelectCommand.Parameters.Add(pCompany);
            da.SelectCommand.Parameters.Add(pBrand);
            da.SelectCommand.Parameters.Add(pCategoryID);
            da.SelectCommand.Parameters.Add(pWebFlag);
            da.SelectCommand.Parameters.Add(pActiveFlag);
            da.SelectCommand.Parameters.Add(pShowSubs);
            da.SelectCommand.Parameters.Add(pWarehouseID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetBrands(int CompanyID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_prod_GetBrands]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pCompanyID = new SqlParameter("@CompanyID", SqlDbType.Int);

            pCompanyID.Value = CompanyID;

            da.SelectCommand.Parameters.Add(pCompanyID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetCategories(int BrandID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_cat_GetCategories]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pBrandID = new SqlParameter("@BrandID", SqlDbType.Int);

            pBrandID.Value = BrandID;

            da.SelectCommand.Parameters.Add(pBrandID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }


        public void SetProduct(string SKU, int BrandID, int CatID, string Description,
             string ExtraDescription, int MQty, double Price,int PackSize, int Insert, int BudgetID,
             int MainProductID, int WebPublish, int Active, int ReturnReq)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);

            SqlCommand sqlCommand = new SqlCommand("[sp_prod_UpdateProduct]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pSKU = new SqlParameter("@SKU", SqlDbType.VarChar);
            SqlParameter pBrandID = new SqlParameter("@BrandID", SqlDbType.Int);
            SqlParameter pCatID = new SqlParameter("@CatID", SqlDbType.Int);
            SqlParameter pDescription = new SqlParameter("@Description", SqlDbType.VarChar);
            SqlParameter pExtraDescription = new SqlParameter("@ExtraDescription", SqlDbType.VarChar);
            SqlParameter pMQty = new SqlParameter("@MQty", SqlDbType.Int);
            SqlParameter pPrice = new SqlParameter("@Price", SqlDbType.Float);
            SqlParameter pInsert = new SqlParameter("@Insert", SqlDbType.Int);
            SqlParameter pPackSize = new SqlParameter("@PackSize", SqlDbType.Int);
            SqlParameter pBudgetID = new SqlParameter("@BudgetID", SqlDbType.Int);
            SqlParameter pMainProductID = new SqlParameter("@MainProductID", SqlDbType.Int);
            SqlParameter pWebPublish = new SqlParameter("@WebPublish", SqlDbType.Int);
            SqlParameter pActive = new SqlParameter("@Active", SqlDbType.Int);
            SqlParameter pReturnReq = new SqlParameter("@ReturnReq", SqlDbType.Int);

            

            pSKU.Value = SKU;
            pBrandID.Value = BrandID;
            pCatID.Value = CatID;
            pDescription.Value = Description;
            pExtraDescription.Value = ExtraDescription;
            pMQty.Value = MQty;
            pPrice.Value = Price;
            pInsert.Value = Insert;
            pPackSize.Value = PackSize;
            pBudgetID.Value = BudgetID;
            pMainProductID.Value = MainProductID;
            pWebPublish.Value = WebPublish;
            pActive.Value = Active;
            pReturnReq.Value = ReturnReq;

            sqlCommand.Parameters.Add(pSKU);
            sqlCommand.Parameters.Add(pBrandID);
            sqlCommand.Parameters.Add(pCatID);
            sqlCommand.Parameters.Add(pDescription);
            sqlCommand.Parameters.Add(pExtraDescription);
            sqlCommand.Parameters.Add(pMQty);
            sqlCommand.Parameters.Add(pPrice);
            sqlCommand.Parameters.Add(pInsert);
            sqlCommand.Parameters.Add(pPackSize);
            sqlCommand.Parameters.Add(pBudgetID);
            sqlCommand.Parameters.Add(pMainProductID);
            sqlCommand.Parameters.Add(pWebPublish);
            sqlCommand.Parameters.Add(pActive);
            sqlCommand.Parameters.Add(pReturnReq);

            //try
            //{
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
            //}
            //catch
            //{
            //    con.Close();
                
            //}

        }

        public void DeleteProduct(int ProductID, string SKU)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);

            SqlCommand sqlCommand = new SqlCommand("[sp_prod_DeleteProduct]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@ProductID", ProductID);
            sqlCommand.Parameters.AddWithValue("@SKU", SKU);

            //try
            //{
            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
            //}
            //catch
            //{
            //    con.Close();

            //}

        }

        public DataSet GetProductDetail(int ProductID, string SKU, int Region)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_prod_GetProduct]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);
            da.SelectCommand.Parameters.AddWithValue("@SKU", SKU);
            da.SelectCommand.Parameters.AddWithValue("@RegionID", Region);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
 
        }

        public void SetClothing(int CompanyID, string sku)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);

            SqlCommand sqlCommand = new SqlCommand("[sp_prod_SetClothing]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@sku", sku);
            sqlCommand.Parameters.AddWithValue("@CompanyID", CompanyID);

            //try
            //{
            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
            //}
            //catch
            //{
            //    con.Close();

            //}

        }


        public void DeleteClothing(int CompanyID, string sku)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);

            SqlCommand sqlCommand = new SqlCommand("[sp_prod_DeleteClothing]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@sku", sku);
            sqlCommand.Parameters.AddWithValue("@CompanyID", CompanyID);

            //try
            //{
            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
            //}
            //catch
            //{
            //    con.Close();

            //}

        }

        public DataSet GetProductDims(int ProductID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_prod_GetProductDims]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetDimDetails(int DimmID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_prod_GetDimDetails]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@DimmsID", DimmID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }
        

        #endregion

        #region Stock

        public DataSet GetBinBarCode(int BarCode)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetBinBarCode]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pBarCode = new SqlParameter("@BarCode", SqlDbType.Int);

            pBarCode.Value = BarCode;

            da.SelectCommand.Parameters.Add(pBarCode);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetStockTakeDetail(int StockTakeID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetStockTakeDetail]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@StockTakeID", StockTakeID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }


        public DataSet GetStockItem(int ProductID, int WarehouseID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetStockItem]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);
            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }



        public DataSet GetWarehouseStock(int WarehouseID, string ProSKU)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetWarehouseStockbu]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            da.SelectCommand.Parameters.AddWithValue("@SKU", ProSKU);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }


        public DataSet GetStockTake(int WarehouseID, int StockTakeType)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetStockTake]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            da.SelectCommand.Parameters.AddWithValue("@StockTakeType", StockTakeType);

            DataSet d1 = new DataSet();
            da.Fill(d1);
            return d1;
        }

        public DataSet GetActiveStockTake(int WarehouseID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetActiveStockTake]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }

        public DataSet GetStockOrderBatch(int ProductID,string BarCode)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetStockOrderBatch]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);
            da.SelectCommand.Parameters.AddWithValue("@BarCode", BarCode);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }

        public int SetStockTake(int StockTakeID, int WarehouseID, int UserID, string StockTakeDescription, int StockTakeType)
        {
            string constring = GetConnection();

            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_SetStockTake]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@StockTakeID", StockTakeID);
            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            da.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
            da.SelectCommand.Parameters.AddWithValue("@StockTakeDescription", StockTakeDescription);
            da.SelectCommand.Parameters.AddWithValue("@StockTakeType", StockTakeType);

            

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return int.Parse(d1.Tables[0].Rows[0]["Inserted"].ToString());
        }
        
        public DataSet GetStockLabel(string BarCode)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_prod_StockLabel]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pBarCode = new SqlParameter("@BarCode", SqlDbType.VarChar);

            pBarCode.Value = BarCode;

            da.SelectCommand.Parameters.Add(pBarCode);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }


        public DataSet GetStockLabelSKU (int ProductID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_prod_StockLabelSKU]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pProductID = new SqlParameter("@ProductID", SqlDbType.VarChar);

            pProductID.Value = ProductID;

            da.SelectCommand.Parameters.Add(pProductID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }



        public DataSet SetStockOrderReturn(int StockOrder_ID, int Company_ID, string SpecialInstructions)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_SetStockOrderReturn]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@StockOrder_ID", StockOrder_ID);
            da.SelectCommand.Parameters.AddWithValue("@Company_ID", Company_ID);
            da.SelectCommand.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);


            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet CheckStockOrderReference(int Warehouse_ID, string OrderReference, string OrderType)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_CheckStockOrderReference]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@Warehouse_ID", Warehouse_ID);
            da.SelectCommand.Parameters.AddWithValue("@OrderReference", OrderReference);
            da.SelectCommand.Parameters.AddWithValue("@OrderType", OrderType);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }


        public DataSet SetStockOrder(int StockOrder_ID, int Warehouse_ID, int User_ID,
            int Customer_ID, string OrderReference, int Company_ID, string OrderType, string PAddressName,
            string PAddress1, string PAddress2, string PAddress3, string PAddress4,
            string PPostalCode, string DAddressName, string DAddress1, string DAddress2,
            string DAddress3, string DAddress4, string DPostalCode, string ShipperReference,
            string CustomerReference, string SpecialInstructions)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_SetStockOrder]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@StockOrder_ID", StockOrder_ID);
            da.SelectCommand.Parameters.AddWithValue("@Warehouse_ID", Warehouse_ID);
            da.SelectCommand.Parameters.AddWithValue("@User_ID", User_ID);
            da.SelectCommand.Parameters.AddWithValue("@Customer_ID", Customer_ID);
            da.SelectCommand.Parameters.AddWithValue("@OrderReference", OrderReference);
            da.SelectCommand.Parameters.AddWithValue("@Company_ID", Company_ID);
            da.SelectCommand.Parameters.AddWithValue("@OrderType", OrderType);
            da.SelectCommand.Parameters.AddWithValue("@PAddressName", PAddressName);
            da.SelectCommand.Parameters.AddWithValue("@PAddress1", PAddress1);
            da.SelectCommand.Parameters.AddWithValue("@PAddress2", PAddress2);
            da.SelectCommand.Parameters.AddWithValue("@PAddress3", PAddress3);
            da.SelectCommand.Parameters.AddWithValue("@PAddress4", PAddress4);
            da.SelectCommand.Parameters.AddWithValue("@PPostalCode", PPostalCode);
            da.SelectCommand.Parameters.AddWithValue("@DAddressName", DAddressName);
            da.SelectCommand.Parameters.AddWithValue("@DAddress1", DAddress1);
            da.SelectCommand.Parameters.AddWithValue("@DAddress2", DAddress2);
            da.SelectCommand.Parameters.AddWithValue("@DAddress3", DAddress3);
            da.SelectCommand.Parameters.AddWithValue("@DAddress4", DAddress4);
            da.SelectCommand.Parameters.AddWithValue("@DPostalCode", DPostalCode);
            da.SelectCommand.Parameters.AddWithValue("@ShipperReference", ShipperReference);
            da.SelectCommand.Parameters.AddWithValue("@CustomerReference", CustomerReference);
            da.SelectCommand.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);


            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }




        public DataSet GetStockDetail(int OrderID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetStockDetail]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@StockOrderID", OrderID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetStockDetailReference(string OrderReference)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetStockOrderRef]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@StockOrderRef", OrderReference);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }


        public int SetStockDetail(int StockOrderID,int Product_ID, int QTY,double Amount)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_SetStockDetail]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockOrderID", StockOrderID);
            sqlCommand.Parameters.AddWithValue("@Product_ID", Product_ID);
            sqlCommand.Parameters.AddWithValue("@QTY", QTY);
            sqlCommand.Parameters.AddWithValue("@Amount", Amount);
            sqlCommand.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;
            
            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

            return Convert.ToInt32(sqlCommand.Parameters["@Result"].Value);
        }


        public void UpdateStockDetail(int StockOrderDetailID, int QTY, int BatchID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_UpdateStockDetail]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockOrderDetailID", StockOrderDetailID);
            sqlCommand.Parameters.AddWithValue("@QTY", QTY);
            sqlCommand.Parameters.AddWithValue("@StockOrderBatchID", BatchID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

        }


        public int SetStockOrderBatch(int ProductID, string SKU, double Length, double Width,
            double Height, double Weight, double Amount, int Parts, string Barcode,
            DateTime DateBatch, DateTime DateExpiry, DateTime DateManufacturer)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_SetStockOrderBatch]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Product_ID", ProductID);
            sqlCommand.Parameters.AddWithValue("@SKU", SKU);
            sqlCommand.Parameters.AddWithValue("@Length", Length);
            sqlCommand.Parameters.AddWithValue("@Width", Width);
            sqlCommand.Parameters.AddWithValue("@Height", Height);
            sqlCommand.Parameters.AddWithValue("@Weight", Weight);
            sqlCommand.Parameters.AddWithValue("@Amount", Amount);
            sqlCommand.Parameters.AddWithValue("@Parts", Parts);
            sqlCommand.Parameters.AddWithValue("@Barcode", Barcode);
            sqlCommand.Parameters.AddWithValue("@DateBatch", DateBatch);
            sqlCommand.Parameters.AddWithValue("@DateExpiry", DateExpiry);
            sqlCommand.Parameters.AddWithValue("@DateManufacturer", DateManufacturer);
            sqlCommand.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;
            
            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

            return Convert.ToInt32(sqlCommand.Parameters["@Result"].Value);
        }




        public int SetItem(int ProductID, int OrderBatch_ID, string ItemBarCod,int Length, int Width,
            int Height, double Weight, int Qty)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_batch_SetItem]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;


            sqlCommand.Parameters.AddWithValue("@Product_ID", ProductID);
            sqlCommand.Parameters.AddWithValue("@StockOrderBatch_ID", OrderBatch_ID);
            sqlCommand.Parameters.AddWithValue("@Length", Length);
            sqlCommand.Parameters.AddWithValue("@Width", Width);
            sqlCommand.Parameters.AddWithValue("@Height", Height);
            sqlCommand.Parameters.AddWithValue("@Weight", Weight);
            sqlCommand.Parameters.AddWithValue("@ItemBarCode", ItemBarCod);
            sqlCommand.Parameters.AddWithValue("@Qty", Qty);
            sqlCommand.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;


            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

            return Convert.ToInt32(sqlCommand.Parameters["@Result"].Value);
        }



        public void SetStockOrderBatchLink(int ProductID, string Barcode, int StockOrderDetailID,
            int QTY)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_SetStockOrderBatchLink]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Product_ID", ProductID);
            sqlCommand.Parameters.AddWithValue("@Barcode", Barcode);
            sqlCommand.Parameters.AddWithValue("@StockOrderDetail_ID", StockOrderDetailID);
            sqlCommand.Parameters.AddWithValue("@QTY", QTY);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        public void SetStockReceive(int StockOrderDetailID, int QTY)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_SetStockReceive]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockOrderDetailID", StockOrderDetailID);
            sqlCommand.Parameters.AddWithValue("@QTY", QTY);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        public void SetStockFromStockTake(int StockTakeID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_SetStockFromStockTake]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockTakeID", StockTakeID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        public DataSet GetWarehouseDetail(int WarehouseID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetWarehouseDetails]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetStockOrder(int StockOrderID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetStockOrder]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@StockOrderID", StockOrderID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetIncompleteOrders(int WarehouseID, string OrderType)
        {

            ////Using datareader
            //SqlConnection myconnection = new SqlConnection(GetConnection());
            //myconnection.Open();
            //SqlCommand da = new SqlCommand("[sp_stock_GetIncompleteOrders]", myconnection);
            ////SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetIncompleteOrders]", myconnection);
            //da.CommandType = CommandType.StoredProcedure;

            //da.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            //da.Parameters.AddWithValue("@OrderType", OrderType);

            //SqlDataReader dr = da.ExecuteReader();
            ////myconnection.Close();
            //return dr;

            ////DataSet d1 = new DataSet();

            ////da.Fill(d1);

            ////return d1;

            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetIncompleteOrders]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.CommandTimeout = 120;

            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            da.SelectCommand.Parameters.AddWithValue("@OrderType", OrderType);

            

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetCompleteOrders(int WarehouseID, string OrderType, DateTime DateFrom)
        {
            
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetCompleteOrders]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            da.SelectCommand.Parameters.AddWithValue("@OrderType", OrderType);
            da.SelectCommand.Parameters.AddWithValue("@DateFrom", DateFrom);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }


        public DataSet GetInterfaceOrders(int WarehouseID, string OrderType, DateTime DateFrom)
        {

            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetInterfaceOrders]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            da.SelectCommand.Parameters.AddWithValue("@OrderType", OrderType);
            da.SelectCommand.Parameters.AddWithValue("@DateFrom", DateFrom);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }
        

        public void DeleteStockOrderDetail(int StockOrderDetailID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_DeleteStockOrderDetail]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockOrderDetailID", StockOrderDetailID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteStockOrder(int StockOrderID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_DeleteStockOrder]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockOrderID", StockOrderID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }



        #endregion

        #region BatchProcessing

        public DataSet GetProductBatches(int ProductID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_prod_GetProductBatches]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        #endregion

        #region Batch

        public DataSet GetExportData(int StockOrderID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_batch_GetExportData]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@StockOrderID", StockOrderID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetExportDataTT(int StockOrderID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_exp_tt_GetExportData]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@StockOrderID", StockOrderID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetExportDataSKU(int StockOrderID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_exp_GetExportData]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@StockOrderID", StockOrderID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }  
        
        public DataSet GetStockMoveType(string StockMoveCode, int Company_ID, int Warehouse_ID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_batch_GetStockMoveType]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@StockMoveCode", StockMoveCode);
            da.SelectCommand.Parameters.AddWithValue("@Company_ID", Company_ID);
            da.SelectCommand.Parameters.AddWithValue("@Warehouse_ID", @Warehouse_ID);


            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetStockMoveItems(int StockFromMoveBinID, int StockOrderID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_batch_GetStockMoveItems]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@StockFromMoveBinID", StockFromMoveBinID);
            da.SelectCommand.Parameters.AddWithValue("@StockOrderID", StockOrderID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetBinItems(int Bin_ID, int Product_ID, string ItemBarCode, string StockOrderReference)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_batch_GetBinItems]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@Bin_ID", Bin_ID);
            da.SelectCommand.Parameters.AddWithValue("@Product_ID", Product_ID);
            da.SelectCommand.Parameters.AddWithValue("@ItemBarCode", ItemBarCode);
            da.SelectCommand.Parameters.AddWithValue("@StockOrderReference", StockOrderReference);


            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }
        
        public DataSet GetStockMoveFromOrder(int StockOrder_ID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_batch_GetStockMoveFromOrder]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@StockOrder_ID", StockOrder_ID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetStockMovement(int @StockMove_ID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_batch_GetStockMovement]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@StockMove_ID", @StockMove_ID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetStockMovementPrev(int @StockMove_ID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_batch_GetStockMovementPrev]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@StockMove_ID", @StockMove_ID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }
        
        public DataSet GetItemDetail(int ItemID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_batch_GetItemDetail]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@ItemID", ItemID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetItemTrack(int ItemID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_batch_GetItemTrack]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@ItemID", ItemID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }
        
        public int SetStockMove(int Warehouse_ID, int User_ID, DateTime DateStockMove, string StockMoveDescription, string StockMoveCode)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_batch_SetStockMove]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;



            sqlCommand.Parameters.AddWithValue("@Warehouse_ID", Warehouse_ID);
            sqlCommand.Parameters.AddWithValue("@User_ID", User_ID);
            sqlCommand.Parameters.AddWithValue("@DateStockMove", DateStockMove);
            sqlCommand.Parameters.AddWithValue("@StockMoveDescription", StockMoveDescription);
            sqlCommand.Parameters.AddWithValue("@StockMoveCode", StockMoveCode);
            sqlCommand.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;


            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

            return Convert.ToInt32(sqlCommand.Parameters["@Result"].Value);
        }
        
        public void SetStockMoveDetailPOSO(int StockMove_ID, int StockOrder_ID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_batch_SetStockMoveDetailPOSO]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;



            sqlCommand.Parameters.AddWithValue("@StockMove_ID", StockMove_ID);
            sqlCommand.Parameters.AddWithValue("@StockOrder_ID", StockOrder_ID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

        }
        
        public void UpdateStockOrderStatus()
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_batch_UpdateStockOrderStatus]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

        }

        public void UpdateSetOrderStatus(int OrderID,int OrderStatus)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_batch_SetStockOrderStatus]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockOrderID", OrderID);
            sqlCommand.Parameters.AddWithValue("@OrderStatusID", OrderStatus);


            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

        } 
        
        public void SetStockMoveDetail(int StockMove_ID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_batch_SetStockMoveDetail]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;



            sqlCommand.Parameters.AddWithValue("@StockMove_ID", StockMove_ID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

        }
        
        public void SetItemTrack(int StockMove_ID, string ItemBarCode, int @Bin_ID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_batch_SetItemTrack]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;



            sqlCommand.Parameters.AddWithValue("@StockMove_ID", StockMove_ID);
            sqlCommand.Parameters.AddWithValue("@ItemBarCode", ItemBarCode);
            sqlCommand.Parameters.AddWithValue("@Bin_ID", @Bin_ID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

        }









        #endregion

        #region User

        public DataSet ValidateUser(string UserName, string Password)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_log_ValidateWHLogin]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@UserName", UserName);
            da.SelectCommand.Parameters.AddWithValue("@Password", Password);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetUserWarehouse(int UserID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_log_GetUserWarehouse]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@UserID", UserID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetUserList(int CompanyID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_log_GetUserList]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@CompanyID", CompanyID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        #endregion

        #region Customer

        public DataSet GetPrimaryCustomer(int CompanyID, string Sup)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_cus_GetPrimaryCustomer]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@CompanyID", CompanyID);
            da.SelectCommand.Parameters.AddWithValue("@Sup", Sup);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetCustomer(int PrimaryCustomerID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_cus_GetCustomer]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@PrimaryCustomerID", PrimaryCustomerID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetAddress(int AddressID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_cus_GetAddress]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@AddressID", AddressID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetCustomerDetail(int CustomerID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_cus_GetCustomerDetail]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public void SetCustomer(int PrimaryCustomerID, int CustomerID, string CustomerName, string CustomerType,
            string AddressName, string Address1, string Address2, string Address3, string Address4, string PostalCode,int UserID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_cus_SetCustomer]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@PrimaryCustomerID", PrimaryCustomerID);
            sqlCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
            sqlCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
            sqlCommand.Parameters.AddWithValue("@CustomerType", CustomerType);
            sqlCommand.Parameters.AddWithValue("@AddressName", AddressName);
            sqlCommand.Parameters.AddWithValue("@Address1", Address1);
            sqlCommand.Parameters.AddWithValue("@Address2", Address2);
            sqlCommand.Parameters.AddWithValue("@Address3", Address3);
            sqlCommand.Parameters.AddWithValue("@Address4", Address4);
            sqlCommand.Parameters.AddWithValue("@PostalCode", PostalCode);
            sqlCommand.Parameters.AddWithValue("@UserID", UserID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteCustomer(int CustomerID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_cus_DeleteCustomer]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@CustomerID", CustomerID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }


        #endregion

        #region OnlineOrder

        public DataSet GetOnlineOrder(string OrderReference)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_ord_GetOrderDetail]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@OrderReference", OrderReference);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetOrderEventReturn(string OrderReference)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_ord_GetOrderEventReturn]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@OrderReference", OrderReference);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetCustomerFromUserName(string UserName)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_onl_GetCustomerFromUserName]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@UserName", UserName);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetOrderRep(int CompanyID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_ord_GetOrderRep]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@CompanyID", CompanyID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public void SetOrderRep (int OrderRepID, int CompanyID, string RepName)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_ord_SetOrderRep]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@OrderRepID", OrderRepID);
            sqlCommand.Parameters.AddWithValue("@CompanyID", CompanyID);
            sqlCommand.Parameters.AddWithValue("@RepName", RepName);


            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }


        public void DeleteOrderRep(int OrderRepID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_ord_DeleteOrderRep]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@OrderRepID", OrderRepID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        public void SetOrderEvent(int OrderEventID, int CompanyID, string EventName, DateTime EventStart, DateTime EventEnd)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("sp_ord_SetOrderEvent", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@OrderEventID", OrderEventID);
            sqlCommand.Parameters.AddWithValue("@CompanyID", CompanyID);
            sqlCommand.Parameters.AddWithValue("@EventName", EventName);
            sqlCommand.Parameters.AddWithValue("@EventStart", EventStart);
            sqlCommand.Parameters.AddWithValue("@EventEnd", EventEnd);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        public DataSet GetOrderEvent(int CompanyID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_ord_GetOrderEvent]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@CompanyID", CompanyID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }




        public DataSet GetOutlets(int CompanyID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_prod_GetOutlets]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@CompanyID", CompanyID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public void AddOutlet(int OutletID, int CompanyID, string OutletName)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_shop_AddOutlet]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@OutletID", OutletID);
            sqlCommand.Parameters.AddWithValue("@CompanyID", CompanyID);
            sqlCommand.Parameters.AddWithValue("@OutletName", OutletName);


            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }


        public void DeleteOutlet(int OutletID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_shop_DeleteOutlet]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@OutletID", OutletID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }       

        #endregion

        #region Reports

        public DataSet GetGenericReports(string Node, int CompanyID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_rep_GetGenericReports]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@Node", Node);
            da.SelectCommand.Parameters.AddWithValue("@CompanyID", CompanyID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GenericReport(string ReportName, int CompanyID, DateTime StartDate, DateTime EndDate,
            int PrimaryCustomer, int UserCustomer, int Brand, int Category, int ProductID, int RegionWarehouse)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_rep_GenericReport]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.CommandTimeout = 300;

            da.SelectCommand.Parameters.AddWithValue("@ReportName", ReportName);
            da.SelectCommand.Parameters.AddWithValue("@CompanyID", CompanyID);
            da.SelectCommand.Parameters.AddWithValue("@StartDate", StartDate);
            da.SelectCommand.Parameters.AddWithValue("@EndDate", EndDate);
            da.SelectCommand.Parameters.AddWithValue("@PrimaryCustomer", PrimaryCustomer);
            da.SelectCommand.Parameters.AddWithValue("@UserCustomer", UserCustomer);
            da.SelectCommand.Parameters.AddWithValue("@Brand", Brand);
            da.SelectCommand.Parameters.AddWithValue("@Category", Category);
            da.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);
            da.SelectCommand.Parameters.AddWithValue("@RegionWarehouse", RegionWarehouse);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
 
        }

        public DataSet GetOrderBarcodes(string OrderReference)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_rep_GetOrderBarcodes]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@OrderReference", OrderReference);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        #endregion

        #region PutAway

        public DataSet GetPutawayDetail(int WarehouseID, int OrderID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_put_GetPutawayDetail]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            da.SelectCommand.Parameters.AddWithValue("@OrderID", OrderID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }

        public DataSet GetPutStockLine(int WarehouseID, int @ProductID, string SKU)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_put_GetStockLine]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            da.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);
            da.SelectCommand.Parameters.AddWithValue("@SKU", SKU);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetStockOrderQty(int WarehouseID, int @ProductID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_put_GetStockOrderQty]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);
            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public void SetStockFromPutAway(int WarehouseID, int BinID, int QTY, int StockOrderDetailID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_SetStockFromPutAway]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            sqlCommand.Parameters.AddWithValue("@BinID", BinID);
            sqlCommand.Parameters.AddWithValue("@QTY", QTY);
            sqlCommand.Parameters.AddWithValue("@StockOrderDetailID", StockOrderDetailID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }


        public void SetStockAddFromStockMove(int WarehouseID, int BinID, int QTY, int StockMoveDetailID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_SetStockAddFromStockMove]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            sqlCommand.Parameters.AddWithValue("@BinID", BinID);
            sqlCommand.Parameters.AddWithValue("@QTY", QTY);
            sqlCommand.Parameters.AddWithValue("@StockMoveDetailID", StockMoveDetailID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }


        public void SetStockDelFromStockMove(int WarehouseID, int BinID, int QTY, int StockMoveDetailID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_SetStockDelFromStockMove]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            sqlCommand.Parameters.AddWithValue("@BinID", BinID);
            sqlCommand.Parameters.AddWithValue("@QTY", QTY);
            sqlCommand.Parameters.AddWithValue("@StockMoveDetailID", StockMoveDetailID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        #endregion

        #region AllocatePOToSO

        public DataSet GetSKUStockOrderDetail(int @ProductID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_alloc_GetSKUStockOrderDetail]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetStockOrderFull(int OrderID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_GetStockOrderFull]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@StockOrderID", OrderID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }



        #endregion

        #region Pick

        public DataSet GetPickOrders(int WarehouseID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_pick_GetPickOrders]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }

        public DataSet GetPickList(int OrderID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_pick_GetPickList]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@OrderID", OrderID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }


        public DataSet GetPickItemLis(int OrderID, int FreePick)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_pick_GetPickItemList]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@OrderID", OrderID);
            da.SelectCommand.Parameters.AddWithValue("@FreePick", FreePick);


            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }


        public DataSet GetStockOrderConsolidated(int StockOrderID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_pick_GetStockOrderConsolidated]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@StockOrderID", StockOrderID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }
       

        public DataSet GetBinList(int ProductID, string SKU, int WarehouseID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_pick_GetBinList]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);
            da.SelectCommand.Parameters.AddWithValue("@SKU", SKU);
            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }

        public DataSet GetPickStockBins(int ProductID, int WarehouseID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_pick_GetPickStockBins]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);
            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }


        public void SetPicklistStockBins(int StockOrderID, int Product_ID, int StockID, int Qty)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_pick_SetPicklistStockBins]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockOrderID", StockOrderID);
            sqlCommand.Parameters.AddWithValue("@Product_ID", Product_ID);
            sqlCommand.Parameters.AddWithValue("@StockID", StockID);
            sqlCommand.Parameters.AddWithValue("@Qty", Qty);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }


        

        public int SetStockFromPick(int WarehouseID, int BinID, int QTY, int StockOrderDetailID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("sp_stock_SetStockFromPick", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            da.SelectCommand.Parameters.AddWithValue("@BinID", BinID);
            da.SelectCommand.Parameters.AddWithValue("@QTY", QTY);
            da.SelectCommand.Parameters.AddWithValue("@StockOrderDetailID", StockOrderDetailID);


            DataSet d1 = new DataSet();

            da.Fill(d1);

            int Result = int.Parse(d1.Tables[0].Rows[0]["StockOrderDetail_ID"].ToString());

            return Result;
        }


        #endregion

        #region Stock Take


        
        public DataSet GetStockTakeList(int BinID, int StockTakeID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_batch_GetStockTakeList]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@StockTakeID", StockTakeID);
            da.SelectCommand.Parameters.AddWithValue("@BinID", BinID);

            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;

        }
        //increase timeout
        public DataSet GetStockTakeItems(int StockTakeID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            //SqlDataAdapter da = new SqlDataAdapter("[sp_batch_getStockTakeItems]", myconnection);
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlCommand cmd = new SqlCommand("sp_batch_getStockTakeItems", myconnection);
            
                cmd.Connection = myconnection;
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@StockTakeID", StockTakeID));
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet d1 = new DataSet();
                da.Fill(d1);
            
            
            //da.SelectCommand.Parameters.AddWithValue("@StockTakeID", StockTakeID);

            //DataSet d1 = new DataSet();

            //da.Fill(d1);

            return d1;

        }

        public void AddStockTakeItem(int StockTakeID, int BinID, string BarCode)
        {

            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_batch_AddStockTakeItem]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockTakeID", StockTakeID);
            sqlCommand.Parameters.AddWithValue("@BinID", BinID);
            sqlCommand.Parameters.AddWithValue("@BarCode", BarCode);


            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();


        }

        #endregion

        #region Stock Adjustment

        public int SetStockFromPick(int WarehouseID, int UserID, string StockTakeDescription)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_stock_SetStockAdjustment]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            da.SelectCommand.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            da.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
            da.SelectCommand.Parameters.AddWithValue("@StockTakeDescription", StockTakeDescription);

            
            DataSet d1 = new DataSet();

            da.Fill(d1);

            int Result = int.Parse(d1.Tables[0].Rows[0]["StockTake_ID"].ToString());

            return Result;
        }


        public void SetStockTakeDetailAdjust(int StockTakeID, int ProductID, string SKU, int QTY, int BinID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_SetStockTakeDetailAdjust]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockTakeID", StockTakeID);
            sqlCommand.Parameters.AddWithValue("@ProductID", ProductID);
            sqlCommand.Parameters.AddWithValue("@SKU", SKU);
            sqlCommand.Parameters.AddWithValue("@QTY", QTY);
            sqlCommand.Parameters.AddWithValue("@BinID", BinID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        public void SetStockFromStockAdjustment(int StockTakeID)
        {
            string constring = GetConnection();

            SqlConnection con = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand("[sp_stock_SetStockFromStockAdjustment]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockTakeID", StockTakeID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        #endregion

        #region Budget

        public DataSet GetRegionBudgets(int CompanyID, int brandID, int CategoryID, int ProductID, int BudgetType)
        {
            string constring = GetConnection();

            SqlConnection myconnection = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("sp_bud_GetBudgetRegions", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter pCompanyID = new SqlParameter("@CompanyID", SqlDbType.Int);
            pCompanyID.Value = CompanyID;
            da.SelectCommand.Parameters.Add(pCompanyID);

            SqlParameter pBrand = new SqlParameter("@BrandID", SqlDbType.Int);
            pBrand.Value = brandID;
            da.SelectCommand.Parameters.Add(pBrand);

            SqlParameter CatParameter = new SqlParameter("@CategoryID", SqlDbType.Int);
            CatParameter.Value = CategoryID;
            da.SelectCommand.Parameters.Add(CatParameter);

            SqlParameter ProductIDParameter = new SqlParameter("@ProductID", SqlDbType.Int);
            ProductIDParameter.Value = ProductID;
            da.SelectCommand.Parameters.Add(ProductIDParameter);

            SqlParameter BudgetTypeParameter = new SqlParameter("@BudgetUnitType", SqlDbType.Int);
            BudgetTypeParameter.Value = BudgetType;
            da.SelectCommand.Parameters.Add(BudgetTypeParameter);


            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public void UpdateBudget(int Budget, int Region, double Value)
        {
            string constring = GetConnection();

            SqlConnection myconnection = new SqlConnection(constring);
            SqlCommand mycommand = new SqlCommand("sp_bud_UpdateBudget", myconnection);
            mycommand.CommandType = CommandType.StoredProcedure;

            SqlParameter PBudget = new SqlParameter("@BudgetID", SqlDbType.Int);
            PBudget.Value = Budget;
            mycommand.Parameters.Add(PBudget);
            SqlParameter PRegion = new SqlParameter("@RegionID", SqlDbType.Int);
            PRegion.Value = Region;
            mycommand.Parameters.Add(PRegion);
            SqlParameter PValue = new SqlParameter("@Value", SqlDbType.Float);
            PValue.Value = Value;
            mycommand.Parameters.Add(PValue);


            myconnection.Open();
            mycommand.ExecuteNonQuery();
            myconnection.Close();
        }

        #endregion

        #region Dispatch

        public DataSet SetDispOrder(int DispOrder_ID, int Warehouse_ID, int User_ID,
         int Customer_ID, string OrderReference, int Company_ID, string PAddressName,
         string PAddress1, string PAddress2, string PAddress3, string PAddress4,
         string PPostalCode, string DAddressName, string DAddress1, string DAddress2,
         string DAddress3, string DAddress4, string DPostalCode, string ShipperReference,
         string CustomerReference, string SpecialInstructions, int Shipper_ID, int ShipperService_ID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_disp_SetDispOrder]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@DispOrder_ID", DispOrder_ID);
            da.SelectCommand.Parameters.AddWithValue("@Warehouse_ID", Warehouse_ID);
            da.SelectCommand.Parameters.AddWithValue("@User_ID", User_ID);
            da.SelectCommand.Parameters.AddWithValue("@Customer_ID", Customer_ID);
            da.SelectCommand.Parameters.AddWithValue("@OrderReference", OrderReference);
            da.SelectCommand.Parameters.AddWithValue("@Company_ID", Company_ID);
            da.SelectCommand.Parameters.AddWithValue("@PAddressName", PAddressName);
            da.SelectCommand.Parameters.AddWithValue("@PAddress1", PAddress1);
            da.SelectCommand.Parameters.AddWithValue("@PAddress2", PAddress2);
            da.SelectCommand.Parameters.AddWithValue("@PAddress3", PAddress3);
            da.SelectCommand.Parameters.AddWithValue("@PAddress4", PAddress4);
            da.SelectCommand.Parameters.AddWithValue("@PPostalCode", PPostalCode);
            da.SelectCommand.Parameters.AddWithValue("@DAddressName", DAddressName);
            da.SelectCommand.Parameters.AddWithValue("@DAddress1", DAddress1);
            da.SelectCommand.Parameters.AddWithValue("@DAddress2", DAddress2);
            da.SelectCommand.Parameters.AddWithValue("@DAddress3", DAddress3);
            da.SelectCommand.Parameters.AddWithValue("@DAddress4", DAddress4);
            da.SelectCommand.Parameters.AddWithValue("@DPostalCode", DPostalCode);
            da.SelectCommand.Parameters.AddWithValue("@ShipperReference", ShipperReference);
            da.SelectCommand.Parameters.AddWithValue("@CustomerReference", CustomerReference);
            da.SelectCommand.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);
            da.SelectCommand.Parameters.AddWithValue("@Shipper_ID", Shipper_ID);
            da.SelectCommand.Parameters.AddWithValue("@ShipperService_ID", ShipperService_ID);


            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public void GetDispOrder()
        {
        }

        public DataSet SetDispParcel(int DispOrder_ID,double Weight,double Height,double Width,double Length)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_disp_SetDispParcel]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@DispOrder_ID", DispOrder_ID);
            da.SelectCommand.Parameters.AddWithValue("@Weight", Weight);
            da.SelectCommand.Parameters.AddWithValue("@Height", Height);
            da.SelectCommand.Parameters.AddWithValue("@Width", Width);
            da.SelectCommand.Parameters.AddWithValue("@Length", Length);



            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }


        public DataSet SetDispParcel(string Barcode,int DispOrder_ID, double Weight, double Height, double Width, double Length)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_disp_SetDispParcelBarcode]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@DispOrder_ID", DispOrder_ID);
            da.SelectCommand.Parameters.AddWithValue("@Weight", Weight);
            da.SelectCommand.Parameters.AddWithValue("@Height", Height);
            da.SelectCommand.Parameters.AddWithValue("@Width", Width);
            da.SelectCommand.Parameters.AddWithValue("@Length", Length);
            da.SelectCommand.Parameters.AddWithValue("@Barcode", Barcode);



            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetDispParcel(int DispOrder_ID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_disp_GetDispParcel]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@DispOrder_ID", DispOrder_ID);


            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetStockMovement(string StockMoveCode, int Company_ID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_disp_GetStockMovement]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@StockMoveCode", StockMoveCode);
            da.SelectCommand.Parameters.AddWithValue("@Company_ID", Company_ID);


            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public DataSet GetStockMovementDetail(int StockMoveID)
        {
            SqlConnection myconnection = new SqlConnection(GetConnection());
            SqlDataAdapter da = new SqlDataAdapter("[sp_disp_GetStockMovementDetail]", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@StockMove_ID", StockMoveID);



            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }

        public void SetStockOrderFromMove(int StockMove_ID, int StockOrder_ID)
        {
            string constring = GetLDConnection();

            SqlConnection con = new SqlConnection(GetConnection());
            SqlCommand sqlCommand = new SqlCommand("[sp_batch_SetStockOrderFromMove]", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@StockMove_ID", StockMove_ID);
            sqlCommand.Parameters.AddWithValue("@StockOrder_ID", StockOrder_ID);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

        }

        public void SetDispLoad()
        {
        }

        public void GetDispLoad()
        {
        }

        public void SetDispTrack()
        {
        }

        public void GetDispTrack()
        {
        }


        #endregion

        public DataSet GetJHBStock()
        {
            SqlConnection myconnection = new SqlConnection("Password=melkbos;Persist Security Info=True;User ID=lmsjhb;Initial Catalog=lmswmsjhb;Data Source=sql.sauce-ing.com,1444;");
            SqlDataAdapter da = new SqlDataAdapter("sp_tmp_GetStock", myconnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataSet d1 = new DataSet();

            da.Fill(d1);

            return d1;
        }





    }

        


}
