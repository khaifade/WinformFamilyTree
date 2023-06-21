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
        private int numMem;
        private int x = 0;
        private int y = 0;
        public static HomeScreen Instance { get; private set; }
        public KryptonButton deterMessage;
        public HomeScreen()
        {
            InitializeComponent();
        }
        public void Load()
        {
            deterMessage = deterRealtionshipMessage;
            Instance = this;
            // TODO: Get member's name, member's brithYear & member's profile picture from database of each MemberNode
            // Example for demo:
            
            MemberClass member = new MemberClass();

            numMem = member.numMember();


            if (member.numMember() == 0)
            {
                familyTree.instance.ucFirstTimeUserPage.Show();
            }
            else
            {
                for (int i = 1; i <= member.getMaxMemberID(); i++)
                {
                    if (member.isMemberID(i))
                    {
                        var node = new memberNode(i);
                        MainPanel.Controls.Add(node);
                        node.Location = new Point(x, y);
                        y = y + 100;
                    }
                }

            }
        }
        public void Update()
        {
            MemberClass member = new MemberClass();
            int curNum = member.getMaxMemberID();
            // late
        }
    }
}
