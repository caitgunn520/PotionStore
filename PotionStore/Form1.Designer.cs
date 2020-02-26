namespace PotionStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calculateTotal = new System.Windows.Forms.Button();
            this.printReceipt = new System.Windows.Forms.Button();
            this.calculateChange = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.healPotLabel = new System.Windows.Forms.Label();
            this.manaPotLabel = new System.Windows.Forms.Label();
            this.strPotLabel = new System.Windows.Forms.Label();
            this.healPotInput = new System.Windows.Forms.TextBox();
            this.manaPotInput = new System.Windows.Forms.TextBox();
            this.strPotInput = new System.Windows.Forms.TextBox();
            this.orderCostLabel = new System.Windows.Forms.Label();
            this.paymentAmount = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.orderCostOutput = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.recShopName = new System.Windows.Forms.Label();
            this.recDate = new System.Windows.Forms.Label();
            this.recHealPot = new System.Windows.Forms.Label();
            this.recManaPot = new System.Windows.Forms.Label();
            this.recStrPot = new System.Windows.Forms.Label();
            this.recOrderCost = new System.Windows.Forms.Label();
            this.recTaxAmount = new System.Windows.Forms.Label();
            this.recTotalCost = new System.Windows.Forms.Label();
            this.recTendered = new System.Windows.Forms.Label();
            this.recChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateTotal
            // 
            this.calculateTotal.Location = new System.Drawing.Point(54, 159);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(107, 32);
            this.calculateTotal.TabIndex = 0;
            this.calculateTotal.Text = "Calculate Total";
            this.calculateTotal.UseVisualStyleBackColor = true;
            this.calculateTotal.Click += new System.EventHandler(this.CalculateTotal_Click);
            // 
            // printReceipt
            // 
            this.printReceipt.Location = new System.Drawing.Point(55, 384);
            this.printReceipt.Name = "printReceipt";
            this.printReceipt.Size = new System.Drawing.Size(107, 32);
            this.printReceipt.TabIndex = 1;
            this.printReceipt.Text = "Print Receipt";
            this.printReceipt.UseVisualStyleBackColor = true;
            this.printReceipt.Click += new System.EventHandler(this.PrintReceipt_Click);
            // 
            // calculateChange
            // 
            this.calculateChange.Location = new System.Drawing.Point(53, 311);
            this.calculateChange.Name = "calculateChange";
            this.calculateChange.Size = new System.Drawing.Size(107, 32);
            this.calculateChange.TabIndex = 2;
            this.calculateChange.Text = "Calculate Change";
            this.calculateChange.UseVisualStyleBackColor = true;
            this.calculateChange.Click += new System.EventHandler(this.CalculateChange_Click);
            // 
            // newOrder
            // 
            this.newOrder.Location = new System.Drawing.Point(485, 384);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(107, 32);
            this.newOrder.TabIndex = 3;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // healPotLabel
            // 
            this.healPotLabel.Location = new System.Drawing.Point(51, 41);
            this.healPotLabel.Name = "healPotLabel";
            this.healPotLabel.Size = new System.Drawing.Size(143, 30);
            this.healPotLabel.TabIndex = 4;
            this.healPotLabel.Text = "Number of Healing Potions";
            // 
            // manaPotLabel
            // 
            this.manaPotLabel.Location = new System.Drawing.Point(51, 84);
            this.manaPotLabel.Name = "manaPotLabel";
            this.manaPotLabel.Size = new System.Drawing.Size(143, 28);
            this.manaPotLabel.TabIndex = 5;
            this.manaPotLabel.Text = "Number of Mana Potions";
            // 
            // strPotLabel
            // 
            this.strPotLabel.Location = new System.Drawing.Point(51, 127);
            this.strPotLabel.Name = "strPotLabel";
            this.strPotLabel.Size = new System.Drawing.Size(143, 29);
            this.strPotLabel.TabIndex = 6;
            this.strPotLabel.Text = "Number of Strength Potions";
            // 
            // healPotInput
            // 
            this.healPotInput.Location = new System.Drawing.Point(210, 38);
            this.healPotInput.Name = "healPotInput";
            this.healPotInput.Size = new System.Drawing.Size(99, 20);
            this.healPotInput.TabIndex = 7;
            // 
            // manaPotInput
            // 
            this.manaPotInput.Location = new System.Drawing.Point(210, 81);
            this.manaPotInput.Name = "manaPotInput";
            this.manaPotInput.Size = new System.Drawing.Size(99, 20);
            this.manaPotInput.TabIndex = 8;
            // 
            // strPotInput
            // 
            this.strPotInput.Location = new System.Drawing.Point(210, 124);
            this.strPotInput.Name = "strPotInput";
            this.strPotInput.Size = new System.Drawing.Size(99, 20);
            this.strPotInput.TabIndex = 9;
            // 
            // orderCostLabel
            // 
            this.orderCostLabel.Location = new System.Drawing.Point(52, 203);
            this.orderCostLabel.Name = "orderCostLabel";
            this.orderCostLabel.Size = new System.Drawing.Size(61, 23);
            this.orderCostLabel.TabIndex = 10;
            this.orderCostLabel.Text = "Sub Total";
            this.orderCostLabel.Click += new System.EventHandler(this.OrderCostLabel_Click);
            // 
            // paymentAmount
            // 
            this.paymentAmount.Location = new System.Drawing.Point(54, 285);
            this.paymentAmount.Name = "paymentAmount";
            this.paymentAmount.Size = new System.Drawing.Size(106, 20);
            this.paymentAmount.TabIndex = 11;
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(52, 356);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(61, 20);
            this.changeLabel.TabIndex = 12;
            this.changeLabel.Text = "Change";
            this.changeLabel.Click += new System.EventHandler(this.ChangeLabel_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.Location = new System.Drawing.Point(52, 226);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(61, 21);
            this.taxLabel.TabIndex = 13;
            this.taxLabel.Text = "Tax";
            // 
            // orderCostOutput
            // 
            this.orderCostOutput.Location = new System.Drawing.Point(137, 203);
            this.orderCostOutput.Name = "orderCostOutput";
            this.orderCostOutput.Size = new System.Drawing.Size(172, 21);
            this.orderCostOutput.TabIndex = 14;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Location = new System.Drawing.Point(52, 247);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(61, 21);
            this.totalCostLabel.TabIndex = 15;
            this.totalCostLabel.Text = "Total";
            // 
            // taxOutput
            // 
            this.taxOutput.Location = new System.Drawing.Point(137, 226);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(172, 21);
            this.taxOutput.TabIndex = 16;
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.Location = new System.Drawing.Point(137, 247);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(172, 21);
            this.totalCostOutput.TabIndex = 17;
            // 
            // changeOutput
            // 
            this.changeOutput.Location = new System.Drawing.Point(137, 356);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(169, 25);
            this.changeOutput.TabIndex = 18;
            // 
            // recShopName
            // 
            this.recShopName.Location = new System.Drawing.Point(421, 38);
            this.recShopName.Name = "recShopName";
            this.recShopName.Size = new System.Drawing.Size(171, 19);
            this.recShopName.TabIndex = 19;
            this.recShopName.Text = "Potion Shop";
            this.recShopName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recDate
            // 
            this.recDate.Location = new System.Drawing.Point(421, 58);
            this.recDate.Name = "recDate";
            this.recDate.Size = new System.Drawing.Size(171, 19);
            this.recDate.TabIndex = 20;
            this.recDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recHealPot
            // 
            this.recHealPot.Location = new System.Drawing.Point(421, 89);
            this.recHealPot.Name = "recHealPot";
            this.recHealPot.Size = new System.Drawing.Size(171, 19);
            this.recHealPot.TabIndex = 21;
            this.recHealPot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recManaPot
            // 
            this.recManaPot.Location = new System.Drawing.Point(421, 112);
            this.recManaPot.Name = "recManaPot";
            this.recManaPot.Size = new System.Drawing.Size(171, 19);
            this.recManaPot.TabIndex = 22;
            this.recManaPot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recStrPot
            // 
            this.recStrPot.Location = new System.Drawing.Point(421, 137);
            this.recStrPot.Name = "recStrPot";
            this.recStrPot.Size = new System.Drawing.Size(171, 19);
            this.recStrPot.TabIndex = 23;
            this.recStrPot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recOrderCost
            // 
            this.recOrderCost.Location = new System.Drawing.Point(421, 172);
            this.recOrderCost.Name = "recOrderCost";
            this.recOrderCost.Size = new System.Drawing.Size(171, 19);
            this.recOrderCost.TabIndex = 24;
            this.recOrderCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recTaxAmount
            // 
            this.recTaxAmount.Location = new System.Drawing.Point(421, 203);
            this.recTaxAmount.Name = "recTaxAmount";
            this.recTaxAmount.Size = new System.Drawing.Size(171, 19);
            this.recTaxAmount.TabIndex = 25;
            this.recTaxAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recTotalCost
            // 
            this.recTotalCost.Location = new System.Drawing.Point(421, 231);
            this.recTotalCost.Name = "recTotalCost";
            this.recTotalCost.Size = new System.Drawing.Size(171, 19);
            this.recTotalCost.TabIndex = 26;
            this.recTotalCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.recTotalCost.Click += new System.EventHandler(this.RecTotalCost_Click);
            // 
            // recTendered
            // 
            this.recTendered.Location = new System.Drawing.Point(421, 262);
            this.recTendered.Name = "recTendered";
            this.recTendered.Size = new System.Drawing.Size(171, 19);
            this.recTendered.TabIndex = 27;
            this.recTendered.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recChange
            // 
            this.recChange.Location = new System.Drawing.Point(421, 292);
            this.recChange.Name = "recChange";
            this.recChange.Size = new System.Drawing.Size(171, 19);
            this.recChange.TabIndex = 28;
            this.recChange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.recChange);
            this.Controls.Add(this.recTendered);
            this.Controls.Add(this.recTotalCost);
            this.Controls.Add(this.recTaxAmount);
            this.Controls.Add(this.recOrderCost);
            this.Controls.Add(this.recStrPot);
            this.Controls.Add(this.recManaPot);
            this.Controls.Add(this.recHealPot);
            this.Controls.Add(this.recDate);
            this.Controls.Add(this.recShopName);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalCostOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.orderCostOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.paymentAmount);
            this.Controls.Add(this.orderCostLabel);
            this.Controls.Add(this.strPotInput);
            this.Controls.Add(this.manaPotInput);
            this.Controls.Add(this.healPotInput);
            this.Controls.Add(this.strPotLabel);
            this.Controls.Add(this.manaPotLabel);
            this.Controls.Add(this.healPotLabel);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.calculateChange);
            this.Controls.Add(this.printReceipt);
            this.Controls.Add(this.calculateTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Potion Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateTotal;
        private System.Windows.Forms.Button printReceipt;
        private System.Windows.Forms.Button calculateChange;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Label healPotLabel;
        private System.Windows.Forms.Label manaPotLabel;
        private System.Windows.Forms.Label strPotLabel;
        private System.Windows.Forms.TextBox healPotInput;
        private System.Windows.Forms.TextBox manaPotInput;
        private System.Windows.Forms.TextBox strPotInput;
        private System.Windows.Forms.Label orderCostLabel;
        private System.Windows.Forms.TextBox paymentAmount;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label orderCostOutput;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label recShopName;
        private System.Windows.Forms.Label recDate;
        private System.Windows.Forms.Label recHealPot;
        private System.Windows.Forms.Label recManaPot;
        private System.Windows.Forms.Label recStrPot;
        private System.Windows.Forms.Label recOrderCost;
        private System.Windows.Forms.Label recTaxAmount;
        private System.Windows.Forms.Label recTotalCost;
        private System.Windows.Forms.Label recTendered;
        private System.Windows.Forms.Label recChange;
    }
}

