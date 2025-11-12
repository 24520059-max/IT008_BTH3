namespace Bai08
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbMoney = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.txbAccountNumber = new System.Windows.Forms.TextBox();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.accountNumber = new System.Windows.Forms.ColumnHeader();
            this.customerName = new System.Windows.Forms.ColumnHeader();
            this.adđress = new System.Windows.Forms.ColumnHeader();
            this.money = new System.Windows.Forms.ColumnHeader();
            this.lstView = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbMoney
            // 
            this.txbMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMoney.Location = new System.Drawing.Point(286, 262);
            this.txbMoney.Name = "txbMoney";
            this.txbMoney.Size = new System.Drawing.Size(606, 35);
            this.txbMoney.TabIndex = 4;
            // 
            // txbAddress
            // 
            this.txbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(286, 206);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(606, 35);
            this.txbAddress.TabIndex = 3;
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCustomerName.Location = new System.Drawing.Point(286, 153);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(606, 35);
            this.txbCustomerName.TabIndex = 2;
            // 
            // txbAccountNumber
            // 
            this.txbAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAccountNumber.Location = new System.Drawing.Point(286, 101);
            this.txbAccountNumber.Name = "txbAccountNumber";
            this.txbAccountNumber.Size = new System.Drawing.Size(606, 35);
            this.txbAccountNumber.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 80;
            // 
            // accountNumber
            // 
            this.accountNumber.Text = "Mã tài khoản";
            this.accountNumber.Width = 270;
            // 
            // customerName
            // 
            this.customerName.Text = "Tên khách hàng";
            this.customerName.Width = 200;
            // 
            // adđress
            // 
            this.adđress.Text = "Địa chỉ";
            this.adđress.Width = 354;
            // 
            // money
            // 
            this.money.Text = "Số tiền";
            this.money.Width = 119;
            // 
            // lstView
            // 
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.STT, this.accountNumber, this.customerName, this.adđress, this.money });
            this.lstView.GridLines = true;
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(-3, 375);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(1028, 355);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstView_ItemSelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(397, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 56);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm/Cập nhật";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(600, 309);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(134, 56);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(764, 309);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 56);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 52);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ khách hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 52);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số tiền trong tài khoản";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(38, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(948, 61);
            this.label5.TabIndex = 12;
            this.label5.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 728);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbMoney);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbCustomerName);
            this.Controls.Add(this.txbAccountNumber);
            this.Controls.Add(this.lstView);
            this.Name = "Form1";
            this.Text = "Quản lý tài khoản của Cloudian";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbMoney;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.TextBox txbAccountNumber;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader accountNumber;
        private System.Windows.Forms.ColumnHeader customerName;
        private System.Windows.Forms.ColumnHeader adđress;
        private System.Windows.Forms.ColumnHeader money;
        private System.Windows.Forms.ListView lstView;

        #endregion
    }
}