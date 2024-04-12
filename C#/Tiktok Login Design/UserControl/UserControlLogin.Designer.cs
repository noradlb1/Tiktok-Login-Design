using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Tiktok_Login_Design
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UserControlLogin : UserControl
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
            Guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LinkLabel1 = new LinkLabel();
            Label1 = new Label();
            Guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LinkLabel2 = new LinkLabel();
            LinkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
            Guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            Guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LinkLabel3 = new LinkLabel();
            LinkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel3_LinkClicked);
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            Guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            Guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            Guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            Guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            Guna2GradientButton2.Click += new EventHandler(Guna2GradientButton2_Click);
            Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            Guna2GradientButton1.Click += new EventHandler(Guna2GradientButton1_Click);
            SuspendLayout();
            // 
            // Guna2HtmlLabel1
            // 
            Guna2HtmlLabel1.BackColor = Color.Transparent;
            Guna2HtmlLabel1.Font = new Font("Microsoft Tai Le", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2HtmlLabel1.Location = new Point(126, 31);
            Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            Guna2HtmlLabel1.Size = new Size(225, 39);
            Guna2HtmlLabel1.TabIndex = 1;
            Guna2HtmlLabel1.Text = "Log in to TikTok";
            // 
            // Guna2HtmlLabel2
            // 
            Guna2HtmlLabel2.BackColor = Color.Transparent;
            Guna2HtmlLabel2.ForeColor = Color.FromArgb(137, 143, 147);
            Guna2HtmlLabel2.Location = new Point(103, 436);
            Guna2HtmlLabel2.Name = "Guna2HtmlLabel2";
            Guna2HtmlLabel2.Size = new Size(177, 15);
            Guna2HtmlLabel2.TabIndex = 7;
            Guna2HtmlLabel2.Text = "By continuing, you agree to TikTok’s ";
            // 
            // LinkLabel1
            // 
            LinkLabel1.ActiveLinkColor = Color.FromArgb(137, 143, 147);
            LinkLabel1.AutoSize = true;
            LinkLabel1.LinkColor = Color.Black;
            LinkLabel1.Location = new Point(277, 436);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(87, 13);
            LinkLabel1.TabIndex = 8;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "Terms of Service";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.FromArgb(137, 143, 147);
            Label1.Location = new Point(362, 437);
            Label1.Name = "Label1";
            Label1.Size = new Size(25, 13);
            Label1.TabIndex = 9;
            Label1.Text = "and";
            // 
            // Guna2HtmlLabel3
            // 
            Guna2HtmlLabel3.BackColor = Color.Transparent;
            Guna2HtmlLabel3.ForeColor = Color.FromArgb(137, 143, 147);
            Guna2HtmlLabel3.Location = new Point(123, 454);
            Guna2HtmlLabel3.Name = "Guna2HtmlLabel3";
            Guna2HtmlLabel3.Size = new Size(174, 15);
            Guna2HtmlLabel3.TabIndex = 10;
            Guna2HtmlLabel3.Text = "confirm that you have read TikTok’s";
            // 
            // LinkLabel2
            // 
            LinkLabel2.ActiveLinkColor = Color.FromArgb(137, 143, 147);
            LinkLabel2.AutoSize = true;
            LinkLabel2.LinkColor = Color.Black;
            LinkLabel2.Location = new Point(297, 454);
            LinkLabel2.Name = "LinkLabel2";
            LinkLabel2.Size = new Size(76, 13);
            LinkLabel2.TabIndex = 11;
            LinkLabel2.TabStop = true;
            LinkLabel2.Text = "Privacy Policy.";
            // 
            // Guna2Separator1
            // 
            Guna2Separator1.Location = new Point(3, 484);
            Guna2Separator1.Name = "Guna2Separator1";
            Guna2Separator1.Size = new Size(476, 10);
            Guna2Separator1.TabIndex = 12;
            // 
            // Guna2HtmlLabel4
            // 
            Guna2HtmlLabel4.BackColor = Color.Transparent;
            Guna2HtmlLabel4.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Guna2HtmlLabel4.Location = new Point(138, 499);
            Guna2HtmlLabel4.Name = "Guna2HtmlLabel4";
            Guna2HtmlLabel4.Size = new Size(159, 21);
            Guna2HtmlLabel4.TabIndex = 13;
            Guna2HtmlLabel4.Text = "Don’t have an account?";
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
            LinkLabel3.TabIndex = 14;
            LinkLabel3.TabStop = true;
            LinkLabel3.Text = "Sign up";
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
            // Guna2GradientButton6
            // 
            Guna2GradientButton6.BackColor = Color.Transparent;
            Guna2GradientButton6.BorderColor = Color.FromArgb(208, 209, 210);
            Guna2GradientButton6.BorderRadius = 5;
            Guna2GradientButton6.BorderThickness = 1;
            Guna2GradientButton6.Cursor = Cursors.Hand;
            Guna2GradientButton6.DisabledState.BorderColor = Color.DarkGray;
            Guna2GradientButton6.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2GradientButton6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2GradientButton6.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Guna2GradientButton6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2GradientButton6.FillColor = Color.Transparent;
            Guna2GradientButton6.FillColor2 = Color.Transparent;
            Guna2GradientButton6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            Guna2GradientButton6.ForeColor = Color.Black;
            Guna2GradientButton6.Image = My.Resources.Resources.icons8_apple_32;
            Guna2GradientButton6.ImageAlign = HorizontalAlignment.Left;
            Guna2GradientButton6.Location = new Point(59, 356);
            Guna2GradientButton6.Name = "Guna2GradientButton6";
            Guna2GradientButton6.Size = new Size(366, 35);
            Guna2GradientButton6.TabIndex = 6;
            Guna2GradientButton6.Text = "Continue with Twitter";
            // 
            // Guna2GradientButton5
            // 
            Guna2GradientButton5.BackColor = Color.Transparent;
            Guna2GradientButton5.BorderColor = Color.FromArgb(208, 209, 210);
            Guna2GradientButton5.BorderRadius = 5;
            Guna2GradientButton5.BorderThickness = 1;
            Guna2GradientButton5.Cursor = Cursors.Hand;
            Guna2GradientButton5.DisabledState.BorderColor = Color.DarkGray;
            Guna2GradientButton5.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2GradientButton5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2GradientButton5.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Guna2GradientButton5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2GradientButton5.FillColor = Color.Transparent;
            Guna2GradientButton5.FillColor2 = Color.Transparent;
            Guna2GradientButton5.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            Guna2GradientButton5.ForeColor = Color.Black;
            Guna2GradientButton5.Image = My.Resources.Resources.icons8_twitter_32;
            Guna2GradientButton5.ImageAlign = HorizontalAlignment.Left;
            Guna2GradientButton5.Location = new Point(59, 304);
            Guna2GradientButton5.Name = "Guna2GradientButton5";
            Guna2GradientButton5.Size = new Size(366, 35);
            Guna2GradientButton5.TabIndex = 5;
            Guna2GradientButton5.Text = "Continue with Twitter";
            // 
            // Guna2GradientButton4
            // 
            Guna2GradientButton4.BackColor = Color.Transparent;
            Guna2GradientButton4.BorderColor = Color.FromArgb(208, 209, 210);
            Guna2GradientButton4.BorderRadius = 5;
            Guna2GradientButton4.BorderThickness = 1;
            Guna2GradientButton4.Cursor = Cursors.Hand;
            Guna2GradientButton4.DisabledState.BorderColor = Color.DarkGray;
            Guna2GradientButton4.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2GradientButton4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2GradientButton4.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Guna2GradientButton4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2GradientButton4.FillColor = Color.Transparent;
            Guna2GradientButton4.FillColor2 = Color.Transparent;
            Guna2GradientButton4.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            Guna2GradientButton4.ForeColor = Color.Black;
            Guna2GradientButton4.Image = My.Resources.Resources.icons8_google_32;
            Guna2GradientButton4.ImageAlign = HorizontalAlignment.Left;
            Guna2GradientButton4.Location = new Point(59, 253);
            Guna2GradientButton4.Name = "Guna2GradientButton4";
            Guna2GradientButton4.Size = new Size(366, 35);
            Guna2GradientButton4.TabIndex = 4;
            Guna2GradientButton4.Text = "Continue with Google";
            // 
            // Guna2GradientButton3
            // 
            Guna2GradientButton3.BackColor = Color.Transparent;
            Guna2GradientButton3.BorderColor = Color.FromArgb(208, 209, 210);
            Guna2GradientButton3.BorderRadius = 5;
            Guna2GradientButton3.BorderThickness = 1;
            Guna2GradientButton3.Cursor = Cursors.Hand;
            Guna2GradientButton3.DisabledState.BorderColor = Color.DarkGray;
            Guna2GradientButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2GradientButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2GradientButton3.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Guna2GradientButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2GradientButton3.FillColor = Color.Transparent;
            Guna2GradientButton3.FillColor2 = Color.Transparent;
            Guna2GradientButton3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            Guna2GradientButton3.ForeColor = Color.Black;
            Guna2GradientButton3.Image = My.Resources.Resources.icons8_facebook_32;
            Guna2GradientButton3.ImageAlign = HorizontalAlignment.Left;
            Guna2GradientButton3.Location = new Point(59, 203);
            Guna2GradientButton3.Name = "Guna2GradientButton3";
            Guna2GradientButton3.Size = new Size(366, 35);
            Guna2GradientButton3.TabIndex = 3;
            Guna2GradientButton3.Text = "Continue with Facebook";
            // 
            // Guna2GradientButton2
            // 
            Guna2GradientButton2.BackColor = Color.Transparent;
            Guna2GradientButton2.BorderColor = Color.FromArgb(208, 209, 210);
            Guna2GradientButton2.BorderRadius = 5;
            Guna2GradientButton2.BorderThickness = 1;
            Guna2GradientButton2.Cursor = Cursors.Hand;
            Guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray;
            Guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2GradientButton2.FillColor = Color.Transparent;
            Guna2GradientButton2.FillColor2 = Color.Transparent;
            Guna2GradientButton2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            Guna2GradientButton2.ForeColor = Color.Black;
            Guna2GradientButton2.Image = My.Resources.Resources.icons8_user_32;
            Guna2GradientButton2.ImageAlign = HorizontalAlignment.Left;
            Guna2GradientButton2.Location = new Point(59, 153);
            Guna2GradientButton2.Name = "Guna2GradientButton2";
            Guna2GradientButton2.Size = new Size(366, 35);
            Guna2GradientButton2.TabIndex = 2;
            Guna2GradientButton2.Text = "Use phone / email / username";
            // 
            // Guna2GradientButton1
            // 
            Guna2GradientButton1.BackColor = Color.Transparent;
            Guna2GradientButton1.BorderColor = Color.FromArgb(208, 209, 210);
            Guna2GradientButton1.BorderRadius = 5;
            Guna2GradientButton1.BorderThickness = 1;
            Guna2GradientButton1.Cursor = Cursors.Hand;
            Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2GradientButton1.FillColor = Color.Transparent;
            Guna2GradientButton1.FillColor2 = Color.Transparent;
            Guna2GradientButton1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            Guna2GradientButton1.ForeColor = Color.Black;
            Guna2GradientButton1.Image = My.Resources.Resources.icons8_qr_code_32;
            Guna2GradientButton1.ImageAlign = HorizontalAlignment.Left;
            Guna2GradientButton1.Location = new Point(59, 103);
            Guna2GradientButton1.Name = "Guna2GradientButton1";
            Guna2GradientButton1.Size = new Size(366, 35);
            Guna2GradientButton1.TabIndex = 0;
            Guna2GradientButton1.Text = "Use QR code";
            // 
            // UserControlLogin
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LinkLabel3);
            Controls.Add(Guna2HtmlLabel4);
            Controls.Add(Guna2Separator1);
            Controls.Add(LinkLabel2);
            Controls.Add(Guna2HtmlLabel3);
            Controls.Add(Label1);
            Controls.Add(LinkLabel1);
            Controls.Add(Guna2HtmlLabel2);
            Controls.Add(Guna2GradientButton6);
            Controls.Add(Guna2GradientButton5);
            Controls.Add(Guna2GradientButton4);
            Controls.Add(Guna2GradientButton3);
            Controls.Add(Guna2GradientButton2);
            Controls.Add(Guna2HtmlLabel1);
            Controls.Add(Guna2GradientButton1);
            Name = "UserControlLogin";
            Size = new Size(482, 531);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton2;
        internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton3;
        internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton4;
        internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton5;
        internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton6;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel2;
        internal LinkLabel LinkLabel1;
        internal Label Label1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel3;
        internal LinkLabel LinkLabel2;
        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel4;
        internal LinkLabel LinkLabel3;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl2;
    }
}