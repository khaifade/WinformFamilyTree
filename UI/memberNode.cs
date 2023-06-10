using ComponentFactory.Krypton.Toolkit;
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
        }

        private void memberProfilePicture_Click(object sender, EventArgs e)
        {
            using (popupFunction pu = new popupFunction(this.member))
            {
                pu.ShowDialog(this);
            }
        }
    }
}
