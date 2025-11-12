using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        private double total = 0;
        private bool isCalculated = false; 
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White) btn.BackColor = Color.Blue; 
            else if (btn.BackColor == Color.Blue) btn.BackColor = Color.White; //Toggle Button 
            else if (btn.BackColor == Color.Yellow) MessageBox.Show("Vị trí đã được đặt"); 
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn đặt không?", "Order", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return; 
            }
            foreach (Control btn in this.Controls)
            {
                if (btn.GetType() == (new Button()).GetType())
                {
                    Button button = btn as Button; 
                    if (button.BackColor == Color.Blue)
                    {
                        int k = int.Parse(button.Text);
                        if (k >= 1 && k <= 5) total += 5000;
                        if (k >= 6 && k <= 10) total += 6500;
                        else total += 8000;
                        button.BackColor = Color.Yellow; 
                    }
                }
                
            }

            lbResult.Text = total.ToString() + " VNĐ"; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control btn in this.Controls)
            {
                if (btn.GetType() == (new Button()).GetType())
                {
                    Button button = btn as Button;
                    if (button.BackColor == Color.Blue)
                        button.BackColor = Color.White; 
                }
            }
            lbResult.Text = "0 VNĐ"; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to exit?", "Close", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close(); 
            }
        }
    }
}