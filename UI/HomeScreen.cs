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

namespace WinformFamilyTree
{
    public partial class HomeScreen : UserControl
    {
        private int numMem;
        private int x = 0;
        private int y = 0;
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
            // TODO: Get member's name, member's brithYear & member's profile picture from database of each MemberNode
            // Example for demo:

            MemberClass member = new MemberClass();

            numMem = member.numMember();


            //if (member.numMember() == 0)
            //{
            //    familyTree.instance.ucFirstTimeUserPage.Show();
            //}
            //else
            //{
            //    for (int i = 1; i <= member.getMaxMemberID(); i++)
            //    {
            //        if (member.isMemberID(i))
            //        {
            //            var node = new memberNode(i);
            //            MainPanel.Controls.Add(node);
            //            node.Location = new Point(x, y);
            //            y = y + 100;
            //        }
            //    }

            //}

            // List of gen is used to manage each flow panel of each generation.
            List<FlowLayoutPanel> Gen = new List<FlowLayoutPanel>();

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
            if (SpouseID >= 0)
            {
                int PartnerID = member.getMemberPartner(SpouseID, rootMemID);
                memberNode SpouseNode = new memberNode(PartnerID);
                SpouseNode.infoBar.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 85);
                SpouseNode.profilePicture.StateCommon.Border.Color1 = Color.FromArgb(32, 191, 85);
                SpouseNode.Name = "node" + PartnerID.ToString();
                Gen[0].Controls.Add(SpouseNode);
            }

