using System.Windows.Forms;

namespace Tiktok_Login_Design
{
    public partial class LogInWithEmailOrUsername
    {
        public LogInWithEmailOrUsername()
        {
            InitializeComponent();
        }
        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlSign_Up());
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlUsephoneEmailUsernameLogin());
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlForgotPassword());
        }
    }
}