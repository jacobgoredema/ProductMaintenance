using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class frmProductMain : Form
    {
        private List<Product> products = null;

        public frmProductMain()
        {
            InitializeComponent();
        }

        private void frmProductMain_Load(object sender, EventArgs e)
        {
            products = ProductDb.GetProducts();
            FillProductListBox();
        }

        private void FillProductListBox()
        {
            lstProducts.Items.Clear();
            foreach (Product p in products)
            {
                lstProducts.Items.Add(p.GetDisplayText("\t"));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewProduct newProductForm = new frmNewProduct();
            Product product = newProductForm.GetNewProduct();
            
            if (product!=null)
            {
                products.Add(product);
                ProductDb.SaveProducts(products);
                FillProductListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstProducts.SelectedIndex;
            if (i!=-1)
            {
                Product product = products[i];
                string message = "Are you sure you want to delete " + product.Description + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);

                if (button==DialogResult.Yes)
                {
                    products.Remove(product);
                    ProductDb.SaveProducts(products);
                    FillProductListBox();
                }
            }

            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
