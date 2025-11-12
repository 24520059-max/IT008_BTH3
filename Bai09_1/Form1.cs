using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09_1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private int getGender()
    {
      if (female.Checked == true) return -1; 
      else if (male.Checked == true) return 1;
      return 0; 
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {

      bool check = txbStudentID.Text == "" || txbStudentName.Text == "" ||
                   cbChuyenNganh.SelectedIndex == -1 || getGender() == 0;
      if (check)
      {
        MessageBox.Show("Chuc nang khong ho tro");
        return; 
      }

      for (int i = 0; i < dataView.RowCount; ++i)
      {
        DataGridViewRow row = dataView.Rows[i];
        if (row.Cells[0].Value == txbStudentID.Text)
        {
          MessageBox.Show("Ma so sinh vien da ton tai. Vui long nhap lai");
          return; 
        }
      }

      string gender = ((getGender() == 1) ? "Nam" : "Nu");
      int count = lstSubject2.Items.Count;
      string chuyenNganh = cbChuyenNganh.SelectedItem.ToString();
      MessageBox.Show(chuyenNganh); 
      dataView.Rows.Add(txbStudentID.Text.ToString(), txbStudentName.Text.ToString(), chuyenNganh,  gender, count); 
      // MessageBox.Show(cbChuyenNganh.SelectedIndex.ToString()); 
      
    }

    private void btnAddSubject_Click(object sender, EventArgs e)
    {
      if (lstSubject1.Items.Count == 0)
      {
        return; 
      }

      foreach (ListViewItem item in lstSubject1.SelectedItems)
      {
        lstSubject1.Items.Remove(item);
        lstSubject2.Items.Add(item); 
      }
    }

    private void btnRemoveSubject_Click(object sender, EventArgs e)
    {
      if (lstSubject2.Items.Count == 0)
      {
        return; 
      }

      foreach (ListViewItem item in lstSubject2.SelectedItems)
      {
        lstSubject2.Items.Remove(item);
        lstSubject1.Items.Add(item); 
      }
    }

    private void btnRemoveStudent_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dataView.SelectedRows)
      {
        dataView.Rows.Remove(row);
      }

      MessageBox.Show("Xóa dữ liệu thành công"); 
    }
  }
}
