using ProductMaintenance.Models;
using ProductMaintenance.ViewModels;
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
    public partial class frmProducts : Form
    {
        ProductList products = new ProductList();

        public frmProducts()
        {
            InitializeComponent();
        }

        // create the delegate an identify the method it uses 
        ProductList.ChangeHandler myDelegate = new ProductList.ChangeHandler(PrintToConsole);

        private static void PrintToConsole(ProductList products)
        {
            Console.WriteLine("The products list has changed!");
            for (int i = 0; i < products.Count; i++)
            {
                Product p = products[i];
                Console.WriteLine(p.GetDisplayText("\t"));
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // wire the event to the method that handles the event
            products.Changed += new ProductList.ChangeHandler(PrintToConsole);

            // add products to the product list
            products.Add("BJWN", "Beginning Java with NetBeans", 57.50m);
            products.Add("CS15", "C# 2015", 56.5m);

            // call the delegate and pass the required argument
            myDelegate(products);
        }
    }
}
