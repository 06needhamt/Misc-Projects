namespace stock_list
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblStallNumber = new System.Windows.Forms.Label();
            this.lblStockNumber = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBoughtPrice = new System.Windows.Forms.Label();
            this.lblSoldPrice = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStockNumber = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPaidprice = new System.Windows.Forms.TextBox();
            this.txtSoldPrice = new System.Windows.Forms.TextBox();
            this.txtStallNumber = new System.Windows.Forms.ComboBox();
            this.btnQueryDescription = new System.Windows.Forms.Button();
            this.btnQueryStockNumber = new System.Windows.Forms.Button();
            this.btnQueryStallNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblStallNumber
            // 
            this.lblStallNumber.AutoSize = true;
            this.lblStallNumber.Location = new System.Drawing.Point(13, 49);
            this.lblStallNumber.Name = "lblStallNumber";
            this.lblStallNumber.Size = new System.Drawing.Size(67, 13);
            this.lblStallNumber.TabIndex = 0;
            this.lblStallNumber.Text = "Stall Number";
            // 
            // lblStockNumber
            // 
            this.lblStockNumber.AutoSize = true;
            this.lblStockNumber.Location = new System.Drawing.Point(13, 76);
            this.lblStockNumber.Name = "lblStockNumber";
            this.lblStockNumber.Size = new System.Drawing.Size(75, 13);
            this.lblStockNumber.TabIndex = 1;
            this.lblStockNumber.Text = "Stock Number";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 101);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Item Description";
            // 
            // lblBoughtPrice
            // 
            this.lblBoughtPrice.AutoSize = true;
            this.lblBoughtPrice.Location = new System.Drawing.Point(12, 127);
            this.lblBoughtPrice.Name = "lblBoughtPrice";
            this.lblBoughtPrice.Size = new System.Drawing.Size(58, 13);
            this.lblBoughtPrice.TabIndex = 3;
            this.lblBoughtPrice.Text = "Paid Price ";
            // 
            // lblSoldPrice
            // 
            this.lblSoldPrice.AutoSize = true;
            this.lblSoldPrice.Location = new System.Drawing.Point(13, 157);
            this.lblSoldPrice.Name = "lblSoldPrice";
            this.lblSoldPrice.Size = new System.Drawing.Size(55, 13);
            this.lblSoldPrice.TabIndex = 4;
            this.lblSoldPrice.Text = "Sold Price";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStockNumber
            // 
            this.txtStockNumber.Location = new System.Drawing.Point(96, 76);
            this.txtStockNumber.Name = "txtStockNumber";
            this.txtStockNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStockNumber.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(96, 102);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 8;
            // 
            // txtPaidprice
            // 
            this.txtPaidprice.Location = new System.Drawing.Point(96, 128);
            this.txtPaidprice.Name = "txtPaidprice";
            this.txtPaidprice.Size = new System.Drawing.Size(100, 20);
            this.txtPaidprice.TabIndex = 9;
            // 
            // txtSoldPrice
            // 
            this.txtSoldPrice.Location = new System.Drawing.Point(96, 154);
            this.txtSoldPrice.Name = "txtSoldPrice";
            this.txtSoldPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSoldPrice.TabIndex = 10;
            // 
            // txtStallNumber
            // 
            this.txtStallNumber.FormattingEnabled = true;
            this.txtStallNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.txtStallNumber.Location = new System.Drawing.Point(96, 46);
            this.txtStallNumber.Name = "txtStallNumber";
            this.txtStallNumber.Size = new System.Drawing.Size(100, 21);
            this.txtStallNumber.TabIndex = 11;
            // 
            // btnQueryDescription
            // 
            this.btnQueryDescription.Location = new System.Drawing.Point(78, 228);
            this.btnQueryDescription.Name = "btnQueryDescription";
            this.btnQueryDescription.Size = new System.Drawing.Size(132, 23);
            this.btnQueryDescription.TabIndex = 13;
            this.btnQueryDescription.Text = "Query by Description";
            this.btnQueryDescription.UseVisualStyleBackColor = true;
            this.btnQueryDescription.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnQueryStockNumber
            // 
            this.btnQueryStockNumber.Location = new System.Drawing.Point(78, 257);
            this.btnQueryStockNumber.Name = "btnQueryStockNumber";
            this.btnQueryStockNumber.Size = new System.Drawing.Size(132, 23);
            this.btnQueryStockNumber.TabIndex = 14;
            this.btnQueryStockNumber.Text = "Query by Stock Number";
            this.btnQueryStockNumber.UseVisualStyleBackColor = true;
            this.btnQueryStockNumber.Click += new System.EventHandler(this.btnQueryStockNumber_Click);
            // 
            // btnQueryStallNumber
            // 
            this.btnQueryStallNumber.Location = new System.Drawing.Point(78, 286);
            this.btnQueryStallNumber.Name = "btnQueryStallNumber";
            this.btnQueryStallNumber.Size = new System.Drawing.Size(132, 23);
            this.btnQueryStallNumber.TabIndex = 15;
            this.btnQueryStallNumber.Text = "Query by Stall Number";
            this.btnQueryStallNumber.UseVisualStyleBackColor = true;
            this.btnQueryStallNumber.Click += new System.EventHandler(this.btnQueryStallNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQueryStallNumber);
            this.Controls.Add(this.btnQueryStockNumber);
            this.Controls.Add(this.btnQueryDescription);
            this.Controls.Add(this.txtStallNumber);
            this.Controls.Add(this.txtSoldPrice);
            this.Controls.Add(this.txtPaidprice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtStockNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSoldPrice);
            this.Controls.Add(this.lblBoughtPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblStockNumber);
            this.Controls.Add(this.lblStallNumber);
            this.Name = "Form1";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStallNumber;
        private System.Windows.Forms.Label lblStockNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBoughtPrice;
        private System.Windows.Forms.Label lblSoldPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStockNumber;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPaidprice;
        private System.Windows.Forms.TextBox txtSoldPrice;
        private System.Windows.Forms.ComboBox txtStallNumber;
        private System.Windows.Forms.Button btnQueryDescription;
        private System.Windows.Forms.Button btnQueryStockNumber;
        private System.Windows.Forms.Button btnQueryStallNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

