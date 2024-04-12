using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Tiktok_Login_Design
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UserControlUseQRcodeToLogin : UserControl
    {

        // UserControl overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            LinkLabel3 = new LinkLabel();
            LinkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel3_LinkClicked);
            Guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Guna2HtmlLabel1
            // 
            Guna2HtmlLabel1.BackColor = Color.Transparent;
            Guna2HtmlLabel1.Font = new Font("Microsoft Tai Le", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2HtmlLabel1.Location = new Point(102, 31);
            Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            Guna2HtmlLabel1.Size = new Size(278, 39);
            Guna2HtmlLabel1.TabIndex = 2;
            Guna2HtmlLabel1.Text = "Log in with QR code";
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.BorderRadius = 1;
            Guna2PictureBox1.FillColor = Color.FromArgb(242, 242, 242);
            Guna2PictureBox1.Image = My.Resources.Resources.QR_Code_Image;
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(35, 95);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.Size = new Size(413, 147);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox1.TabIndex = 3;
            Guna2PictureBox1.TabStop = false;
            // 
            // Guna2HtmlLabel2
            // 
            Guna2HtmlLabel2.BackColor = Color.Transparent;
            Guna2HtmlLabel2.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2HtmlLabel2.Location = new Point(35, 282);
            Guna2HtmlLabel2.Name = "Guna2HtmlLabel2";
            Guna2HtmlLabel2.Size = new Size(288, 21);
            Guna2HtmlLabel2.TabIndex = 4;
            Guna2HtmlLabel2.Text = "1. Scan with your mobile device’s camera";
            // 
            // Guna2HtmlLabel3
            // 
            Guna2HtmlLabel3.BackColor = Color.Transparent;
            Guna2HtmlLabel3.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold);
            Guna2HtmlLabel3.Location = new Point(35, 315);
            Guna2HtmlLabel3.Name = "Guna2HtmlLabel3";
            Guna2HtmlLabel3.Size = new Size(182, 21);
            Guna2HtmlLabel3.TabIndex = 5;
            Guna2HtmlLabel3.Text = "2. Confirm login or sign up";
            // 
            // Guna2Separator1
            // 
            Guna2Separator1.Location = new Point(-2, 442);
            Guna2Separator1.Name = "Guna2Separator1";
            Guna2Separator1.Size = new Size(569, 10);
            Guna2Separator1.TabIndex = 6;
            // 
            // LinkLabel3
            // 
            LinkLabel3.ActiveLinkColor = Color.FromArgb(137, 143, 147);
            LinkLabel3.AutoSize = true;
            LinkLabel3.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkLabel3.LinkColor = Color.FromArgb(247, 17, 65);
            LinkLabel3.Location = new Point(297, 502);
            LinkLabel3.Name = "LinkLabel3";
            LinkLabel3.Size = new Size(55, 16);
            LinkLabel3.TabIndex = 31;
            LinkLabel3.TabStop = true;
            LinkLabel3.Text = "Sign up";
            // 
            // Guna2HtmlLabel4
            // 
            Guna2HtmlLabel4.BackColor = Color.Transparent;
            Guna2HtmlLabel4.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Guna2HtmlLabel4.Location = new Point(138, 499);
            Guna2HtmlLabel4.Name = "Guna2HtmlLabel4";
            Guna2HtmlLabel4.Size = new Size(159, 21);
            Guna2HtmlLabel4.TabIndex = 30;
            Guna2HtmlLabel4.Text = "Don’t have an account?";
            // 
            // Guna2DragControl1
            // 
            Guna2DragControl1.DockIndicatorTransparencyValue = 0.6d;
            Guna2DragControl1.TargetControl = this;
            Guna2DragControl1.UseTransparentDrag = true;
            // 
            // Guna2DragControl2
            // 
            Guna2DragControl2.DockIndicatorTransparencyValue = 0.6d;
            Guna2DragControl2.TargetControl = Guna2HtmlLabel1;
            Guna2DragControl2.UseTransparentDrag = true;
            // 
            // UserControlUseQRcodeToLogin
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(LinkLabel3);
            Controls.Add(Guna2HtmlLabel4);
            Controls.Add(Guna2Separator1);
            Controls.Add(Guna2HtmlLabel3);
            Controls.Add(Guna2HtmlLabel2);
            Controls.Add(Guna2PictureBox1);
            Controls.Add(Guna2HtmlLabel1);
            Name = "UserControlUseQRcodeToLogin";
            Size = new Size(482, 531);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel2;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel3;
        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator1;
        internal LinkLabel LinkLabel3;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel4;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl2;
    }
}