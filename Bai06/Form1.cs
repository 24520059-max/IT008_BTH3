using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        private double currentResult = 0;
        private string labelText = "";
        private bool flag = false;
        private bool isNewSession = true;
        private char? lastOperator = null;

        public Form1()
        {
            InitializeComponent();
            screen.Padding = new Padding(6, 0, 6, 0);
        }

        public void ClearScreen()
        {
            if (flag)
            {
                screen.Text = "";
                flag = false;
            }
        }

        public void UpdateScreen(char ch)
        {
            if (flag)
            {
                lastOperator = ch;
                if (labelText.Length > 0)
                    labelText = labelText.Remove(labelText.Length - 1, 1);
                labelText += ch.ToString();
                screenLabel.Text = labelText;
                return;
            }

            if (!double.TryParse(screen.Text, out double m)) return;

            if (isNewSession)
            {
                currentResult = m;
                isNewSession = false;
            }
            else
            {
                switch (lastOperator)
                {
                    case '+': currentResult += m; break;
                    case '-': currentResult -= m; break;
                    case '*': currentResult *= m; break;
                    case '/':
                        if (m == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0");
                            return;
                        }
                        currentResult /= m;
                        break;
                }
            }

            lastOperator = ch;
            labelText += screen.Text + ch;
            screenLabel.Text = labelText;
            screen.Text = currentResult.ToString();
            flag = true;
        }

        private void btn0_Click(object sender, EventArgs e) { ClearScreen(); screen.Text += "0"; }
        private void btn1_Click(object sender, EventArgs e) { ClearScreen(); screen.Text += "1"; }
        private void btn2_Click(object sender, EventArgs e) { ClearScreen(); screen.Text += "2"; }
        private void btn3_Click(object sender, EventArgs e) { ClearScreen(); screen.Text += "3"; }
        private void btn4_Click(object sender, EventArgs e) { ClearScreen(); screen.Text += "4"; }
        private void btn5_Click(object sender, EventArgs e) { ClearScreen(); screen.Text += "5"; }
        private void btn6_Click(object sender, EventArgs e) { ClearScreen(); screen.Text += "6"; }
        private void btn7_Click(object sender, EventArgs e) { ClearScreen(); screen.Text += "7"; }
        private void btn8_Click(object sender, EventArgs e) { ClearScreen(); screen.Text += "8"; }
        private void btn9_Click(object sender, EventArgs e) { ClearScreen(); screen.Text += "9"; }

        private void button19_Click(object sender, EventArgs e) { UpdateScreen('+'); }
        private void Minus_Click(object sender, EventArgs e) { UpdateScreen('-'); }
        private void Times_Click(object sender, EventArgs e) { UpdateScreen('*'); }
        private void Division_Click(object sender, EventArgs e) { UpdateScreen('/'); }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (flag) return;

            if (!double.TryParse(screen.Text, out double m)) return;

            switch (lastOperator)
            {
                case '+': currentResult += m; break;
                case '-': currentResult -= m; break;
                case '*': currentResult *= m; break;
                case '/':
                    if (m == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0");
                        return;
                    }
                    currentResult /= m;
                    break;
                default:
                    currentResult = m;
                    break;
            }

            labelText = "";
            screenLabel.Text = "";
            screen.Text = currentResult.ToString();
            lastOperator = null;
            isNewSession = true;
            flag = true;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            labelText = "";
            lastOperator = null;
            screenLabel.Text = "";
            screen.Text = "";
            currentResult = 0;
            isNewSession = true;
            flag = false;
        }

        private void Backsapce_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length > 0)
                screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (screen.Text == "") return;
            if (!double.TryParse(screen.Text, out double m))
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ");
                return;
            }

            m = -m;
            screen.Text = m.ToString();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            ClearScreen();
            if (!screen.Text.Contains(".")) screen.Text += ".";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(screen.Text, out double m)) return;

            if (m < 0)
            {
                MessageBox.Show("Không thể căn số âm");
                return;
            }

            double sqrtValue = Math.Round(Math.Sqrt(m), 5);

            if (isNewSession)
            {
                currentResult = sqrtValue;
                isNewSession = false;
            }
            else
            {
                switch (lastOperator)
                {
                    case '+': currentResult += sqrtValue; break;
                    case '-': currentResult -= sqrtValue; break;
                    case '*': currentResult *= sqrtValue; break;
                    case '/':
                        if (sqrtValue == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0");
                            return;
                        }
                        currentResult /= sqrtValue;
                        break;
                    default:
                        currentResult = sqrtValue;
                        break;
                }
            }

            labelText += $"√({m})";
            screenLabel.Text = labelText;
            screen.Text = currentResult.ToString();
            flag = true;
        }
    }
}
