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
    public partial class FirstTimeUserPage : UserControl
    {
        public FirstTimeUserPage()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var memberInfoForm = new MemberInfoForm();
            familyTree.instance.AddUserControl(memberInfoForm);
        }
    }
}
