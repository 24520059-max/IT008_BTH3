namespace Bai09_1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Cơ sở dữ liệu");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Cơ sở DL - NC");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("PTTK Hệ thống thông tin");
            this.dataView = new System.Windows.Forms.DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCouting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSubject2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveSubject = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstSubject1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.txbStudentName = new System.Windows.Forms.TextBox();
            this.cbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.txbStudentID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.studentID, this.studentName, this.studentField, this.studentGender, this.subjectCouting });
            this.dataView.Location = new System.Drawing.Point(-1, 497);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 28;
            this.dataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataView.Size = new System.Drawing.Size(931, 238);
            this.dataView.TabIndex = 0;
            // 
            // studentID
            // 
            this.studentID.HeaderText = "MSSV";
            this.studentID.Name = "studentID";
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Họ tên";
            this.studentName.Name = "studentName";
            this.studentName.Width = 175;
            // 
            // studentField
            // 
            this.studentField.HeaderText = "Chuyên ngành";
            this.studentField.Name = "studentField";
            this.studentField.Width = 180;
            // 
            // studentGender
            // 
            this.studentGender.HeaderText = "Giới tính";
            this.studentGender.Name = "studentGender";
            this.studentGender.Width = 70;
            // 
            // subjectCouting
            // 
            this.subjectCouting.HeaderText = "Số môn";
            this.subjectCouting.Name = "subjectCouting";
            this.subjectCouting.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSubject2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRemoveSubject);
            this.groupBox1.Controls.Add(this.btnAddSubject);
            this.groupBox1.Controls.Add(this.btnRemoveStudent);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lstSubject1);
            this.groupBox1.Controls.Add(this.txbStudentName);
            this.groupBox1.Controls.Add(this.cbChuyenNganh);
            this.groupBox1.Controls.Add(this.txbStudentID);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(905, 468);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // lstSubject2
            // 
            this.lstSubject2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.columnHeader2 });
            this.lstSubject2.HideSelection = false;
            this.lstSubject2.Location = new System.Drawing.Point(558, 264);
            this.lstSubject2.Name = "lstSubject2";
            this.lstSubject2.Size = new System.Drawing.Size(294, 109);
            this.lstSubject2.TabIndex = 16;
            this.lstSubject2.UseCompatibleStateImageBehavior = false;
            this.lstSubject2.View = System.Windows.Forms.View.List;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 250;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Giới tính";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chuyên ngành";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Họ tên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã sinh viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemoveSubject
            // 
            this.btnRemoveSubject.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSubject.Location = new System.Drawing.Point(484, 326);
            this.btnRemoveSubject.Name = "btnRemoveSubject";
            this.btnRemoveSubject.Size = new System.Drawing.Size(53, 47);
            this.btnRemoveSubject.TabIndex = 10;
            this.btnRemoveSubject.Text = "<";
            this.btnRemoveSubject.UseVisualStyleBackColor = true;
            this.btnRemoveSubject.Click += new System.EventHandler(this.btnRemoveSubject_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.Location = new System.Drawing.Point(484, 273);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(53, 47);
            this.btnAddSubject.TabIndex = 9;
            this.btnAddSubject.Text = ">";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.Location = new System.Drawing.Point(515, 397);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(147, 46);
            this.btnRemoveStudent.TabIndex = 8;
            this.btnRemoveStudent.Text = "Xóa chọn";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(352, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Lưu thông tin";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstSubject1
            // 
            this.lstSubject1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.columnHeader1 });
            this.lstSubject1.HideSelection = false;
            this.lstSubject1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            this.lstSubject1.Location = new System.Drawing.Point(171, 264);
            this.lstSubject1.Name = "lstSubject1";
            this.lstSubject1.Size = new System.Drawing.Size(294, 109);
            this.lstSubject1.TabIndex = 5;
            this.lstSubject1.UseCompatibleStateImageBehavior = false;
            this.lstSubject1.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 250;
            // 
            // txbStudentName
            // 
            this.txbStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbStudentName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStudentName.Location = new System.Drawing.Point(352, 83);
            this.txbStudentName.Name = "txbStudentName";
            this.txbStudentName.Size = new System.Drawing.Size(396, 31);
            this.txbStudentName.TabIndex = 3;
            // 
            // cbChuyenNganh
            // 
            this.cbChuyenNganh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuyenNganh.FormattingEnabled = true;
            this.cbChuyenNganh.Items.AddRange(new object[] { "Kĩ thuật phần mềm", "Công nghệ thông tin", "Khoa học máy tính", "Hệ thống thông tin", "Khoa học dữ liệu", "An toàn thông tin", "Mạng máy tính", "Truyền thông đa phương tiện", "Thương mại điện tử", "Trí tuệ nhân tạo", "Kĩ thuật máy tính", "Thiết kế vi mạch" });
            this.cbChuyenNganh.Location = new System.Drawing.Point(352, 130);
            this.cbChuyenNganh.Name = "cbChuyenNganh";
            this.cbChuyenNganh.Size = new System.Drawing.Size(283, 33);
            this.cbChuyenNganh.TabIndex = 2;
            // 
            // txbStudentID
            // 
            this.txbStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbStudentID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStudentID.Location = new System.Drawing.Point(352, 35);
            this.txbStudentID.Name = "txbStudentID";
            this.txbStudentID.Size = new System.Drawing.Size(206, 31);
            this.txbStudentID.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.female);
            this.panel1.Controls.Add(this.male);
            this.panel1.Location = new System.Drawing.Point(352, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 61);
            this.panel1.TabIndex = 4;
            // 
            // female
            // 
            this.female.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(132, 14);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(115, 33);
            this.female.TabIndex = 17;
            this.female.TabStop = true;
            this.female.Text = "Nữ";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(3, 14);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(115, 33);
            this.male.TabIndex = 16;
            this.male.TabStop = true;
            this.male.Text = "Nam";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chọn các môn học tham gia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(929, 739);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataView);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ColumnHeader columnHeader2;

        private System.Windows.Forms.ColumnHeader columnHeader1;

        private System.Windows.Forms.RadioButton female;

        private System.Windows.Forms.RadioButton male;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnRemoveSubject;

        private System.Windows.Forms.Button btnAddSubject;

        private System.Windows.Forms.Button btnRemoveStudent;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.ListView lstSubject2;

        private System.Windows.Forms.ListView lstSubject1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.ComboBox cbChuyenNganh;

        private System.Windows.Forms.TextBox txbStudentName;

        private System.Windows.Forms.TextBox txbStudentID;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentField;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCouting;

        private System.Windows.Forms.DataGridView dataView;

        #endregion
    }
}