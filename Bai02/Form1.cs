using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Paint_Event);
            this.chkVisibility.Checked = true;
            this.DoubleBuffered = true; 
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        private void Paint_Event(object sender, PaintEventArgs e)
        {
            
            if (this.ClientSize.Height >= 21 && this.ClientSize.Width >= 21)
            {
                
                Font font = new Font("Arial", 10, FontStyle.Bold);
                Brush brush = new SolidBrush(Color.Black); 
                Graphics g = e.Graphics; 
                g.Clear(this.BackColor);
                float x = r.Next(10, this.ClientSize.Width - 20); 
                float y = r.Next(10, this.ClientSize.Height - 20); 
                g.DrawString("Paint Event", font , brush, x , y); 
                brush.Dispose(); 
            }
            
        }

        private void Invalidate_Click(object sender, EventArgs e)
        {
            this.Invalidate(); 
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkVisibility.Checked == false) this.InvalidateButton.Hide(); 
            else this.InvalidateButton.Show();
            this.Invalidate(); 
        }
    }
}