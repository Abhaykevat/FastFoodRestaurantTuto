using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodRestaurantTuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if(FriesCb.Checked==true)
            {
                FriesTb.Enabled = true;
            }
            if(FriesCb.Checked==false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }

        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void CheeseCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseCb.Checked == true)
            {
                CheeseTb.Enabled = true;
            }
            if (CheeseCb.Checked == false)
            {
                CheeseTb.Enabled = false;
                CheeseTb.Text = "0";
            }
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }

        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if (WaterCb.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void PancakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakesCb.Checked == true)
            {
                PancakesTb.Enabled = true;
            }
            if (PancakesCb.Checked == false)
            {
                PancakesTb.Enabled = false;
                PancakesTb.Text = "0";
            }
        }

        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCb.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }

        double friesup = 50, burgerup = 80, saladup = 100, sandwichup = 75, cheeseup = 80,chickenup=80;

        private void button1_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            SandwichCb.Checked = false;
            ChickenCb.Checked = false;
            CheeseCb.Checked = false;

            TeaCb.Checked = false;
            ColaCb.Checked = false;
            WaterCb.Checked = false;
            ChocolateCb.Checked = false;
            PancakesCb.Checked = false;
            OrangeCb.Checked = false;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text+" Subtotal "+Subtotallbl.Text+" Tax "+taxlbl.Text+" grand total "+Grdtotallbl.Text,new Font("Century Gothic",18,FontStyle.Regular),Brushes.Blue,new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        double waterup = 15, teaup = 15, colaup = 20, chocolateup = 25, pancakesup = 30, orangeup = 25;
        double friestp, burgertp, saladtp, sandwichtp,chickentp, cheesetp, watertp, teatp, colatp, chocolatetp, pancaktp, orangetp;
        double subtotal=0,tax,grdtotal;

        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTb.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTb.Text);

            watertp = waterup * Convert.ToDouble(WaterTb.Text);
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            colatp = colaup * Convert.ToDouble(ColaTb.Text);
            chocolatetp = chocolateup * Convert.ToDouble(ChocolateTb.Text);
            pancaktp = pancakesup * Convert.ToDouble(PancakesTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);

            ReceiptTb.Clear();
            tax = 0;
            grdtotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\tBlack Pearl Restro \t\t" +Datelbl.Text+ Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t**************************" + Environment.NewLine);


            if(FriesCb.Checked==true)
            {
                ReceiptTb.AppendText("\tFries:\t"+friestp+"Rs"+Environment.NewLine);
                subtotal = subtotal + friestp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + burgertp + "Rs" + Environment.NewLine);
                subtotal = subtotal + burgertp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (SandwichCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSandwich:\t" + sandwichtp + "Rs" + Environment.NewLine);
                subtotal = subtotal + sandwichtp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSalad:\t" + saladtp + "Rs" + Environment.NewLine);
                subtotal = subtotal +saladtp;
                Subtotallbl.Text = "" + subtotal;
            }
            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChicken:\t" + chickentp + "Rs" + Environment.NewLine);
                subtotal = subtotal + chickentp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (CheeseCb.Checked == true)
            {
                ReceiptTb.AppendText("\tcheese:\t" + cheesetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + cheesetp;
                Subtotallbl.Text = "" + subtotal;
            }




            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tTea:\t" + teatp + "Rs" + Environment.NewLine);
                subtotal = subtotal + teatp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (ColaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCola:\t" + colatp + "Rs" + Environment.NewLine);
                subtotal = subtotal + colatp;
                Subtotallbl.Text = "" + subtotal;
            }
            if (WaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\twater:\t" + watertp + "Rs" + Environment.NewLine);
                subtotal = subtotal + watertp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (ChocolateCb.Checked == true)
            {
                ReceiptTb.AppendText("\tchocolate:\t" + chocolatetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + chocolatetp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (PancakesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tpancakes:\t" + pancaktp + "Rs" + Environment.NewLine);
                subtotal = subtotal + pancaktp;
                Subtotallbl.Text = "" + subtotal;
            }

            if (OrangeCb.Checked == true)
            {
                ReceiptTb.AppendText("\torange:\t" + orangetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + orangetp;
                Subtotallbl.Text = "" + subtotal;
            }
            tax = subtotal * 0.16;
            grdtotal = subtotal + tax;
            taxlbl.Text = "Rs" + tax;
            Grdtotallbl.Text = "Rs" + grdtotal;




        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
