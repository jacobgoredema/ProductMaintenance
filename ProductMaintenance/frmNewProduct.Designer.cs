namespace ProductMaintenance
{
    partial class frmNewProduct
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdoBook = new System.Windows.Forms.RadioButton();
            this.rdoSoftware = new System.Windows.Forms.RadioButton();
            this.lblAuthorOrVersion = new System.Windows.Forms.Label();
            this.txtAuthorOrVersion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(103, 117);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(156, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(103, 171);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(156, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(103, 80);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(156, 20);
            this.txtCode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(36, 178);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(85, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdoBook
            // 
            this.rdoBook.AutoSize = true;
            this.rdoBook.Checked = true;
            this.rdoBook.Location = new System.Drawing.Point(39, 26);
            this.rdoBook.Name = "rdoBook";
            this.rdoBook.Size = new System.Drawing.Size(50, 17);
            this.rdoBook.TabIndex = 0;
            this.rdoBook.TabStop = true;
            this.rdoBook.Text = "Book";
            this.rdoBook.UseVisualStyleBackColor = true;
            this.rdoBook.CheckedChanged += new System.EventHandler(this.rdoBook_CheckedChanged);
            // 
            // rdoSoftware
            // 
            this.rdoSoftware.AutoSize = true;
            this.rdoSoftware.Location = new System.Drawing.Point(151, 26);
            this.rdoSoftware.Name = "rdoSoftware";
            this.rdoSoftware.Size = new System.Drawing.Size(67, 17);
            this.rdoSoftware.TabIndex = 1;
            this.rdoSoftware.Text = "Software";
            this.rdoSoftware.UseVisualStyleBackColor = true;
            this.rdoSoftware.CheckedChanged += new System.EventHandler(this.rdoSoftware_CheckedChanged);
            // 
            // lblAuthorOrVersion
            // 
            this.lblAuthorOrVersion.AutoSize = true;
            this.lblAuthorOrVersion.Location = new System.Drawing.Point(37, 150);
            this.lblAuthorOrVersion.Name = "lblAuthorOrVersion";
            this.lblAuthorOrVersion.Size = new System.Drawing.Size(41, 13);
            this.lblAuthorOrVersion.TabIndex = 6;
            this.lblAuthorOrVersion.Text = "Author:";
            // 
            // txtAuthorOrVersion
            // 
            this.txtAuthorOrVersion.Location = new System.Drawing.Point(104, 143);
            this.txtAuthorOrVersion.Name = "txtAuthorOrVersion";
            this.txtAuthorOrVersion.Size = new System.Drawing.Size(156, 20);
            this.txtAuthorOrVersion.TabIndex = 7;
            // 
            // frmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAuthorOrVersion);
            this.Controls.Add(this.txtAuthorOrVersion);
            this.Controls.Add(this.rdoSoftware);
            this.Controls.Add(this.rdoBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSave);
            this.Name = "frmNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewProduct";
            this.Load += new System.EventHandler(this.frmNewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdoBook;
        private System.Windows.Forms.RadioButton rdoSoftware;
        private System.Windows.Forms.Label lblAuthorOrVersion;
        private System.Windows.Forms.TextBox txtAuthorOrVersion;
    }
}