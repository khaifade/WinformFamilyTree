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
    public partial class DeterRelationshipDialog : Form
    {
        public DeterRelationshipDialog()
        {
            InitializeComponent();
            memberNode2.profilePicture.Enabled = false;
            memberNode1.profilePicture.Enabled = false;
        }
    }
}
