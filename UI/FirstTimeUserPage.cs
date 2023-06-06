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

namespace WinformFamilyTree.UI
{
    public partial class FirstTimeUserPage : UserControl
    {
        public FirstTimeUserPage()
        {
            InitializeComponent();
        }
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
        private void botronanh(PictureBox picturebox)
        {
            int radius = 30; // nơi chỉnh độ bo tròn
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = picturebox.ClientRectangle;
            path.AddLine(rect.X + radius, rect.Y, rect.X + rect.Width - radius, rect.Y);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height - radius);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddLine(rect.X + rect.Width - radius, rect.Y + rect.Height, rect.X + radius, rect.Y + rect.Height);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.AddLine(rect.X, rect.Y + rect.Height - radius, rect.X, rect.Y + radius);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.CloseFigure();
            picturebox.Region = new Region(path);
        }
        private void lamtronanh(PictureBox picturebox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(picturebox.ClientRectangle);
            picturebox.Region = new Region(path);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(panel1);
        }

        private void userProfilePicture_Paint(object sender, PaintEventArgs e)
        {
            lamtronanh(userProfilePicture);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // load to overview page
            this.Hide();

        }
    }
}
