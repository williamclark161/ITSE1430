﻿using System;
using System.Windows.Forms;

namespace Nile.Window {
    public partial class MainForm : Form 
        {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.Name = "Product A";

            var child = new ProductDetailForm("Product Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Save Product
            //var product = child.Product;
        }
    }
}
