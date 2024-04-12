using System.Windows.Forms;

namespace Tiktok_Login_Design
{
    public partial class UserControlUseQRcodeToLogin
    {
        public UserControlUseQRcodeToLogin()
        {
            InitializeComponent();
        }
        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlSign_Up());
        }
    }
}