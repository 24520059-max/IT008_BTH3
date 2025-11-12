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
        private bool flag = false;   //The hien cho viec co xoa man hinh khong 
        private bool isNewSession = true; //Danh dau phien lam viec 
        private char? lastOperator = null; 
        public Form1()
        {
            InitializeComponent();
            screen.Padding = new Padding(6,0,6,0); 
            
        }

        public void ClearScreen()
        {
            if (flag)
            {
                screen.Text = "";
                flag = false; //Neu clearScreen bi chay thi flag = false => bat dau 1 session moi 
            }
        }

        public bool CheckIsZeroDivision()
        {
            int cnt = 0; 
            foreach(char c in screenLabel.Text)
                if (c == '+' || c == '*' || c == '/' || c == '-')
                    return false; //La phep chia cho 0 
            return true; //Khong la phep chia cho khong 
        }

        public void UpdateScreen(char ch)
        {
            if (flag == true)
            {
                lastOperator = ch;
                labelText = labelText.Remove(labelText.Length - 1, 1); 
                labelText += ch.ToString();
                screenLabel.Text = labelText;
                return; 
            }
            double m;
            if (!double.TryParse(screen.Text, out m)) 
                //Gia tri hien tai dang nam tren man hin duoc luu vao trong bien m 
                return;
            if (isNewSession)
            {
                currentResult = m; //Gan curenResult = m neu day la 1 sion moi 
                isNewSession = false;
            }
            else
            {
                switch (lastOperator)
                {
                    case '+': currentResult += m; break;   //curentResult la ket qua hien tai 
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

            // Cập nhật phép toán mới (để dùng ở lần tới)
            lastOperator = ch;

            // Cập nhật màn hình
            labelText += screen.Text + $"{ch}";
            screenLabel.Text = labelText;
            screen.Text = currentResult.ToString();
            
            flag = true;  //Thuc hien xoa man hinh 
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            ClearScreen(); 
            screen.Text += "0"; 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ClearScreen(); 
            screen.Text += "1"; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ClearScreen(); 
            screen.Text += "2"; 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ClearScreen(); 
            screen.Text += "3"; 
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ClearScreen(); 
            screen.Text += "4"; 
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ClearScreen();
            screen.Text += "5"; 
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ClearScreen(); 
            screen.Text += "6"; 
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ClearScreen(); 
            screen.Text += "7"; 
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ClearScreen(); 
            screen.Text += "8"; 
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ClearScreen(); 
            screen.Text += "9"; 
        }

        private void button19_Click(object sender, EventArgs e)
        { //Dau cong 
            UpdateScreen('+');
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            UpdateScreen('-');
        }

        private void Times_Click(object sender, EventArgs e)
        {
            UpdateScreen('*');
        }

        private void Division_Click(object sender, EventArgs e)
        {
            UpdateScreen('/');
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                return; 
            }
            else
            {
                isNewSession = true;
                double m = 0; 
                bool chk = double.TryParse(screen.Text, out m);
                if (!chk) return; 
                switch (lastOperator)
                {
                    case '+': currentResult += m; break; 
                    case '-': currentResult -= m; break; 
                    case '*': currentResult *= m; break; 
                    case '/':
                        if (m == 0)
                        {
                            MessageBox.Show("Khong the chia cho mot so khac 0");
                            return; 
                        } 
                        else currentResult /= m;
                        break; 
                }

                labelText = "";
                screenLabel.Text = "";
                screen.Text = currentResult.ToString();
                lastOperator = null;
                isNewSession = true; 
            } 
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            //Reset lai tat ca cac bien 
            labelText = "";
            lastOperator = null; 
            labelText = "";
            screenLabel.Text = "";
            screen.Text = "";
            currentResult = 0; 
            lastOperator = null;
            isNewSession = true;
            // isNewSession = true;
            flag = false; 
        }

        private void Backsapce_Click(object sender, EventArgs e)
        {
            if (screen.Text == "") return;
            screen.Text.Remove(screen.Text.Length - 1, 1); 
        }

        private void button21_Click(object sender, EventArgs e) //Nut thay doi cong va tru 
        {
            if (screen.Text == "") return;
            double m = 0; 
            bool chk = double.TryParse(screen.Text, out m);
            if (!chk)
            {
                MessageBox.Show("Du lieu nhap vao khong hop le");
                return; 
            }

            if (m > 0) m = -m;
            else m = Math.Abs(m);
            screen.Text = m.ToString(); 
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            ClearScreen();
            screen.Text += "."; 
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                double m = 0;
                if (screen.Text == "") return; 
                bool chk = double.TryParse(screen.Text, out m);
                if (!chk) return;
                labelText += $"sqrt({m})";
                screenLabel.Text = labelText; 
                currentResult += Math.Round(Math.Sqrt(m), 5); 
                screen.Text = currentResult.ToString();
                flag = true; 
            }
            else
            {
                double m = 0; 
                bool chk = double.TryParse(screen.Text, out m);
                if (!chk) return; 
                double initialM = m;
                
                m = Math.Round(Math.Sqrt(m), 5);
                switch (lastOperator)
                {
                    case '+': currentResult += m; break;   //curentResult la ket qua hien tai 
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
                labelText += $"sqrt({initialM})";
                screenLabel.Text = labelText;
                screen.Text = currentResult.ToString();
                flag = true; 
            }
        }
    }
}