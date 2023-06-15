using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformFamilyTree.TreeClasses;
using WinformFamilyTree.UI;

namespace WinformFamilyTree
{
    public partial class BiographyViewScreen : UserControl
    {
        // Màn hình khởi tạo khi không có thành viên 
        MemberClass member;
        public BiographyViewScreen()
        {
            InitializeComponent();
            // TODO: Ẩn hết các object, chỉ hiện một thông báo tìm kiếm thành viên trên thanh tìm kiếm
            MainPanel.Visible = false;
        }

        // Màn hình khởi tạo khi truy xuất tiểu sử 1 thành viên từ màn hình chính
        public BiographyViewScreen(MemberClass member)
        {

            InitializeComponent();
            MainPanel.Visible = true;
            //MemberClass member = new MemberClass();
            //member = member.SelectMember(memberID);
            this.member = member;
            fullNameText.Text = member.LastName + " " + member.FirstName;
            genderText.Text = member.Gender;
            dateOfBirthText.Text = member.DateOfBirth.Day.ToString() + "/" + member.DateOfBirth.Month.ToString() + "/" + member.DateOfBirth.Year.ToString();
            if(member.DateOfDeath != null)
            { 
                dataOfDeathText.Text = member.DateOfDeath.Day.ToString() + "/" + member.DateOfDeath.Month.ToString() + "/" + member.DateOfDeath.Year.ToString();
            } else
            {
                dataOfDeathText.Text = "không xác định";
            }
            placeOfOriginText.Text = member.PlaceOfOrigin;
            biographyText.Text = member.Biography;
            // convert AvatarProfilePicture to picture
            //AvatarProfilePicture = member.proFilePicture;
        }

        private void editInfoButton_Click(object sender, EventArgs e)
        {
            var ucMemberInfoForm = new MemberInfoForm(member);
            familyTree.instance.AddUserControl(ucMemberInfoForm);
        }
    }
}
