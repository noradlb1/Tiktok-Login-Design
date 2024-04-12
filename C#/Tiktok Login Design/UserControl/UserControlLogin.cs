using System;
using System.Windows.Forms;

namespace Tiktok_Login_Design
{
    public partial class UserControlLogin
    {
        public UserControlLogin()
        {
            InitializeComponent();
        }
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlSign_Up());
        }

        private void Guna2GradientButton1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlUseQRcodeToLogin());
        }

        private void Guna2GradientButton2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlUsephoneEmailUsernameLogin());
        }
    }
}