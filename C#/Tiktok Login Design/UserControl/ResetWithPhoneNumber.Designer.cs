using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Tiktok_Login_Design
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ResetWithPhoneNumber : UserControl
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
            LinkLabel2 = new LinkLabel();
            LinkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
            Guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            Guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            Guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            Guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            LinkLabel3 = new LinkLabel();
            LinkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel3_LinkClicked);
            Guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            SuspendLayout();
            // 
            // Guna2HtmlLabel1
            // 
            Guna2HtmlLabel1.BackColor = Color.Transparent;
            Guna2HtmlLabel1.Font = new Font("Microsoft Tai Le", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2HtmlLabel1.Location = new Point(137, 30);
            Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            Guna2HtmlLabel1.Size = new Size(217, 39);
            Guna2HtmlLabel1.TabIndex = 5;
            Guna2HtmlLabel1.Text = "Reset password";
            // 
            // LinkLabel2
            // 
            LinkLabel2.ActiveLinkColor = Color.FromArgb(137, 143, 147);
            LinkLabel2.AutoSize = true;
            LinkLabel2.LinkColor = Color.Black;
            LinkLabel2.Location = new Point(370, 87);
            LinkLabel2.Name = "LinkLabel2";
            LinkLabel2.Size = new Size(84, 13);
            LinkLabel2.TabIndex = 53;
            LinkLabel2.TabStop = true;
            LinkLabel2.Text = "Reset with email";
            // 
            // Guna2HtmlLabel2
            // 
            Guna2HtmlLabel2.BackColor = Color.Transparent;
            Guna2HtmlLabel2.Font = new Font("Noto Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Guna2HtmlLabel2.Location = new Point(39, 80);
            Guna2HtmlLabel2.Name = "Guna2HtmlLabel2";
            Guna2HtmlLabel2.Size = new Size(129, 20);
            Guna2HtmlLabel2.TabIndex = 52;
            Guna2HtmlLabel2.Text = "Enter phone address";
            // 
            // Guna2TextBox1
            // 
            Guna2TextBox1.BackColor = Color.Transparent;
            Guna2TextBox1.BorderRadius = 6;
            Guna2TextBox1.Cursor = Cursors.IBeam;
            Guna2TextBox1.DefaultText = "";
            Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox1.FillColor = Color.FromArgb(241, 241, 242);
            Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox1.Location = new Point(42, 212);
            Guna2TextBox1.Name = "Guna2TextBox1";
            Guna2TextBox1.PasswordChar = '\0';
            Guna2TextBox1.PlaceholderText = "Password";
            Guna2TextBox1.SelectedText = "";
            Guna2TextBox1.Size = new Size(412, 36);
            Guna2TextBox1.TabIndex = 51;
            // 
            // Guna2TextBox3
            // 
            Guna2TextBox3.BackColor = Color.Transparent;
            Guna2TextBox3.BorderRadius = 6;
            Guna2TextBox3.Cursor = Cursors.IBeam;
            Guna2TextBox3.DefaultText = "";
            Guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Guna2TextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox3.FillColor = Color.FromArgb(241, 241, 242);
            Guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2TextBox3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox3.Location = new Point(158, 106);
            Guna2TextBox3.Name = "Guna2TextBox3";
            Guna2TextBox3.PasswordChar = '\0';
            Guna2TextBox3.PlaceholderText = "Phone number";
            Guna2TextBox3.SelectedText = "";
            Guna2TextBox3.Size = new Size(296, 36);
            Guna2TextBox3.TabIndex = 50;
            // 
            // Guna2GradientButton2
            // 
            Guna2GradientButton2.BackColor = Color.Transparent;
            Guna2GradientButton2.BorderRadius = 6;
            Guna2GradientButton2.Cursor = Cursors.Hand;
            Guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray;
            Guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2GradientButton2.FillColor = Color.FromArgb(193, 200, 207);
            Guna2GradientButton2.FillColor2 = Color.FromArgb(193, 200, 207);
            Guna2GradientButton2.Font = new Font("Noto Serif", 9.75f);
            Guna2GradientButton2.ForeColor = Color.White;
            Guna2GradientButton2.Location = new Point(42, 286);
            Guna2GradientButton2.Name = "Guna2GradientButton2";
            Guna2GradientButton2.Size = new Size(412, 36);
            Guna2GradientButton2.TabIndex = 49;
            Guna2GradientButton2.Text = "Log in";
            // 
            // Guna2GradientButton1
            // 
            Guna2GradientButton1.BackColor = Color.Transparent;
            Guna2GradientButton1.BorderRadius = 6;
            Guna2GradientButton1.Cursor = Cursors.Hand;
            Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2GradientButton1.FillColor = Color.FromArgb(193, 200, 207);
            Guna2GradientButton1.FillColor2 = Color.FromArgb(193, 200, 207);
            Guna2GradientButton1.Font = new Font("Noto Serif", 9.75f);
            Guna2GradientButton1.ForeColor = Color.White;
            Guna2GradientButton1.Location = new Point(341, 158);
            Guna2GradientButton1.Name = "Guna2GradientButton1";
            Guna2GradientButton1.Size = new Size(113, 36);
            Guna2GradientButton1.TabIndex = 48;
            Guna2GradientButton1.Text = "Send code";
            // 
            // Guna2TextBox2
            // 
            Guna2TextBox2.BackColor = Color.Transparent;
            Guna2TextBox2.BorderRadius = 6;
            Guna2TextBox2.Cursor = Cursors.IBeam;
            Guna2TextBox2.DefaultText = "";
            Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox2.FillColor = Color.FromArgb(241, 241, 242);
            Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox2.Location = new Point(42, 158);
            Guna2TextBox2.Name = "Guna2TextBox2";
            Guna2TextBox2.PasswordChar = '\0';
            Guna2TextBox2.PlaceholderText = "Enter 6-digit code";
            Guna2TextBox2.SelectedText = "";
            Guna2TextBox2.Size = new Size(293, 36);
            Guna2TextBox2.TabIndex = 47;
            // 
            // Guna2ComboBox1
            // 
            Guna2ComboBox1.BackColor = Color.Transparent;
            Guna2ComboBox1.BorderColor = Color.FromArgb(208, 209, 210);
            Guna2ComboBox1.BorderRadius = 6;
            Guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            Guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            Guna2ComboBox1.FillColor = Color.FromArgb(241, 241, 242);
            Guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            Guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2ComboBox1.Font = new Font("Segoe UI", 10.0f);
            Guna2ComboBox1.ForeColor = Color.Black;
            Guna2ComboBox1.ItemHeight = 30;
            Guna2ComboBox1.Items.AddRange(new object[] { "DE +49", "US +1", "UK +44" });
            Guna2ComboBox1.Location = new Point(39, 106);
            Guna2ComboBox1.Name = "Guna2ComboBox1";
            Guna2ComboBox1.Size = new Size(113, 36);
            Guna2ComboBox1.StartIndex = 0;
            Guna2ComboBox1.TabIndex = 54;
            // 
            // Guna2Separator1
            // 
            Guna2Separator1.Location = new Point(-2, 442);
            Guna2Separator1.Name = "Guna2Separator1";
            Guna2Separator1.Size = new Size(569, 10);
            Guna2Separator1.TabIndex = 57;
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
            LinkLabel3.TabIndex = 56;
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
            Guna2HtmlLabel4.TabIndex = 55;
            Guna2HtmlLabel4.Text = "Don’t have an account?";
            // 
            // Guna2DragControl1
            // 
            Guna2DragControl1.DockIndicatorTransparencyValue = 0.6d;
            Guna2DragControl1.TargetControl = Guna2HtmlLabel1;
            Guna2DragControl1.UseTransparentDrag = true;
            // 
            // Guna2DragControl2
            // 
            Guna2DragControl2.DockIndicatorTransparencyValue = 0.6d;
            Guna2DragControl2.TargetControl = this;
            Guna2DragControl2.UseTransparentDrag = true;
            // 
            // ResetWithPhoneNumber
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Guna2Separator1);
            Controls.Add(LinkLabel3);
            Controls.Add(Guna2HtmlLabel4);
            Controls.Add(Guna2ComboBox1);
            Controls.Add(LinkLabel2);
            Controls.Add(Guna2HtmlLabel2);
            Controls.Add(Guna2TextBox1);
            Controls.Add(Guna2TextBox3);
            Controls.Add(Guna2GradientButton2);
            Controls.Add(Guna2GradientButton1);
            Controls.Add(Guna2TextBox2);
            Controls.Add(Guna2HtmlLabel1);
            Name = "ResetWithPhoneNumber";
            Size = new Size(482, 531);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal LinkLabel LinkLabel2;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel2;
        internal Guna.UI2.WinForms.Guna2TextBox Guna2TextBox1;
        internal Guna.UI2.WinForms.Guna2TextBox Guna2TextBox3;
        internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton2;
        internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton1;
        internal Guna.UI2.WinForms.Guna2TextBox Guna2TextBox2;
        internal Guna.UI2.WinForms.Guna2ComboBox Guna2ComboBox1;
        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator1;
        internal LinkLabel LinkLabel3;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel4;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl2;
    }
}