using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformFamilyTree
{
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
            //---------panel------------
            Panelavatar1.Paint += Panelavatar1_Paint;
            Panelavatar2.Paint += Panelavatar2_Paint;
            Panelavatar3.Paint += Panelavatar3_Paint;
            Panelavatar4.Paint += Panelavatar4_Paint;
            Panelavatar5.Paint += Panelavatar5_Paint;
            //-----tableLayoutPanel-----
            Panelmember1.Paint += Panelmember1_Paint;
            Panelmember2.Paint += Panelmember2_Paint;
            Panelmember3.Paint += Panelmember3_Paint;
            Panelmember4.Paint += Panelmember4_Paint;
            Panelmember5.Paint += Panelmember5_Paint;
            Paneltools.Paint += Paneltools_Paint;
            //--------picturebox---------
            avatar1.Paint += avatar1_Paint;
            avatar2.Paint += avatar2_Paint;
            avatar3.Paint += avatar3_Paint;
            avatar4.Paint += avatar4_Paint;
            avatar5.Paint += avatar5_Paint;    
            //----------button-----------
            Buttonon.Paint += Buttonon_Paint;
            buttonoff.Paint += Buttonoff_Paint;
        }

       



        //-----------------code chỉnh sửa--------------

        private void botronpanel(Panel panel)
        {
            int radius = 30; // nơi chỉnh độ bo tròn
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = panel.ClientRectangle;
            path.AddLine(rect.X + radius, rect.Y, rect.X + rect.Width - radius, rect.Y);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height - radius);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddLine(rect.X + rect.Width - radius, rect.Y + rect.Height, rect.X + radius, rect.Y + rect.Height);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.AddLine(rect.X, rect.Y + rect.Height - radius, rect.X, rect.Y + radius);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void lamtronpanel(Panel panel)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(panel.ClientRectangle);
            panel.Region = new Region(path);
        }

        private void lamtronanh(PictureBox picturebox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(picturebox.ClientRectangle);
            picturebox.Region = new Region(path);
        }

        private void lamtronnut(Button button)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(button.ClientRectangle);
            button.Region = new Region(path);
        }

        //------------liên kết mối quan hệ-----------

        private void vochong(Panel panel1, Panel panel2)
        {
            // Get the graphics object of the parent control
            Graphics g = panel1.Parent.CreateGraphics();

            // Get the coordinates of the two panels
            Point p1 = panel1.Location;
            Point p2 = panel2.Location;

            // Calculate the center points of the two panels
            Point c1 = new Point(p1.X + panel1.Width / 2, p1.Y + panel1.Height / 2);
            Point c2 = new Point(p2.X + panel2.Width / 2, p2.Y + panel2.Height / 2);

            // Set the thickness of the line
            Pen pen = new Pen(Color.LightBlue, 5);

            // Draw the line
            g.DrawLine(pen, c1, c2);
        }
        private void concai(Panel panel1, Panel panel2, Panel panel3)
        {
            // Get the graphics object of the parent control
            Graphics g = panel1.Parent.CreateGraphics();

            // Get the coordinates of the two panels
            Point p1 = panel1.Location;
            Point p2 = panel2.Location;
            Point p3 = panel3.Location;

            // Calculate the center points of the two panels
            Point c1 = new Point(p1.X + panel1.Width / 2, p1.Y + panel1.Height / 2);
            Point c2 = new Point(p2.X + panel2.Width / 2, p2.Y + panel2.Height / 2);
            Point c3 = new Point(p3.X + panel3.Width / 2, p3.Y + panel3.Height / 2);
            Point c4 = new Point((c1.X + c2.X) / 2, (c1.Y + c2.Y) / 2);

            // Calculate the bend point
            int bendX = Math.Min(c3.X, c4.X) + Math.Abs(c3.X - c4.X) / 2;
            int bendY = Math.Min(c3.Y, c4.Y) + Math.Abs(c3.Y - c4.Y) / 2;

            // Set the thickness of the line
            Pen pen = new Pen(Color.LightBlue, 5);

            // Draw the line
            g.DrawLine(pen, new Point(c3.X, bendY), c3);
            g.DrawLine(pen, new Point(c3.X, bendY), new Point(c4.X, bendY));
            g.DrawLine(pen, new Point(c4.X, bendY), c4);
        }


        //-----------------sửa panel-----------------

        private void Panelavatar1_Paint(object sender, PaintEventArgs e)
        {
            lamtronpanel(Panelavatar1);
        }
        private void Panelavatar2_Paint(object sender, PaintEventArgs e)
        {
            lamtronpanel(Panelavatar2);
        }
        private void Panelavatar3_Paint(object sender, PaintEventArgs e)
        {
            lamtronpanel(Panelavatar3);
        }
        private void Panelavatar4_Paint(object sender, PaintEventArgs e)
        {
            lamtronpanel(Panelavatar4);        
        }
        private void Panelavatar5_Paint(object sender, PaintEventArgs e)
        {
            lamtronpanel(Panelavatar5);
        }


        //--------------------sửa tableLayoutPanel-----------------

        private void Panelmember1_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Panelmember1);
            vochong(Panelmember1, Panelmember2);
        }
        private void Panelmember2_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Panelmember2);
        }
        private void Panelmember3_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Panelmember3);
            concai(Panelmember1, Panelmember2, Panelmember3);
        }
        private void Panelmember4_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Panelmember4);
            concai(Panelmember1, Panelmember2, Panelmember4);
        }
        private void Panelmember5_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Panelmember5);
            concai(Panelmember1, Panelmember2, Panelmember5);
        }

        private void Paneltools_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Paneltools);
        }

        //-----------------sửa picturebox---------------------
        private void avatar1_Paint (object sender, PaintEventArgs e)
        {
            lamtronanh(avatar1);
        }
        private void avatar2_Paint (object sender, PaintEventArgs e)
        {
            lamtronanh(avatar2);
        }
        private void avatar3_Paint(object sender, PaintEventArgs e)
        {
            lamtronanh(avatar3);
        }
        private void avatar4_Paint(object sender, PaintEventArgs e)
        {
            lamtronanh(avatar4);
        }
        private void avatar5_Paint(object sender, PaintEventArgs e)
        {
            lamtronanh(avatar5);
        }

        //----------------------sửa nút------------------------

        private void Buttonon_Paint(object sender, EventArgs e)
        {
            lamtronnut(Buttonon);
        }
        private void Buttonoff_Paint(object sender, PaintEventArgs e)
        {
            lamtronnut(buttonoff);
        }

        //---------------------click----------------------------
        private void avatar1_Click(object sender, EventArgs e)
        {
            Buttonon.Visible = true;
        }

        private void Buttonon_Click(object sender, EventArgs e)
        {
            buttonoff.Visible = true;
            Paneltools.Visible = true;
        }

        private void buttonoff_Click(object sender, EventArgs e)
        {
            buttonoff.Visible = false;
            Paneltools.Visible = false;
            Buttonon.Visible = false;
        }

        
    }
}
