using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformFamilyTree.TreeClasses;

namespace WinformFamilyTree
{
    public partial class SignInPage : UserControl
    {
        public static SignInPage instance;
        
        public SignInPage()
        {
            InitializeComponent();

            instance = this;
        }


        private void signInButton_Click(object sender, EventArgs e)
        {
            string email = SignInEmailTextBox.Text;
            string password = SignInPasswordTextBox.Text;

            AccountClass c = new AccountClass();
            bool isSuccess = c.Check(email, password);
            if (isSuccess)
            {
                // load to next page
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                familyTree.instance.pLoginLayout.Hide();
                
            } else
            {
                MessageBox.Show("Sai email hoặc mật khẩu!");
                SignInEmailTextBox.Clear();
                SignInPasswordTextBox.Clear();
            }
        }

        private void SignInEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
