using System.Windows.Forms;

namespace Tiktok_Login_Design
{
    public partial class UserControlSignUpWithEmailCreatAcount
    {
        public UserControlSignUpWithEmailCreatAcount()
        {
            InitializeComponent();
        }
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlSignUpCreatAcount());
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlLogin());
        }
    }
}