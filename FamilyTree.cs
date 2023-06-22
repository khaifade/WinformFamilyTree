using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformFamilyTree.TreeClasses;
using ComponentFactory.Krypton.Toolkit;
using WinformFamilyTree.UI;
using WinformFamilyTree.TreeClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinformFamilyTree.Properties;

namespace WinformFamilyTree
{
    
    public partial class familyTree : KryptonForm
    {
        // These variable used to communicate together.
        public static familyTree instance { get; private set; }
        public UserControl ucFirstPage = new FirstPage();
        public UserControl ucSignUpPage = new SignUpPage();
        public UserControl ucSignInPage = new SignInPage();
        public UserControl ucFirstTimeUserPage = new FirstTimeUserPage();
        public UserControl ucHomeScreen = new HomeScreen();
        public KryptonGroupPanel workspace;
        public FlowLayoutPanel navPanel;

        // Declaring a variable to submit a sign up form to database
        public void formSubmit_SignUp(object sender, EventArgs e)
        {
            AccountClass c = new AccountClass();
            c.FirstName = SignUpPage.instance.firstNameTextBox.Text;
            c.LastName = SignUpPage.instance.lastNameTextBox.Text;
            c.Email = SignUpPage.instance.emailTextBox.Text;
            c.Password = SignUpPage.instance.passwordTextBox.Text;
            bool success = c.Insert(c);
            if (success)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!");
            } else
            {
                MessageBox.Show("Vui lòng thử lại!");
            }
            DataTable dt = c.Select();
            MemberListScreen.instance.dtg.DataSource = dt;

        }
        public familyTree()
        {
            InitializeComponent();
            instance = this;
            instance.AddUserControl(ucFirstPage);
            instance.AddUserControl(ucSignUpPage);
            instance.AddUserControl(ucSignInPage);
            instance.AddUserControl(ucFirstTimeUserPage);
            workspace = workspaceGroupBox.Panel;
            navPanel = wrappedNavButtonLayout;
            homeScreen.Load();
            memberListScreen.Load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inital View is Home Screen 
            containerLayout.BackColor = Color.FromArgb(0, 0, 0, 0);
            ucFirstPage.Show();
            ucSignInPage.Hide();
            ucSignUpPage.Hide();
            ucFirstTimeUserPage.Hide();

            homeScreen.Hide();
            biographyScreen.Hide();
            memberListScreen.Hide();
            sharedScreen.Hide();
            homeScreen.BringToFront();
            
        }
        public void AddUserControl(UserControl userControl)
        {
            this.MainPanel.Controls.Add(userControl);
            userControl.Visible = true;
            userControl.BringToFront();

        }

        private void workspaceCaption_Change(object sender, EventArgs e)
        {
            KryptonButton navButton = (KryptonButton)sender;
            workspaceGroupBox.Values.Heading = navButton.Text;
            
        }

        private void homeScreenButton_Click(object sender, EventArgs e)
        {
            searchGroupBox.Show();
            SearchComboBox.Visible = true;
            homeScreen.Show();
            biographyScreen.Hide();
            memberListScreen.Hide();
            sharedScreen.Hide();
            homeScreen.BringToFront();

            //homeScreen.Update();
            // change caption of the workspace
            workspaceCaption_Change(homeScreenButton, e);
        }

        private void viewBiographyButton_Click(object sender, EventArgs e)
        {
            searchGroupBox.Hide();
            homeScreen.Hide();
            biographyScreen.Show();
            memberListScreen.Hide();
            sharedScreen.Hide();
            // Chỉ hiển thị màn hình trống khi chưa có thành viên
            //biographyScreen.BringToFront();

            // change caption of the workspace
            workspaceCaption_Change(viewBiographyButton, e);
        }

        private void memberListButton_Click(object sender, EventArgs e)
        {
            // Only show screen of member list and hide other screen
            homeScreen.Hide();
            SearchComboBox.Visible = false;
            biographyScreen.Hide();
            memberListScreen.Show();
            memberListScreen.Update();
            sharedScreen.Hide();
            memberListScreen.BringToFront();
            searchGroupBox.Show();
            // change caption of the workspace
            workspaceCaption_Change(memberListButton, e);

        }

        private void shareButton_Click(object sender, EventArgs e)
        {
            homeScreen.Hide();
            biographyScreen.Hide();
            memberListScreen.Hide();
            sharedScreen.Show();
            sharedScreen.BringToFront();
            searchGroupBox.Hide();
            // change caption of the workspace
            workspaceCaption_Change(sharedButton, e);
        }

        private void searchBox_DoubleClick(object sender, EventArgs e)
        {
            
            searchBox.Text = "";
            searchBox.ForeColor = System.Drawing.SystemColors.ControlText;
    
        }

        private void True(object sender, ScrollEventArgs e)
        {

        }
        string placeHolder = "Nhập tên thành viên";
        private void searchBox_Click(object sender, EventArgs e)
        {
            
            if (searchBox.Text == placeHolder)
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            } else if (searchBox.Text == "") {
                searchBox.Text = placeHolder;
                searchBox.ForeColor = Color.Silver;
            }
        }

        private void searchBox_LostFocus(object sender, EventArgs e)
        {
            if (searchBox.Text == "") { 
                searchBox.Text = placeHolder;
                searchBox.ForeColor = Color.Silver;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeScreenButton_TabStopChanged(object sender, EventArgs e)
        {

        }
        Color mainColor = Color.FromArgb(137, 170, 255);


        private void homeScreenButton_onClick(object sender, EventArgs e)
        {
            SearchComboBox.Visible = true;
            homeScreenButton.BackColor = Color.White;
            homeScreenButton.ForeColor = mainColor;
            homeScreenButton.Font = new Font(homeScreenButton.Font, FontStyle.Bold);

        }

        private void sharedScreen_Load(object sender, EventArgs e)
        {

        }
        public void refreshBiographyScreen(MemberClass member)
        {
            viewBiographyButton.PerformClick();
            BiographyViewScreen bio = new BiographyViewScreen(member);
            this.workspace.Controls.Add(bio);
            bio.Show();
            bio.BringToFront();

        }
        public void refreshHomeScreen()
        {
            HomeScreen.Instance.Update();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            memberListScreen.findMembers(searchBox.Text);
        }

        private void SearchComboBox_TextChanged(object sender, EventArgs e)
        {
            
            KryptonComboBox cb = (KryptonComboBox)sender;
            MemberClass member = new MemberClass();
            string curName = cb.Text;
            instance.ActiveControl = null;
            cb.DataSource = member.FindFromName_ID(SearchComboBox.Text);
            cb.DisplayMember = "MemberName";
            cb.ValueMember = "MemberID";
            cb.TextChanged -= SearchComboBox_TextChanged;
            cb.Text = curName;
            cb.Focus();
            cb.Select(cb.Text.Length, 0);
            //cb.DroppedDown = true;
            cb.TextChanged += SearchComboBox_TextChanged;
        }

        private void SearchComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void biographyScreen_Load(object sender, EventArgs e)
        {

        }

        private void familyTree_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
