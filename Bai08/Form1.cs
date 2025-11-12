using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = txbAccountNumber.Text == "" || txbCustomerName.Text == "" ||
                         txbMoney.Text == "" || txbAddress.Text == "";
            if (check)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return; 
            }
            for (int i = 0; i < lstView.Items.Count; ++i)
            {
                ListViewItem item = lstView.Items[i];
                if (item.SubItems[1].Text == txbAccountNumber.Text)
                {
                    item.SubItems[2].Text = txbCustomerName.Text;
                    item.SubItems[3].Text = txbAddress.Text;
                    item.SubItems[4].Text = txbMoney.Text;
                    return;
                }
            }
            int index = lstView.Items.Count + 1;
            // MessageBox.Show(index.ToString());
            // MessageBox.Show(txbCustomerName.Text); 
            // Tạo item với index làm cột 0
            ListViewItem newItem = new ListViewItem(index.ToString());
            // Sau đó thêm các subitems cho các cột tiếp theo
            newItem.SubItems.Add(txbAccountNumber.Text);  // SubItems[1]
            newItem.SubItems.Add(txbCustomerName.Text);   // SubItems[2]
            newItem.SubItems.Add(txbAddress.Text);     // SubItems[3]
            newItem.SubItems.Add(txbMoney.Text);          // SubItems[4]
            lstView.Items.Add(newItem);
            MessageBox.Show("Thêm mới dữ liệu thành công!"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txbAccountNumber.Text == "")
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa"); 
                return; 
            }

            for (int i = 0; i < lstView.Items.Count; ++i)
            {
                ListViewItem item = lstView.Items[i];
                if (item.SubItems[1].Text == txbAccountNumber.Text)
                {
                    lstView.Items.Remove(item);  //Tien hanh xoa du lieu 
                    MessageBox.Show("Xóa tài khoản thành công"); 
                    return; 
                }
            }

            MessageBox.Show("Không tìm thấy số tài khoản cần xóa"); 
        }

        private void lstView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            foreach (ListViewItem item in lstView.SelectedItems)
            {
                txbAccountNumber.Text = item.SubItems[1].Text; 
                txbCustomerName.Text = item.SubItems[2].Text; 
                txbAddress.Text  = item.SubItems[3].Text; 
                txbMoney.Text = item.SubItems[4].Text; 
            }
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