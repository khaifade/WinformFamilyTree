using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            MemberClass member = new MemberClass();
            member = member.SelectMember(memberID);
            this.member = member;
            memberNameLabel.Text = member.FirstName + " " + member.LastName;
            memberBirthYearLabel.Text = member.DateOfBirth.Year.ToString();
            //using (MemoryStream ms = new MemoryStream(member.proFilePicture, 0, member.proFilePicture.Length))
            //{
            //    ms.Write(member.proFilePicture, 0, member.proFilePicture.Length);
            //    Image image = Image.FromStream(ms, true);
            //    memberProfilePicture.BackgroundImage = image;
            //    image.Dispose();
            //}
        }


    }       
}
