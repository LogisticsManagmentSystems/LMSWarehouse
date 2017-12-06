using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMSWarehouse
{
    public partial class FrmProductLibrary : Form
    {
        int CompanyID;
        int WarehouseID;
        public struct Product
        {
            public Double ProductAmount;
            public int MinQty,  CategorySeq, packsize,
                web, active, Product_ID, Brand_ID, Category_ID, MainProduct_ID, Return;
            public string SKU, ProductDescription, ExtraDescription;
        }

        public Product Prod;
        private Wrapper WS = new Wrapper();

        public FrmProductLibrary(int fCompanyID, int fWarehouseID)
        {
            InitializeComponent();
            CompanyID = fCompanyID;
            WarehouseID = fWarehouseID;
            ResetProduct();
            AddBrandFilter();
        }

        private void ResetProduct()
        {
            Prod.ProductAmount = 0;
            Prod.MinQty = 0;
            Prod.CategorySeq = 0;
            Prod.packsize = 0;
            Prod.web = 0;
            Prod.active = 1;
            Prod.Product_ID = 0;
            Prod.Brand_ID = 0;
            Prod.Category_ID = 0;
            Prod.MainProduct_ID = 0;
            Prod.SKU = "";
            Prod.ProductDescription = "";
            Prod.ExtraDescription = "";
            Prod.Return = 0;

            txtAmount.Text = Prod.ProductAmount.ToString();
            TxtMin.Text = Prod.MinQty.ToString();
            txtPacksize.Text = Prod.packsize.ToString();
            txtSKU.Text = Prod.SKU.ToString();
            txtDescription.Text = Prod.ProductDescription.ToString();
            txtExDescription.Text = Prod.ExtraDescription.ToString();

        }

        private void SetProduct(Double ProductAmount,
            int MinQty, int CategorySeq, int packsize,
            int web, int active, int Product_ID, 
            int Brand_ID, int Category_ID, int MainProduct_ID,
            string SKU, string ProductDescription, string ExtraDescription,
            int Return)
        {
            Prod.ProductAmount = ProductAmount;
            Prod.MinQty = MinQty;
            Prod.CategorySeq = CategorySeq;
            Prod.packsize = packsize;
            Prod.web = web;
            Prod.active = active;
            Prod.Product_ID = Product_ID;
            Prod.Brand_ID = Brand_ID;
            Prod.Category_ID = Category_ID;
            Prod.MainProduct_ID = MainProduct_ID;
            Prod.SKU = SKU;
            Prod.ProductDescription = ProductDescription;
            Prod.ExtraDescription = ExtraDescription;
            Prod.Return = Return;

            cbBrand.DataSource = null;
            cbCategory.DataSource = null;
            cbBrand.Items.Clear();
            cbCategory.Items.Clear();

            txtAmount.Text = Prod.ProductAmount.ToString();
            TxtMin.Text = Prod.MinQty.ToString();
            txtPacksize.Text = Prod.packsize.ToString();
            txtSKU.Text = Prod.SKU.ToString();
            txtDescription.Text = Prod.ProductDescription.ToString();
            txtExDescription.Text = Prod.ExtraDescription.ToString();
            if (Prod.web == 1)
            {
                cbWebSite.Checked = true;
            }
            else 
            {
                cbWebSite.Checked = false;
            }
            if (Prod.Return == 1)
            {
                cbReturn.Checked = true;
            }
            else
            {
                cbReturn.Checked = false;
            }
        }

        private bool ValidateProduct()
        {
            bool result = true;
            if ((Prod.packsize == 0) || (Prod.Brand_ID == 0) || (Prod.Brand_ID == 0) || (Prod.SKU == "") || 
                (Prod.ProductDescription == "") || (Prod.ExtraDescription == ""))
            {
                result = false;
            }

            return result;
        }

        private void FrmProductLibrary_Load(object sender, EventArgs e)
        {
            DataSet ds = WS.GetProducts(CompanyID, 0, 0, 0, 1, 0, WarehouseID);
            dgProduct.DataSource = ds.Tables[0];
        }


        private void AddBrandFilter()
        {
            DataSet ds = WS.GetBrands(CompanyID);

            DataRow dr = ds.Tables[0].NewRow();
            dr["BrandName"] = "Select All";
            dr["Brand_ID"] = 0;
            ds.Tables[0].Rows.InsertAt(dr,0);

            toolStripcbBrand.ComboBox.DataSource = ds.Tables[0];
            toolStripcbBrand.ComboBox.ValueMember = "Brand_ID";
            toolStripcbBrand.ComboBox.DisplayMember = "BrandName";

        }

        private void AddCategoryFilter(int BrandID)
        {
            DataSet ds = WS.GetCategories(BrandID);

            DataRow dr = ds.Tables[0].NewRow();
            dr["CategoryName"] = "Select All";
            dr["Category_ID"] = 0;
            ds.Tables[0].Rows.InsertAt(dr, 0);

            toolStripcbCategory.ComboBox.DataSource = ds.Tables[0];
            toolStripcbCategory.ComboBox.ValueMember = "Category_ID";
            toolStripcbCategory.ComboBox.DisplayMember = "CategoryName";
        }

        private void toolStripcbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ResetProduct();
                cbBrand.DataSource = null;
                cbCategory.DataSource = null;
                cbBrand.Items.Clear();
                cbCategory.Items.Clear();
                cbBrand.Text = "";
                cbCategory.Text = "";

                DataSet ds = WS.GetProducts(CompanyID, int.Parse(toolStripcbBrand.ComboBox.SelectedValue.ToString()), 0, 0, 1, 0, WarehouseID);
                dgProduct.DataSource = ds.Tables[0];
                AddCategoryFilter(int.Parse(toolStripcbBrand.ComboBox.SelectedValue.ToString()));
            }
            catch
            {
                //No Code: Object not yeat initialised
            }
        }

        private void toolStripcbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ResetProduct();
                cbBrand.DataSource = null;
                cbCategory.DataSource = null;
                cbBrand.Items.Clear();
                cbCategory.Items.Clear();
                cbBrand.Text = "";
                cbCategory.Text = "";

                DataSet ds = WS.GetProducts(CompanyID, int.Parse(toolStripcbBrand.ComboBox.SelectedValue.ToString()), int.Parse(toolStripcbCategory.ComboBox.SelectedValue.ToString()), 0, 1, 0, WarehouseID);
                dgProduct.DataSource = ds.Tables[0];
            }
            catch
            {
                //No Code: Object not yeat initialised
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbWebSite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgProduct_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SetProduct(Double.Parse(dgProduct.CurrentRow.Cells["ProductAmount"].Value.ToString()),
                    int.Parse(dgProduct.CurrentRow.Cells["MinQty"].Value.ToString()),
                    int.Parse(dgProduct.CurrentRow.Cells["CategorySeq"].Value.ToString()),
                    int.Parse(dgProduct.CurrentRow.Cells["packsize"].Value.ToString()),
                    int.Parse(dgProduct.CurrentRow.Cells["web"].Value.ToString()),
                    int.Parse(dgProduct.CurrentRow.Cells["active"].Value.ToString()),
                    int.Parse(dgProduct.CurrentRow.Cells["Product_ID"].Value.ToString()),
                    int.Parse(dgProduct.CurrentRow.Cells["Brand_ID"].Value.ToString()),
                    int.Parse(dgProduct.CurrentRow.Cells["Category_ID"].Value.ToString()),
                    int.Parse(dgProduct.CurrentRow.Cells["MainProduct_ID"].Value.ToString()),
                    dgProduct.CurrentRow.Cells["SKU"].Value.ToString(),
                    dgProduct.CurrentRow.Cells["ProductDescription"].Value.ToString(),
                    dgProduct.CurrentRow.Cells["ExtraDescription"].Value.ToString(),
                    int.Parse(dgProduct.CurrentRow.Cells["ReturnReq"].Value.ToString()));
                cbBrand.Text = dgProduct.CurrentRow.Cells["BrandName"].Value.ToString();
                cbCategory.Text = dgProduct.CurrentRow.Cells["CategoryName"].Value.ToString();

            }
            catch
            {
            }
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if ((cbBrand.Text == "") || (cbCategory.Text == "") || (txtDescription.Text == "")
                || (!double.TryParse(txtAmount.Text,out Prod.ProductAmount)) 
                || (!int.TryParse(txtPacksize.Text,out Prod.packsize)) 
                || (!int.TryParse(TxtMin.Text,out Prod.MinQty)))
            {
                MessageBox.Show("All fields must be filled before product can be saved.");
            }
            else
            {
                int insert = 0;
                if (Prod.Product_ID == 0)
                {
                    insert = 1;
                }
                txtDescription.Focus();

                int webt = 0;
                if (cbWebSite.Checked)
                {
                    webt = 1;
                }

                int Rett = 0;
                if (cbReturn.Checked)
                {
                    Rett = 1;
                }
                int MyProd = Prod.Product_ID;
                int MyRow = 0;

                WS.SetProduct(txtSKU.Text, Prod.Brand_ID, Prod.Category_ID, txtDescription.Text,
                    txtExDescription.Text, Prod.MinQty, Prod.ProductAmount, Prod.packsize, insert, -1, 0, webt, 1, Rett);
                int BrandIDtmp = 0;
                int CategoryIDtmp = 0;
                try
                {
                    BrandIDtmp = int.Parse(toolStripcbBrand.ComboBox.SelectedValue.ToString());
                    CategoryIDtmp = int.Parse(toolStripcbCategory.ComboBox.SelectedValue.ToString());
                }
                catch
                {
                    BrandIDtmp = 0;
                    CategoryIDtmp = 0;
                }
                DataSet ds = WS.GetProducts(CompanyID, BrandIDtmp, CategoryIDtmp, 0, 1, 0, WarehouseID);
                dgProduct.DataSource = ds.Tables[0];

                try
                {
                    for (int x = 0; x < dgProduct.Rows.Count; x++)
                    {
                        if (MyProd == int.Parse(dgProduct.Rows[x].Cells["Product_ID"].Value.ToString()))
                        {
                            MyRow = x;
                        }

                    }

                    dgProduct.CurrentCell = dgProduct.Rows[MyRow].Cells[0];
                    dgProduct.Rows[MyRow].Selected = true;
                    dgProduct_SelectionChanged(sender, e);
                }
                catch
                {
                    //Reverting to last Product
                }
                    

            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ResetProduct();
            SetProduct(Prod.ProductAmount, Prod.MinQty, Prod.CategorySeq, 
                Prod.packsize, Prod.web, Prod.active, Prod.Product_ID, Prod.Brand_ID, 
                Prod.Category_ID, Prod.MainProduct_ID, Prod.SKU, Prod.ProductDescription, Prod.ExtraDescription,Prod.Return);

            cbBrand.DataSource = null;
            cbCategory.DataSource = null;
            cbBrand.Items.Clear();
            cbCategory.Items.Clear();
            cbBrand.Text = "";
            cbCategory.Text = "";
        }

        private void cbBrand_Enter(object sender, EventArgs e)
        {
            DataSet ds = WS.GetBrands(CompanyID);

            cbBrand.DataSource = ds.Tables[0];
            cbBrand.ValueMember = "Brand_ID";
            cbBrand.DisplayMember = "BrandName";
            try
            {
                cbBrand.SelectedValue = Prod.Brand_ID;
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cbCategory_Enter(object sender, EventArgs e)
        {
            DataSet ds = WS.GetCategories(Prod.Brand_ID);

            cbCategory.DataSource = ds.Tables[0];
            cbCategory.ValueMember = "Category_ID";
            cbCategory.DisplayMember = "CategoryName";
            try
            {
                cbCategory.SelectedValue = Prod.Category_ID;
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cbBrand_Leave(object sender, EventArgs e)
        {
            try
            {
                Prod.Brand_ID = int.Parse(cbBrand.SelectedValue.ToString());
            }
            catch
            {
                //No Code Object not yeat initialised
            }
        }

        private void cbCategory_Leave(object sender, EventArgs e)
        {
            try
            {
                Prod.Category_ID = int.Parse(cbCategory.SelectedValue.ToString());
            }
            catch
            {
                //No Code Object not yeat initialised
            }

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            FrmStockLabelPrint FStockaLabelPrint = new FrmStockLabelPrint(Prod.Product_ID);
            FStockaLabelPrint.ShowDialog();
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            WS.DeleteProduct(Prod.Product_ID,"");

            DataSet ds = WS.GetProducts(CompanyID, int.Parse(toolStripcbBrand.ComboBox.SelectedValue.ToString()), int.Parse(toolStripcbCategory.ComboBox.SelectedValue.ToString()), 0, 1, 0, WarehouseID);
            dgProduct.DataSource = ds.Tables[0];

        }

        private void toolStripButtonAdjustment_Click(object sender, EventArgs e)
        {
            FrmStockAdjustment FStockAdjustment = new FrmStockAdjustment(Prod.Product_ID, WarehouseID, CompanyID);
            FStockAdjustment.ShowDialog();

            int MyProd = Prod.Product_ID;
            int MyRow = 0;

            int BrandIDtmp = 0;
            int CategoryIDtmp = 0;
            try
            {
                BrandIDtmp = int.Parse(toolStripcbBrand.ComboBox.SelectedValue.ToString());
                CategoryIDtmp = int.Parse(toolStripcbCategory.ComboBox.SelectedValue.ToString());
            }
            catch
            {
                BrandIDtmp = 0;
                CategoryIDtmp = 0;
            }

            DataSet ds = WS.GetProducts(CompanyID, BrandIDtmp, CategoryIDtmp, 0, 1, 0, WarehouseID);
            dgProduct.DataSource = ds.Tables[0];

            try
            {
                for (int x = 0; x < dgProduct.Rows.Count; x++)
                {
                    if (MyProd == int.Parse(dgProduct.Rows[x].Cells["Product_ID"].Value.ToString()))
                    {
                        MyRow = x;
                    }

                }

                dgProduct.CurrentCell = dgProduct.Rows[MyRow].Cells[0];
                dgProduct.Rows[MyRow].Selected = true;
                dgProduct_SelectionChanged(sender, e);
            }
            catch
            {
                //Reverting to last Product
            }
        }

        private void btnMakeclothes_Click(object sender, EventArgs e)
        {
            FrmStockClothes FStockClothes = new FrmStockClothes(CompanyID);
            FStockClothes.ShowDialog();

            int MyProd = Prod.Product_ID;
            int MyRow = 0;

            DataSet ds = WS.GetProducts(CompanyID, int.Parse(toolStripcbBrand.ComboBox.SelectedValue.ToString()), int.Parse(toolStripcbCategory.ComboBox.SelectedValue.ToString()), 0, 1, 0, WarehouseID);
            dgProduct.DataSource = ds.Tables[0];

            try
            {
                for (int x = 0; x < dgProduct.Rows.Count; x++)
                {
                    if (MyProd == int.Parse(dgProduct.Rows[x].Cells["Product_ID"].Value.ToString()))
                    {
                        MyRow = x;
                    }

                }

                dgProduct.CurrentCell = dgProduct.Rows[MyRow].Cells[0];
                dgProduct.Rows[MyRow].Selected = true;
                dgProduct_SelectionChanged(sender, e);
            }
            catch
            {
                //Reverting to last Product
            }

        }




    }
}
