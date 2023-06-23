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
using System.Xml.Linq;
using System.Net;
using WinformFamilyTree.Properties;

namespace WinformFamilyTree
{
    public partial class HomeScreen : UserControl
    {
        private memberNode curFocusNode = null;
        private int numMem;
        private List<FlowLayoutPanel> Gen;
        public static HomeScreen Instance { get; private set; }
        public KryptonButton deterMessage;
        public Panel mainPanel;

        // These point is used for drawing relationship
        private List<Line> lines = new List<Line>();
        public HomeScreen()
        {
            InitializeComponent();

        }
        public void Load()
        {
            MainPanel.Controls.Clear();
            deterMessage = deterRealtionshipMessage;
            Instance = this;
            mainPanel = MainPanel;
            mainPanel.AutoScroll = true;

            MemberClass member = new MemberClass();

            numMem = member.numMember();

            // List of gen is used to manage each flow panel of each generation.
            Gen = new List<FlowLayoutPanel>();
            // `x_layout` is used to set location of a new gen horizontally.
            int x_layout = 0;

            if (member.numMember() == 0)
            {
                familyTree.instance.ucFirstTimeUserPage.Show();
                return;
            }
            // Get the root member with the min id.
            int rootMemID = member.getMinMemberID();
            var node0 = new memberNode(rootMemID);
            node0.Name = "node" + rootMemID.ToString();

            // Lấy toạ độ của nút gốc

            Point parentPoint = new Point(1, 1);


            //

            FlowLayoutPanel gen0 = new FlowLayoutPanel();




            int[] MemIDToGen = Enumerable.Repeat(0, member.getMaxMemberID() + 1).ToArray();

            MemIDToGen[rootMemID] = 0;

            gen0.AutoSize = true;
            gen0.FlowDirection = FlowDirection.TopDown;
            gen0.Location = new Point(x_layout, gen0.Location.Y);
            //gen0.BackColor = Color.Red;
            x_layout += 250;


            Gen.Add(gen0);

            Gen[0].Controls.Add(node0);
            int SpouseID = member.getSpouseID(rootMemID);
            // Có vợ/ chồng
            if (SpouseID >= 0)
            {
                int PartnerID = member.getMemberPartner(SpouseID, rootMemID);
                memberNode SpouseNode = new memberNode(PartnerID);
                SpouseNode.infoBar.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 85);
                SpouseNode.profilePicture.StateCommon.Border.Color1 = Color.FromArgb(32, 191, 85);
                SpouseNode.Name = "node" + PartnerID.ToString();
                Gen[0].Controls.Add(SpouseNode);
            }

            DFS(ref Gen, rootMemID, x_layout, 0, member.getSpouseID(member.getMinMemberID()), parentPoint);
            // Add the list of panel to screen
            this.mainPanel.Refresh();
            this.mainPanel.Controls.AddRange(Gen.ToArray());

        }
        private int DFS(ref List<FlowLayoutPanel> Gen, int nodeID, int x_layout, int cur_y, int SpouseID, Point parentPoint)
        {
            MemberClass member = new MemberClass();
            FlowLayoutPanel childFlowPannel = new FlowLayoutPanel();
            childFlowPannel.AutoSize = true;
            childFlowPannel.FlowDirection = FlowDirection.TopDown;
            childFlowPannel.Location = new Point(x_layout, cur_y);
            int[] ChildList = member.getAllChildID(SpouseID);
            int curIdx = -1;
            int curNodeY = cur_y - 150;
            foreach (int childID in ChildList)
            {
                memberNode ChildNode = new memberNode(childID);
                // Lấy toạ độ con 

                Point childPoint = new Point(300, 200);



                //
                this.lines.Add(new Line(
                    childPoint,
                    parentPoint));
                ChildNode.Name = "node" + childID.ToString();
                curIdx++;
                curNodeY += 150;
                childFlowPannel.Controls.Add(ChildNode);
                int ChildSpouseID = member.getSpouseID(childID);
                if (ChildSpouseID >= 0)
                {
                    int offset = DFS(ref Gen, childID, x_layout + 250, curNodeY, ChildSpouseID, childPoint) - curNodeY - 150;
                    int ChildPartnerID = member.getMemberPartner(ChildSpouseID, childID);
                    if (ChildPartnerID >= 0)
                    {
                        memberNode SpouseNode = new memberNode(ChildPartnerID);
                        SpouseNode.infoBar.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 85);
                        SpouseNode.profilePicture.StateCommon.Border.Color1 = Color.FromArgb(32, 191, 85);
                        SpouseNode.Name = "node" + ChildPartnerID.ToString();
                        childFlowPannel.Controls.Add(SpouseNode);
                        curIdx++;
                        curNodeY += 150;
                    }
                    if (offset > 0)
                    {
                        childFlowPannel.Controls[curIdx].Margin = new Padding(0, 0, 0, offset);
                        curNodeY += offset;
                    }

                }
            }

            Gen.Add(childFlowPannel);
            return curNodeY;
        }
        public void Update()
        {
            Gen.Clear();
            Load();
        }
        public void FindNode(string NodeID)
        {
            UnfocusNode();
            foreach (FlowLayoutPanel curGen in Gen)
            {
                foreach (memberNode curNode in curGen.Controls)
                {
                    if (curNode.Name == "node" + NodeID)
                    {
                        curNode.BackColor = Color.Red;
                        curNode.Focus();
                        curFocusNode = curNode;
                        break;
                    }
                }
            }
        }
        public void UnfocusNode()
        {
            if (curFocusNode != null)
                curFocusNode.BackColor = Color.Empty;
        }
        protected void DrawRel(Point p1, Point p2)
        {
            Graphics g;
            g = this.CreateGraphics();

            Pen myPen = new Pen(Color.Green);
            myPen.Width = 30;
            g.DrawLine(myPen, p1.X, p1.Y, p2.X, p2.Y);
        }
        private class Line
        {
            public Point StartPoint { get; }
            public Point EndPoint { get; }

            public Line(Point startPoint, Point endPoint)
            {
                StartPoint = startPoint;
                EndPoint = endPoint;
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Draw the lines using the stored points
            using (Pen pen = new Pen(Color.Green, 5))
            {
                foreach (Line line in lines)
                {
                    e.Graphics.DrawLine(pen, line.StartPoint, line.EndPoint);
                }
            }
        }
        private void MainPanel_Scroll(object sender, ScrollEventArgs e)
        {
            // Redraw the lines when the panel is scrolled
            //this.mainPanel.Invalidate();
        }
    }
}
