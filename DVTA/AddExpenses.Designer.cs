namespace DVTA
{
    partial class addExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addExpenses));
            this.textItem = new System.Windows.Forms.ComboBox();
            this.textDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textItem
            // 
            this.textItem.FormattingEnabled = true;
            this.textItem.Items.AddRange(new object[] {
            "Grocery",
            "Clothes",
            "Footwear",
            "cosmetics",
            "HouseRent",
            "Education",
            "Travelling",
            "HospitalFee",
            "Furniture"});
            this.textItem.Location = new System.Drawing.Point(209, 135);
            this.textItem.Name = "textItem";
            this.textItem.Size = new System.Drawing.Size(200, 21);
            this.textItem.TabIndex = 0;
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(209, 95);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(200, 20);
            this.textDate.TabIndex = 1;
            this.textDate.ValueChanged += new System.EventHandler(this.textDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price";
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.Location = new System.Drawing.Point(118, 143);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(27, 13);
            this.item.TabIndex = 3;
            this.item.Text = "Item";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(118, 102);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.label3_Click);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(209, 178);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(200, 20);
            this.textPrice.TabIndex = 5;
            this.textPrice.TextChanged += new System.EventHandler(this.textPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add Expenses";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(322, 229);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // addExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 347);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addExpenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox textItem;
        private System.Windows.Forms.DateTimePicker textDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label item;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Cancel;
    }
}