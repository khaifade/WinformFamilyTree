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
        }
        public void Load()
        {
            MemberClass mb = new MemberClass();
            instance = this;
            dtg = DataGirdView;
            dtg.AllowUserToResizeColumns = false;
            dtg.DataSource = mb.Select();

        }
        public void Update()
        {
            InitializeComponent();
            MemberClass mb = new MemberClass();
            dtg.DataSource = mb.Select();
        }
        public void findMembers(string queryStr)
        {
            MemberClass mb = new MemberClass();
            if (string.IsNullOrEmpty(queryStr))
                dtg.DataSource = mb.Select();
            else
                dtg.DataSource = mb.FindFromName(queryStr);
        }
    }
}
