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
        public memberNode()
        {
            InitializeComponent();
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
