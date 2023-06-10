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
namespace WinformFamilyTree
{
    public partial class MemberListScreen : UserControl
    {
        public static MemberListScreen instance;
        public KryptonDataGridView dtg;
        public MemberListScreen()
        {
            InitializeComponent();
            instance = this;
            dtg = DataGirdView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
