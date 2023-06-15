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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Hãy điền email và mật khẩu");
            }
            else
            {
                AccountClass c = new AccountClass();
                bool isSuccess = c.Check(email, password);
                if (isSuccess)
                {
                    // load to next page
                    MessageBox.Show("Đăng nhập thành công!");

                    // TODO: If this is the first time logged in

                    // load to next page
                    this.Hide();
                    MemberClass member = new MemberClass();
                    if (member.numMember() == 0)
                        familyTree.instance.ucFirstTimeUserPage.Show();
                    else
                    {
                        familyTree.instance.refreshHomeScreen();
                        familyTree.instance.ucHomeScreen.Show();
                    }


                } else
                {
                    MessageBox.Show("Sai email hoặc mật khẩu!");
                    SignInPasswordTextBox.Clear();
                }
            }
        }

        private void SignInEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signInButton_Click((object)sender, e);
            }
        }

        private void backToFirstPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            familyTree.instance.ucFirstPage.Show();
        }
    }
}
