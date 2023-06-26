using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformFamilyTree.TreeClasses;

namespace WinformFamilyTree.UI
{
    public partial class memberNode : UserControl
    {
        public KryptonButton profilePicture { get; set; }
        MemberClass member;
        public memberNode()
        {
            InitializeComponent();
            profilePicture = memberProfilePicture;
        }

        public memberNode(int memberID)
        {
            InitializeComponent();
            profilePicture = memberProfilePicture;
            infoBar = infoGroupBox;
            this.member = member.SelectMember(memberID);
            byte[] imageBytes = this.member.RetrieveImage(memberID);
            if (imageBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms, true);
                    Image resizedImage = ResizeImage(image, 100, 100);
                    memberProfilePicture.StateCommon.Back.Image = resizedImage;
                    image.Dispose();
                }

            }
            memberNameLabel.Text = member.FirstName;
            memberBirthYearLabel.Text = member.DateOfBirth.Value.Year.ToString();
        }

        private void memberProfilePicture_Click(object sender, EventArgs e)
        {
            using(popupFunction pu = new popupFunction(member)) 
            {
                pu.ShowDialog(this);
            }
        }
        public string getName()
        {
            return this.Name;
        }
        static public Image ResizeImage(Image originalImage, int maxWidth, int maxHeight)
        {
            int newWidth, newHeight;

            if (originalImage.Width > originalImage.Height)
            {
                newWidth = maxWidth;
                newHeight = (int)((float)originalImage.Height / originalImage.Width * maxWidth);
            }
            else
            {
                newWidth = (int)((float)originalImage.Width / originalImage.Height * maxHeight);
                newHeight = maxHeight;
            }

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }
    }
}
