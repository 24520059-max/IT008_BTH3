using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Plus_Click(object sender, EventArgs e)
    {
      double n1 = 0, n2 = 0; 
      bool chk1 = double.TryParse(txb1.Text, out n1);
      bool chk2 = double.TryParse(txb2.Text, out n2);
      if (chk1 == false || chk2 == false)
      {
        MessageBox.Show("Thong tin nhap khong hop le. Vui long nhap lai");
        return;
      }
      else txbAns.Text = (n1 + n2).ToString(); 
    }

    private void Minux_Click(object sender, EventArgs e)
    {
      double n1 = 0, n2 = 0; 
      bool chk1 = double.TryParse(txb1.Text, out n1);
      bool chk2 = double.TryParse(txb2.Text, out n2);
      if (chk1 == false || chk2 == false)
      {
        MessageBox.Show("Thong tin nhap khong hop le. Vui long nhap lai");
        return;
      }
      else txbAns.Text = (n1 - n2).ToString(); 
    }

    private void Times_Click(object sender, EventArgs e)
    {
      double n1 = 0, n2 = 0; 
      bool chk1 = double.TryParse(txb1.Text, out n1);
      bool chk2 = double.TryParse(txb2.Text, out n2);
      if (chk1 == false || chk2 == false)
      {
        MessageBox.Show("Thong tin nhap khong hop le. Vui long nhap lai");
        return;
      }
      else txbAns.Text = (n1 * n2).ToString(); 
    }

    private void Division_Click(object sender, EventArgs e)
    {
      double n1 = 0, n2 = 0; 
      bool chk1 = double.TryParse(txb1.Text, out n1);
      bool chk2 = double.TryParse(txb2.Text, out n2);
      if (chk1 == false || chk2 == false)
      {
        MessageBox.Show("Thong tin nhap khong hop le. Vui long nhap lai");
        return;
      }

      if (n2 == 0)
      {
        MessageBox.Show("Khong the chia cho 0");
        return; 
      }
      else txbAns.Text = (n1 / n2).ToString(); 
    }
  }
}
