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
using WinformFamilyTree.UI;

namespace WinformFamilyTree
{
    public partial class HomeScreen : UserControl
    {
        public static HomeScreen Instance { get; private set; }
        public KryptonButton deterMessage;
        public HomeScreen()
        {
            InitializeComponent();
            deterMessage = deterRealtionshipMessage;
            Instance = this;
            // TODO: Get member's name, member's brithYear & member's profile picture from database of each MemberNode
            // Example for demo:
            string mbName = "Richard";
            string mbBirthYear = "1999";
            var node = new memberNode(mbName, mbBirthYear);
            MainPanel.Controls.Add(node);
            node.Location = new Point(0,0);
        }

    }
}
