﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class ProductDetailForm : Form
    {
        #region Construction

        public ProductDetailForm() //: base()
        {
            InitializeComponent();
        }

        public ProductDetailForm(string title) : this()
        {
            Text = title;
        }

        public ProductDetailForm(string title, Product product) : this(title)
        {
            Product = product;
        }
        #endregion

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Product != null)
            {
                _txtName.Text = Product.Name;
                _txtDescription.Text = Product.Description;
                _txtPrice.Text = Product.Price.ToString();
                _chkDiscontinued.Checked = Product.IsDiscontinued;
            };

            ValidateChildren();
        }

        /// <summary>Gets or sets the product being shown.</summary>
        public Product Product { get; set; }


        private void OnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            var product = new Product();
            product.Id = Product?.Id ?? 0;
            product.Name = _txtName.Text;
            product.Description = _txtDescription.Text;

            product.Price = GetPrice(_txtPrice);
            product.IsDiscontinued = _chkDiscontinued.Checked;

            //Add validation
            var error = product.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                //Show the error
                ShowError(error, "Validation Error");
                return;
            };

            Product = product;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ShowError(string message, string title)
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private decimal GetPrice( TextBox conrtol )
        {
            if (Decimal.TryParse(_txtPrice.Text, out decimal price))
                return price;

            //Validate price            
            return -1;
        }

        private void ProductDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Please no
            //var form = (Form)sender;

            //Please yes
            var form = sender as Form;

            //casting for value types
            if (sender is int)
            {
                var intValue2 = (int)sender;
            };

            //Pattern matching
            if (sender is int intValue)
            {

            };

            if (MessageBox.Show(this, "Are you sure?", "Closing", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void ProductDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ValidatingPrice(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;

            if (GetPrice(tb) < 0)
            {
                e.Cancel = true;
                _errors.SetError(_txtPrice, "Price must be >=0");
            }else
                _errors.SetError(_txtPrice, "");
        }

        private void ValidatingName(object sender, EventArgs e)
        {
            var tb = sender as TextBox;

            if (String.IsNullOrEmpty(tb.Text))
            {
                _errors.SetError(tb, "Name Is Required");
            }
            else
                _errors.SetError(tb, "");
        }
    }
}
