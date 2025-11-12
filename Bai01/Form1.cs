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
            this.Load += Form_Load;  
            this.Shown += Form_Show; 
            this.Activated += Form_Activated; 
            this.Deactivate += Form_Deactivated;  
            this.FormClosing += Form_Closing; 
            this.FormClosed += Form_Closed;
            statusLabel.MinimumSize = new Size(100, 100); 
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        public void Form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Load: Form đang được tải dữ liệu"); 
        }

        public void Form_Show(object sender, EventArgs e)
        {
            statusLabel.Text = "Form Shown: Form đang hiển thị lần đầu"; 
        }

        public void Form_Activated(object sender, EventArgs e)
        {
            statusLabel.Text = "Form Activated: Form đã được focus"; 
        }

        public void Form_Deactivated(object sender, EventArgs e)
        {
            statusLabel.Text = "Form Deactivated: Form đã mất focus"; 
        }

        public void Form_Closing(object sender, EventArgs e)
        {
            MessageBox.Show("Form Closing: Người dùng đang đóng form"); 
        }

        public void Form_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("Form Closed: Người dùng đã đóng form"); 
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Form phụ";
            f2.Show();
        }
    }
}