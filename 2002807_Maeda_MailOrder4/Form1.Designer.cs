namespace _2002807_Maeda_MailOrder4
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
            this.boxCustomer = new System.Windows.Forms.GroupBox();
            this.zipInput = new System.Windows.Forms.MaskedTextBox();
            this.stateInput = new System.Windows.Forms.MaskedTextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.labelZIP = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.boxProduct = new System.Windows.Forms.GroupBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.descInput = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.updateSummary = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.boxSummary = new System.Windows.Forms.GroupBox();
            this.labelDollarAmount = new System.Windows.Forms.Label();
            this.labelSalesTax = new System.Windows.Forms.Label();
            this.labelHandling = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.amountDueOutput = new System.Windows.Forms.TextBox();
            this.salesTaxOutput = new System.Windows.Forms.TextBox();
            this.handlingOutput = new System.Windows.Forms.TextBox();
            this.totalAmountOutput = new System.Windows.Forms.TextBox();
            this.boxCustomer.SuspendLayout();
            this.boxProduct.SuspendLayout();
            this.boxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxCustomer
            // 
            this.boxCustomer.Controls.Add(this.zipInput);
            this.boxCustomer.Controls.Add(this.stateInput);
            this.boxCustomer.Controls.Add(this.cityInput);
            this.boxCustomer.Controls.Add(this.addressInput);
            this.boxCustomer.Controls.Add(this.nameInput);
            this.boxCustomer.Controls.Add(this.labelZIP);
            this.boxCustomer.Controls.Add(this.labelState);
            this.boxCustomer.Controls.Add(this.labelCity);
            this.boxCustomer.Controls.Add(this.labelAddress);
            this.boxCustomer.Controls.Add(this.labelName);
            this.boxCustomer.Location = new System.Drawing.Point(13, 13);
            this.boxCustomer.Name = "boxCustomer";
            this.boxCustomer.Size = new System.Drawing.Size(200, 179);
            this.boxCustomer.TabIndex = 0;
            this.boxCustomer.TabStop = false;
            this.boxCustomer.Text = "Customer Info";
            // 
            // zipInput
            // 
            this.zipInput.Location = new System.Drawing.Point(94, 153);
            this.zipInput.Mask = "00000-9999";
            this.zipInput.Name = "zipInput";
            this.zipInput.Size = new System.Drawing.Size(100, 20);
            this.zipInput.TabIndex = 9;
            // 
            // stateInput
            // 
            this.stateInput.Location = new System.Drawing.Point(94, 122);
            this.stateInput.Mask = "LL";
            this.stateInput.Name = "stateInput";
            this.stateInput.Size = new System.Drawing.Size(100, 20);
            this.stateInput.TabIndex = 8;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(94, 90);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(100, 20);
            this.cityInput.TabIndex = 7;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(94, 58);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(100, 20);
            this.addressInput.TabIndex = 6;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(94, 26);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 5;
            // 
            // labelZIP
            // 
            this.labelZIP.AutoSize = true;
            this.labelZIP.Location = new System.Drawing.Point(6, 157);
            this.labelZIP.Name = "labelZIP";
            this.labelZIP.Size = new System.Drawing.Size(52, 13);
            this.labelZIP.TabIndex = 4;
            this.labelZIP.Text = "ZIP Code";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(6, 125);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "State";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(6, 93);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "City";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(6, 61);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Customer Name";
            // 
            // boxProduct
            // 
            this.boxProduct.Controls.Add(this.priceInput);
            this.boxProduct.Controls.Add(this.weightInput);
            this.boxProduct.Controls.Add(this.quantityInput);
            this.boxProduct.Controls.Add(this.descInput);
            this.boxProduct.Controls.Add(this.labelPrice);
            this.boxProduct.Controls.Add(this.labelWeight);
            this.boxProduct.Controls.Add(this.labelQuantity);
            this.boxProduct.Controls.Add(this.labelProduct);
            this.boxProduct.Location = new System.Drawing.Point(219, 13);
            this.boxProduct.Name = "boxProduct";
            this.boxProduct.Size = new System.Drawing.Size(225, 179);
            this.boxProduct.TabIndex = 1;
            this.boxProduct.TabStop = false;
            this.boxProduct.Text = "Product Info";
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(112, 140);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(100, 20);
            this.priceInput.TabIndex = 13;
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(112, 102);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(100, 20);
            this.weightInput.TabIndex = 12;
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(112, 64);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(100, 20);
            this.quantityInput.TabIndex = 11;
            // 
            // descInput
            // 
            this.descInput.Location = new System.Drawing.Point(112, 26);
            this.descInput.Name = "descInput";
            this.descInput.Size = new System.Drawing.Size(100, 20);
            this.descInput.TabIndex = 10;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(6, 143);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(6, 105);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(41, 13);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Weight";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(6, 67);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 1;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(6, 29);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(100, 13);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Product Description";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(450, 83);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(156, 27);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // updateSummary
            // 
            this.updateSummary.Location = new System.Drawing.Point(450, 13);
            this.updateSummary.Name = "updateSummary";
            this.updateSummary.Size = new System.Drawing.Size(156, 27);
            this.updateSummary.TabIndex = 4;
            this.updateSummary.Text = "Update Summary";
            this.updateSummary.UseVisualStyleBackColor = true;
            this.updateSummary.Click += new System.EventHandler(this.updateSummary_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(450, 48);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(156, 27);
            this.addItem.TabIndex = 5;
            this.addItem.Text = "Add This Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(713, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // boxSummary
            // 
            this.boxSummary.Controls.Add(this.totalAmountOutput);
            this.boxSummary.Controls.Add(this.handlingOutput);
            this.boxSummary.Controls.Add(this.salesTaxOutput);
            this.boxSummary.Controls.Add(this.amountDueOutput);
            this.boxSummary.Controls.Add(this.labelTotalAmount);
            this.boxSummary.Controls.Add(this.labelHandling);
            this.boxSummary.Controls.Add(this.labelSalesTax);
            this.boxSummary.Controls.Add(this.labelDollarAmount);
            this.boxSummary.Location = new System.Drawing.Point(13, 237);
            this.boxSummary.Name = "boxSummary";
            this.boxSummary.Size = new System.Drawing.Size(224, 179);
            this.boxSummary.TabIndex = 7;
            this.boxSummary.TabStop = false;
            this.boxSummary.Text = "Summary";
            // 
            // labelDollarAmount
            // 
            this.labelDollarAmount.AutoSize = true;
            this.labelDollarAmount.Location = new System.Drawing.Point(6, 29);
            this.labelDollarAmount.Name = "labelDollarAmount";
            this.labelDollarAmount.Size = new System.Drawing.Size(96, 13);
            this.labelDollarAmount.TabIndex = 0;
            this.labelDollarAmount.Text = "Dollar Amount Due";
            // 
            // labelSalesTax
            // 
            this.labelSalesTax.AutoSize = true;
            this.labelSalesTax.Location = new System.Drawing.Point(6, 70);
            this.labelSalesTax.Name = "labelSalesTax";
            this.labelSalesTax.Size = new System.Drawing.Size(54, 13);
            this.labelSalesTax.TabIndex = 1;
            this.labelSalesTax.Text = "Sales Tax";
            // 
            // labelHandling
            // 
            this.labelHandling.AutoSize = true;
            this.labelHandling.Location = new System.Drawing.Point(6, 111);
            this.labelHandling.Name = "labelHandling";
            this.labelHandling.Size = new System.Drawing.Size(49, 13);
            this.labelHandling.TabIndex = 2;
            this.labelHandling.Text = "Handling";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(6, 152);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(93, 13);
            this.labelTotalAmount.TabIndex = 3;
            this.labelTotalAmount.Text = "Total Amount Due";
            // 
            // amountDueOutput
            // 
            this.amountDueOutput.Location = new System.Drawing.Point(118, 26);
            this.amountDueOutput.Name = "amountDueOutput";
            this.amountDueOutput.Size = new System.Drawing.Size(100, 20);
            this.amountDueOutput.TabIndex = 4;
            // 
            // salesTaxOutput
            // 
            this.salesTaxOutput.Location = new System.Drawing.Point(118, 67);
            this.salesTaxOutput.Name = "salesTaxOutput";
            this.salesTaxOutput.Size = new System.Drawing.Size(100, 20);
            this.salesTaxOutput.TabIndex = 5;
            // 
            // handlingOutput
            // 
            this.handlingOutput.Location = new System.Drawing.Point(118, 108);
            this.handlingOutput.Name = "handlingOutput";
            this.handlingOutput.Size = new System.Drawing.Size(100, 20);
            this.handlingOutput.TabIndex = 6;
            // 
            // totalAmountOutput
            // 
            this.totalAmountOutput.Location = new System.Drawing.Point(118, 149);
            this.totalAmountOutput.Name = "totalAmountOutput";
            this.totalAmountOutput.Size = new System.Drawing.Size(100, 20);
            this.totalAmountOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxSummary);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.updateSummary);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.boxProduct);
            this.Controls.Add(this.boxCustomer);
            this.Name = "Form1";
            this.Text = "Mail Order Unit 4";
            this.boxCustomer.ResumeLayout(false);
            this.boxCustomer.PerformLayout();
            this.boxProduct.ResumeLayout(false);
            this.boxProduct.PerformLayout();
            this.boxSummary.ResumeLayout(false);
            this.boxSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxCustomer;
        private System.Windows.Forms.Label labelZIP;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox boxProduct;
        private System.Windows.Forms.MaskedTextBox zipInput;
        private System.Windows.Forms.MaskedTextBox stateInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.TextBox descInput;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button updateSummary;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox boxSummary;
        private System.Windows.Forms.TextBox totalAmountOutput;
        private System.Windows.Forms.TextBox handlingOutput;
        private System.Windows.Forms.TextBox salesTaxOutput;
        private System.Windows.Forms.TextBox amountDueOutput;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelHandling;
        private System.Windows.Forms.Label labelSalesTax;
        private System.Windows.Forms.Label labelDollarAmount;
    }
}

