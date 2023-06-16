using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WinformFamilyTree.TreeClasses;

namespace WinformFamilyTree.UI
{
    public partial class popupFunction : KryptonForm
    {
        MemberClass member;

        public popupFunction()
        {
            InitializeComponent();
        }
        public popupFunction(MemberClass member)
        {
            this.member = member;
            InitializeComponent();
        }

        private void addMember_Click(object sender, EventArgs e)
        {
            this.Close();
            string type = "";
            if (sender == addParentButton)
            {
                type = "parent";
            }
            if (sender == addSpouseButton)
            {
                type = "spouse";
            }
            if (sender == addChildButton)
            {
                type = "child";
            }
            var ucMemberInfoForm = new MemberInfoForm(type,member.ID);
            familyTree.instance.AddUserControl(ucMemberInfoForm);
            
            
        }

        private void viewBiographyButton_Click(object sender, EventArgs e)
        {
            this.Close();

            // TODO: khởi tạo lại biographyViewScreen với memberID
            // Then: Đi đến màn hình Xem tiểu sử
            // Example:
            familyTree.instance.refreshBiographyScreen(this.member);
        }

        async private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            this.Close();
            await Task.Delay(100);
            var confirmDeletingDialog = new ConfirmDeletingDialog(member);
            confirmDeletingDialog.ShowDialog();

        }

        async private void deterRelationshipButton_Click(object sender, EventArgs e)
        {
            this.Close();
            await Task.Delay(100);
            HomeScreen.Instance.deterMessage.Visible = true;
            HomeScreen.Instance.deterMessage.BringToFront();
            // TODO: choose another member to determine relationship

            // Then show Dialog between them.
            var relationship = new DeterRelationshipDialog();
            await Task.Delay(1000);
            HomeScreen.Instance.deterMessage.Visible = false;
            relationship.ShowDialog();

        }
    }
}
