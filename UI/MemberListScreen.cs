using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WinformFamilyTree.TreeClasses;

namespace WinformFamilyTree
{
    public partial class MemberListScreen : UserControl
    {
        public static MemberListScreen instance;
        public KryptonDataGridView dtg;
        public MemberListScreen()
        {
            InitializeComponent();
            MemberClass nb = new MemberClass();
            instance = this;
            dtg = DataGirdView;
            dtg.AllowUserToResizeColumns = false;
            dtg.DataSource = nb.Select();
            
        }
        public void Update()
        {
            InitializeComponent();
            MemberClass nb = new MemberClass();
            dtg.DataSource = nb.Select();
        }
    }
}
