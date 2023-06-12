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
using WinformFamilyTree.TreeClasses;

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
            int x = 0;
            int y = 0;
            MemberClass member = new MemberClass();
            for(int i = 1; i<= member.numMember(); i++)
            {
                var node = new memberNode(i);
                MainPanel.Controls.Add(node);
                node.Location = new Point(x,y);
                y = y + 100;
            }
            
        }

    }
}
