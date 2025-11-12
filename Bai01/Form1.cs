using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // //Su kien 1: load form 
            this.Load += Form_Load;  
            // //Su kien 2: shown form 
            this.Shown += Form_Show; 
            // //Su kien 3: Form_Activated 
            this.Activated += Form_Activated; 
            // //Su kien 4: Form_deactivated 
            this.Deactivate += Form_Deactivated;  
            // //Su kien 5: Form _ closing 
            this.FormClosing += Form_Closing; 
            // //Su kien 6: Form _Closed 
            this.FormClosed += Form_Closed;
            statusLabel.MinimumSize = new Size(100, 100); 
        }

        public void Form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Load: Form Dang duoc Load du lieu"); 

        }

        public void Form_Show(object sender, EventArgs e)
        {
            statusLabel.Text = "Form Shown: Form dang hien thi lan dau"; 
        }

        public void Form_Activated(object sender, EventArgs e)
        {
            statusLabel.Text = "Form Activated: Form da duoc focus"; 
        }

        public void Form_Deactivated(object sender, EventArgs e)
        {
            statusLabel.Text = "Form Deactivated: Form da mat focus"; 
        }

        public void Form_Closing(object sender, EventArgs e)
        {
            MessageBox.Show("Form Closing: Nguoi dung dang dong form"); 
        }

        public void Form_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("Form Closed: Nguoi dung da dong form"); 
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Form phu";
            f2.Show();
        }
    }
}