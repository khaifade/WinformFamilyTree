using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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
        static public Panel mainPanel;

        public BiographyViewScreen()
        {
            InitializeComponent();
            // TODO: Ẩn hết các object, chỉ hiện một thông báo tìm kiếm thành viên trên thanh tìm kiếm
            MainPanel.Visible = false;
            mainPanel = MainPanel;
        }

        // Màn hình khởi tạo khi truy xuất tiểu sử 1 thành viên từ màn hình chính
        public BiographyViewScreen(MemberClass member)
        {

            InitializeComponent();
            MainPanel.Visible = true;
            mainPanel = MainPanel;
            //MemberClass member = new MemberClass();
            //member = member.SelectMember(memberID);
            this.member = member;
            fullNameText.Text = member.LastName + " " + member.FirstName;
            genderText.Text = member.Gender;
            dateOfBirthText.Text = member.DateOfBirth.Value.Day.ToString() + "/" + member.DateOfBirth.Value.Month.ToString() + "/" + member.DateOfBirth.Value.Year.ToString();
            if(member.DateOfDeath.HasValue)
            { 
                dataOfDeathText.Text = member.DateOfDeath.Value.Day.ToString() + "/" + member.DateOfDeath.Value.Day.ToString() + "/" + member.DateOfDeath.Value.Year.ToString();
            } else
            {
                dataOfDeathText.Text = "Không xác định";
            }
            placeOfOriginText.Text = member.PlaceOfOrigin;
            biographyText.Text = member.Biography;
            //using(MemoryStream ms = new MemoryStream(member.proFilePicture)) 
            //{
            //    Image image = Image.FromStream(ms);
            //    AvatarProfilePicture.BackgroundImage = image;
            //    image.Dispose();
            //}
            // convert AvatarProfilePicture to picture


            byte[] imageBytes = this.member.RetrieveImage(member.ID);
            if (imageBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms, true);
                    Image resizedImage = memberNode.ResizeImage(image, 150, 150);
                    AvatarProfilePicture.StateCommon.Back.Image = resizedImage;
                    image.Dispose();
                }
            }
        }
        private void editInfoButton_Click(object sender, EventArgs e)
        {
            var ucMemberInfoForm = new MemberInfoForm(member);
            familyTree.instance.AddUserControl(ucMemberInfoForm);
        }

      
    }
}
