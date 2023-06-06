﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformFamilyTree.UI
{
    public partial class AddMemberScreen : UserControl
    {
        public AddMemberScreen()
        {
            InitializeComponent();
        }

        private void attachImage_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                attachImage.Load(openImageDialog.FileName);
                
                // TODO: add this picture to database
            }
        }

        private void cancelFormButton_Click(object sender, EventArgs e)
        {
            
        }

        private void saveFormButton_Click(object sender, EventArgs e)
        {

        }
    }
}
