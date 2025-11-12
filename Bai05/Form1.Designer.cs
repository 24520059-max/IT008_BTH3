namespace Bai05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txbAns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Plus = new System.Windows.Forms.Button();
            this.Minux = new System.Windows.Forms.Button();
            this.Times = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(66, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(164, 36);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(394, 26);
            this.txb1.TabIndex = 2;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(164, 91);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(394, 26);
            this.txb2.TabIndex = 3;
            // 
            // txbAns
            // 
            this.txbAns.Location = new System.Drawing.Point(164, 243);
            this.txbAns.Name = "txbAns";
            this.txbAns.Size = new System.Drawing.Size(394, 26);
            this.txbAns.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(66, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Answer";
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(200, 152);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(59, 56);
            this.Plus.TabIndex = 6;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minux
            // 
            this.Minux.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minux.Location = new System.Drawing.Point(279, 152);
            this.Minux.Name = "Minux";
            this.Minux.Size = new System.Drawing.Size(59, 56);
            this.Minux.TabIndex = 7;
            this.Minux.Text = "-";
            this.Minux.UseVisualStyleBackColor = true;
            this.Minux.Click += new System.EventHandler(this.Minux_Click);
            // 
            // Times
            // 
            this.Times.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Times.Location = new System.Drawing.Point(357, 152);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(59, 56);
            this.Times.TabIndex = 8;
            this.Times.Text = "x";
            this.Times.UseVisualStyleBackColor = true;
            this.Times.Click += new System.EventHandler(this.Times_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(438, 152);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(59, 56);
            this.Division.TabIndex = 9;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 331);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.Minux);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbAns);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab02-Example";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Minux;
        private System.Windows.Forms.Button Times;
        private System.Windows.Forms.Button Division;

        private System.Windows.Forms.Button Plus;

        private System.Windows.Forms.TextBox txbAns;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;

        #endregion
    }
}