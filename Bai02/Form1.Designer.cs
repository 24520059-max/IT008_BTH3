namespace Bai02
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
            this.InvalidateButton = new System.Windows.Forms.Button();
            this.chkVisibility = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // InvalidateButton
            // 
            this.InvalidateButton.Location = new System.Drawing.Point(315, 143);
            this.InvalidateButton.Name = "InvalidateButton";
            this.InvalidateButton.Size = new System.Drawing.Size(170, 73);
            this.InvalidateButton.TabIndex = 0;
            this.InvalidateButton.Text = "Invalidate";
            this.InvalidateButton.UseVisualStyleBackColor = true;
            this.InvalidateButton.Click += new System.EventHandler(this.Invalidate_Click);
            // 
            // chkVisibility
            // 
            this.chkVisibility.Checked = true;
            this.chkVisibility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisibility.Location = new System.Drawing.Point(12, 12);
            this.chkVisibility.Name = "chkVisibility";
            this.chkVisibility.Size = new System.Drawing.Size(33, 35);
            this.chkVisibility.TabIndex = 1;
            this.chkVisibility.Text = "checkBox1";
            this.chkVisibility.UseVisualStyleBackColor = true;
            this.chkVisibility.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 391);
            this.Controls.Add(this.chkVisibility);
            this.Controls.Add(this.InvalidateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Event);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox chkVisibility;

        private System.Windows.Forms.Button InvalidateButton;

        #endregion
    }
}