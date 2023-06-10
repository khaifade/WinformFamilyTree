using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformFamilyTree
{
    public partial class BiographyViewScreen : UserControl
    {
        // Màn hình khởi tạo khi không có thành viên 
        public BiographyViewScreen()
        {
            InitializeComponent();
            // TODO: Ẩn hết các object, chỉ hiện một thông báo tìm kiếm thành viên trên thanh tìm kiếm
            MainPanel.Visible = false;
        }

        // Màn hình khởi tạo khi truy xuất tiểu sử 1 thành viên từ màn hình chính
        public BiographyViewScreen(string memberID)
        {
            InitializeComponent();
            MainPanel.Visible = true;

        }
    }
}
