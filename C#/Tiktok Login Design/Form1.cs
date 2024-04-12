using System;

namespace Tiktok_Login_Design
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Guna2Panel1.Controls.Clear();
            Guna2Panel1.Controls.Add(new UserControlLogin());
        }

        private void Guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}