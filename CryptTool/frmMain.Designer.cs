namespace CryptTool
{
    partial class frmMain
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
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnAES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRSA
            // 
            this.btnRSA.Location = new System.Drawing.Point(93, 51);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(75, 23);
            this.btnRSA.TabIndex = 0;
            this.btnRSA.Text = "RSA";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnAES
            // 
            this.btnAES.Location = new System.Drawing.Point(93, 100);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(75, 23);
            this.btnAES.TabIndex = 1;
            this.btnAES.Text = "AES";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 176);
            this.Controls.Add(this.btnAES);
            this.Controls.Add(this.btnRSA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加密辅助工具 v1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnAES;
    }
}