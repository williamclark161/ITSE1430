namespace Nile.Window
{
    partial class ProductDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OnSave = new System.Windows.Forms.Button();
            this.OnCancel = new System.Windows.Forms.Button();
            this._chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OnSave
            // 
            this.OnSave.Location = new System.Drawing.Point(218, 227);
            this.OnSave.Name = "OnSave";
            this.OnSave.Size = new System.Drawing.Size(75, 21);
            this.OnSave.TabIndex = 0;
            this.OnSave.Text = "Save";
            this.OnSave.UseVisualStyleBackColor = true;
            this.OnSave.Click += new System.EventHandler(this.OnSave_Click);
            // 
            // OnCancel
            // 
            this.OnCancel.Location = new System.Drawing.Point(332, 227);
            this.OnCancel.Name = "OnCancel";
            this.OnCancel.Size = new System.Drawing.Size(75, 23);
            this.OnCancel.TabIndex = 1;
            this.OnCancel.Text = "Cancel";
            this.OnCancel.UseVisualStyleBackColor = true;
            this.OnCancel.Click += new System.EventHandler(this.OnCancel_Click);
            // 
            // _chkDiscontinued
            // 
            this._chkDiscontinued.AutoSize = true;
            this._chkDiscontinued.Location = new System.Drawing.Point(115, 176);
            this._chkDiscontinued.Name = "_chkDiscontinued";
            this._chkDiscontinued.Size = new System.Drawing.Size(105, 17);
            this._chkDiscontinued.TabIndex = 2;
            this._chkDiscontinued.Text = "Is Discontinued?";
            this._chkDiscontinued.UseVisualStyleBackColor = true;
            this._chkDiscontinued.CheckedChanged += new System.EventHandler(this._chkDiscontinued_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(115, 44);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 20);
            this._txtName.TabIndex = 6;
            this._txtName.TextChanged += new System.EventHandler(this._txtName_TextChanged);
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(115, 88);
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(100, 20);
            this._txtDescription.TabIndex = 7;
            this._txtDescription.TextChanged += new System.EventHandler(this._txtDescription_TextChanged);
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(115, 134);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(100, 20);
            this._txtPrice.TabIndex = 8;
            this._txtPrice.TextChanged += new System.EventHandler(this._txtPrice_TextChanged);
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 300);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._chkDiscontinued);
            this.Controls.Add(this.OnCancel);
            this.Controls.Add(this.OnSave);
            this.Name = "ProductDetailForm";
            this.Text = "ProductDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OnSave;
        private System.Windows.Forms.Button OnCancel;
        private System.Windows.Forms.CheckBox _chkDiscontinued;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.TextBox _txtPrice;
    }
}