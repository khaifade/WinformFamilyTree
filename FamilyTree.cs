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
            homeScreenButton.PerformClick();
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
            if(memberListScreen.Visible == true)
                memberListScreen.findMembers(searchBox.Text);
            if(homeScreen.Visible == true)
            {
                MemberClass member = new MemberClass();
                if (string.IsNullOrEmpty(searchBox.Text))
                {
                    homeScreen.UnfocusNode(); 
                }
                SearchComboBox.DataSource = member.FindFromName_ID(searchBox.Text);
                SearchComboBox.DisplayMember = "MemberName";
                SearchComboBox.ValueMember = "MemberID";
                searchBox.Focus();
            }
        }

        private void familyTree_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void SearchComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            KryptonComboBox cb = (KryptonComboBox)sender;
            homeScreen.FindNode(cb.SelectedValue.ToString());
            searchBox.Text = cb.Text;
        }

    }
}
