using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PotionStore
{
    public partial class Form1 : Form
    {
        const double HEALPOTPRICE = 1.50; //sets price of healing potions
        const double MANAPOTPRICE = 2.99; //sets price of mana potions
        const double STRPOTPRICE = 3.75; //sets price of strength potions
        const double TAXRATE = 0.13;

        int healPotNum = 0; //number of healing potions
        int manaPotNum = 0; //number of mana potions
        int strPotNum = 0; //number of strength potions
        double orderCost = 0; //cost of order before tax
        double taxAmount = 0;
        double totalCost = 0;
        double amountTendered = 0; //amount customer paid
        double changeRequired = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateTotal_Click(object sender, EventArgs e)
        {
            try
            {
                healPotNum = Convert.ToInt32(healPotInput.Text);
                manaPotNum = Convert.ToInt32(manaPotInput.Text);
                strPotNum = Convert.ToInt32(strPotInput.Text);

                orderCost = healPotNum * HEALPOTPRICE + manaPotNum * MANAPOTPRICE + strPotNum * STRPOTPRICE;
                taxAmount = orderCost * TAXRATE;
                totalCost = orderCost + taxAmount;

                orderCostOutput.Text = orderCost.ToString("$0.00");
                taxOutput.Text = taxAmount.ToString("$0.00");
                totalCostOutput.Text = totalCost.ToString("$0.00");
            }
            catch
            {
                MessageBox.Show("Invalid amount entered", "Error", MessageBoxButtons.OK);
            }

            
        }

        private void CalculateChange_Click(object sender, EventArgs e)
        {
            try
            {
                amountTendered = Convert.ToDouble(paymentAmount.Text);
                changeRequired = amountTendered - totalCost;

                changeOutput.Text = changeRequired.ToString("$0.00");
            }
            catch
            {
                MessageBox.Show("Invalid payment amount", "Error", MessageBoxButtons.OK);
            }
        }

        private void PrintReceipt_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.cash_register_wav);
            player.Play();
            recDate.Text = DateTime.Now.ToString("dd-MM-yy");
            recDate.Refresh();
            Thread.Sleep(1000);

            recHealPot.Text = $"Healing Potions x{healPotNum} @ {HEALPOTPRICE}";
            recHealPot.Refresh();
            Thread.Sleep(1000);

            recManaPot.Text = $"Mana Potions x{manaPotNum} @ {MANAPOTPRICE}";
            recManaPot.Refresh();
            Thread.Sleep(1000);

            recStrPot.Text = $"Strength Potions x{strPotNum} @ {STRPOTPRICE}";
            recStrPot.Refresh();
            Thread.Sleep(1000);

            recOrderCost.Text = $"Subtotal {orderCost.ToString("$0.00")}";
            recOrderCost.Refresh();
            Thread.Sleep(1000);

            recTaxAmount.Text = $"Tax {taxAmount.ToString("$0.00")}";
            recTaxAmount.Refresh();
            Thread.Sleep(1000);

            recTotalCost.Text = $"Total {totalCost.ToString("$0.00")}";
            recTotalCost.Refresh();
            Thread.Sleep(1000);

            recTendered.Text = $"Tendered {amountTendered.ToString("$0.00")}";
            recTendered.Refresh();
            Thread.Sleep(1000);

            recChange.Text = $"Change {changeRequired.ToString("$0.00")}";
            recChange.Refresh();
            Thread.Sleep(1000);
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            healPotInput.Text = ""; //empties text boxes
            manaPotInput.Text = "";
            strPotInput.Text = "";
            paymentAmount.Text = "";

            orderCostOutput.Text = ""; //resets outputs
            taxOutput.Text = "";
            totalCostOutput.Text = "";
            changeOutput.Text = "";
            recDate.Text = "";
            recHealPot.Text = "";
            recManaPot.Text = "";
            recStrPot.Text = "";
            recOrderCost.Text = "";
            recTaxAmount.Text = "";
            recTotalCost.Text = "";
            recTendered.Text = "";
            recChange.Text = "";

            healPotNum = 0;
            manaPotNum = 0;
            strPotNum = 0;
            orderCost = 0;
            taxAmount = 0;
            totalCost = 0;
            amountTendered = 0;
            changeRequired = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OrderCostLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChangeLabel_Click(object sender, EventArgs e)
        {

        }

        private void RecTotalCost_Click(object sender, EventArgs e)
        {

        }


    }
}
