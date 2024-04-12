using System;
using System.Windows.Forms;

namespace Tiktok_Login_Design
{
    public partial class UserControlSign_Up
    {
        public UserControlSign_Up()
        {
            InitializeComponent();
        }
        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlLogin());
        }

        private void Guna2GradientButton2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlSignUpCreatAcount());
        }
    }
}