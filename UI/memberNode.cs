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

namespace WinformFamilyTree.UI
{
    public partial class memberNode : UserControl
    {
        public KryptonButton profilePicture { get; set; }
        string _name;
        string _brithYear;
        public memberNode()
        {
            InitializeComponent();
            profilePicture = memberProfilePicture;
        }

        public memberNode(string name, string birthYear)
        {
            InitializeComponent();
            profilePicture = memberProfilePicture;
            _name = name;
            _brithYear = birthYear;
            memberNameLabel.Text = name;
            memberBirthYearLabel.Text = birthYear;
        }

        private void memberProfilePicture_Click(object sender, EventArgs e)
        {
            using (popupFunction pu = new popupFunction())
            {
                pu.ShowDialog(this);
            }
        }
    }
}
