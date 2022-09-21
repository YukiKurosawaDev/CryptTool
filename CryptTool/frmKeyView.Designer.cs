using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CryptTool
{
    partial class frmKeyView
    {
        private IContainer components = (IContainer)null;
        private TextBox privateKey;
        private TextBox publicKey;
        private Label label1;
        private Label label2;


        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.privateKey = new TextBox();
            this.publicKey = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.SuspendLayout();
            this.privateKey.BackColor = SystemColors.Window;
            this.privateKey.Location = new Point(13, 48);
            this.privateKey.Multiline = true;
            this.privateKey.Name = "privateKey";
            this.privateKey.ReadOnly = true;
            this.privateKey.ScrollBars = ScrollBars.Vertical;
            this.privateKey.Size = new Size(325, 425);
            this.privateKey.TabIndex = 1;
            this.publicKey.BackColor = SystemColors.Window;
            this.publicKey.Location = new Point(344, 48);
            this.publicKey.Multiline = true;
            this.publicKey.Name = "publicKey";
            this.publicKey.ReadOnly = true;
            this.publicKey.ScrollBars = ScrollBars.Vertical;
            this.publicKey.Size = new Size(325, 425);
            this.publicKey.TabIndex = 2;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(491, 22);
            this.label1.Name = "label1";
            this.label1.Size = new Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "¹«Ô¿";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(140, 22);
            this.label2.Name = "label2";
            this.label2.Size = new Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ë½Ô¿";
            this.AutoScaleDimensions = new SizeF(6f, 12f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(684, 489);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.label1);
            this.Controls.Add((Control)this.publicKey);
            this.Controls.Add((Control)this.privateKey);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKeyView";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "²é¿´ÃÜÔ¿";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}