            /*// list of member which was explored
            // explored = true means that all relationship of this member was iterated and added to correct gen.
            bool[] exploredMem = Enumerable.Repeat(false, member.getMaxMemberID() + 1).ToArray();

            // `i` is represented for each memberID
            for (int i = member.getMinMemberID(); i <= member.getMaxMemberID(); i++)
            {
                // check if member has explored or not
                // if not: add its spouse and children
                if (exploredMem[i] == false && member.isMemberID(i))
                {
                    exploredMem[i] = true;

                    int spouseID = member.getSpouseID(i);
                    int partnerID = member.getMemberPartner(spouseID, i);
                    int[] childrenID = member.getAllChildID(spouseID);
                    int numMemOfNextGen = childrenID.Length;
                    foreach (var item in childrenID)
                    {
                        if (member.getSpouseID(item) > 0)
                        {
                            numMemOfNextGen++;
                        }
                    }

                    // if current id had a spouse, add it to gen panel
                    // if the parent ID was explored, skip this to avoid adding twice children node.
                    if (spouseID != -1 && exploredMem[partnerID] == false)
                    {
                        memberNode spouse_node = new memberNode(partnerID);
                        spouse_node.infoBar.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 85);
                        spouse_node.profilePicture.StateCommon.Border.Color1 = Color.FromArgb(32, 191, 85);

                        var partner = Gen[MemIDToGen[i]].Controls.Find("node" + i.ToString(), true)[0];
                        // expand space if this spouse has more than 3 sons.
                        if (numMemOfNextGen >= 3)
                        {
                            spouse_node.Margin = new Padding(0, 0, 0, 150 * (numMemOfNextGen - 2));

                            // increase index of partner by the numMemOfNextGen - 2 for adding space child at any random parent.

                        }
                        Gen[MemIDToGen[i]].Controls.Add(spouse_node);
                        spouse_node.Name = "node" + partnerID.ToString();

                        // set order in gen.
                        int partnerIndex = Gen[MemIDToGen[i]].Controls.GetChildIndex(partner);
                        Gen[MemIDToGen[i]].Controls.SetChildIndex(spouse_node, partnerIndex + 1);

                        // update gen of spouse member
                        MemIDToGen[spouseID] = MemIDToGen[i];
                    }
                    if (childrenID.Length > 0 && exploredMem[partnerID] == false)
                    {
                        // check if next gen is null or not to avoid adding redundant gens when we added a lot of children.
                        if (MemIDToGen[i] + 1 >= Gen.Count)
                        {
                            FlowLayoutPanel new_gen = new FlowLayoutPanel();
                            new_gen.AutoSize = true;
                            new_gen.FlowDirection = FlowDirection.TopDown;
                            new_gen.Location = new Point(x_layout, new_gen.Location.Y);
                            //new_gen.BackColor = Color.Yellow;
                            x_layout += 250;
                            Gen.Add(new_gen);
                        }

                        for (int j = 0; j < childrenID.Length; j++)
                        {

                            // New node
                            int childID = childrenID[j];
                            memberNode child_node = new memberNode(childID);
                            child_node.Name = "node" + childID.ToString();

                            // update gen of each child member
                            MemIDToGen[childID] = MemIDToGen[i] + 1;

                            Gen[MemIDToGen[childID]].Controls.Add(child_node);

                            // Add relationship line
                            var parentUc = Gen[MemIDToGen[i]].Controls.Find("node" + i.ToString(), true)[0];
                            this.lines.Add(new Line(
                                new Point(
                                    Gen[MemIDToGen[i]].Left + parentUc.Left + parentUc.Width / 2,
                                    Gen[MemIDToGen[i]].Top + parentUc.Top + parentUc.Height / 2),

                                new Point(
                                    Gen[MemIDToGen[childID]].Left + child_node.Left + child_node.Width / 2,
                                    Gen[MemIDToGen[childID]].Top + child_node.Top + child_node.Height / 2)));

                            // Refresh the parent panel to trigger the Paint event and draw the lines
                            this.mainPanel.Refresh();

                            // adding space if adding child at any random parent.
                            
                            int numMemOfCurrentGen = Gen[MemIDToGen[childID]].Controls.Count;
                            int numMemOfPreviousGen = Gen[MemIDToGen[i]].Controls.Count;
                            var parentUc = Gen[MemIDToGen[i]].Controls.Find("node" + i.ToString(), true)[0];
                            int parentIndex = Gen[MemIDToGen[i]].Controls.GetChildIndex(parentUc);


                            // just adding top padding for the first child
                            if (j == 0)
                            {
                                //int top_margin = (parentIndex - numMemOfCurrentGen) * 150;
                                //int top_margin = y_layout -  - (numMemOfCurrentGen) * 150;
                                Gen[MemIDToGen[childID]].SuspendLayout();
                                int parentLocationX = parentUc.Location.X;
                                int childLocationX = child_node.Location.X;
                                int lastChildIndex = 0;
                                if (Gen[MemIDToGen[childID]].Controls.Count >= 1)
                                {
                                    lastChildIndex = Gen[MemIDToGen[childID]].Controls.GetChildIndex(Gen[MemIDToGen[childID]].Controls[Gen[MemIDToGen[childID]].Controls.Count - 1]);

                                }
                                if (parentLocationX > 0 )
                                {
                                    int Top = Math.Abs(parentIndex - lastChildIndex) * 150;
                                    child_node.Margin = new Padding(0, Top, 0, 0);
                                }
                                Gen[MemIDToGen[childID]].ResumeLayout();
                            }
                            

                        }
                    }
                }
            }*/
            DFS(ref Gen, rootMemID, x_layout, 0 , member.getSpouseID(member.getMinMemberID()));
            // Add the list of panel to screen
            this.mainPanel.Controls.AddRange(Gen.ToArray());

        }
        private int DFS(ref List<FlowLayoutPanel> Gen, int nodeID,int x_layout, int cur_y, int SpouseID)
        {
            MemberClass member = new MemberClass();
            FlowLayoutPanel childFlowPannel = new FlowLayoutPanel();
            childFlowPannel.AutoSize = true;
            childFlowPannel.FlowDirection = FlowDirection.TopDown;
            childFlowPannel.Location = new Point(x_layout, cur_y);
            int[] ChildList = member.getAllChildID(SpouseID);
            int curIdx = -1;
            int curNodeY = cur_y-150;
            foreach (int childID in ChildList)
            {
                memberNode ChildNode = new memberNode(childID);
                ChildNode.Name = "node" + childID.ToString();
                curIdx++;
                curNodeY += 150;
                childFlowPannel.Controls.Add(ChildNode);
                int ChildSpouseID = member.getSpouseID(childID);
                if (ChildSpouseID >= 0)
                {
                    int ChildPartnerID = member.getMemberPartner(ChildSpouseID, childID);
                    memberNode SpouseNode = new memberNode(ChildPartnerID);
                    SpouseNode.infoBar.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 85);
                    SpouseNode.profilePicture.StateCommon.Border.Color1 = Color.FromArgb(32, 191, 85);
                    SpouseNode.Name = "node" + ChildPartnerID.ToString();
                    childFlowPannel.Controls.Add(SpouseNode);
                    curIdx++;
                    int offset = DFS(ref Gen, childID, x_layout + 250, curNodeY, ChildSpouseID) - curNodeY - 150;
                    if(offset > 0) 
                    {
                        childFlowPannel.Controls[curIdx].Margin = new Padding(0, 0, 0, offset);
                        curNodeY += offset;
                    }
                    curNodeY += 150;
                }
            }
            Gen.Add(childFlowPannel);
            return curNodeY;
        }
        public void Update()
        {
            //MemberClass member = new MemberClass();
            //int curNum = member.getMaxMemberID();
            Load();
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
            this.mainPanel.Invalidate();
        }
    }
}
