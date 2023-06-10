using System;
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
    public partial class MemberInfoForm : UserControl
    {
        public MemberInfoForm()
        {
            InitializeComponent();
            cancelFormButton.Click += cancelFormButtonFirstTime_Click;
            saveFormButton.Click += saveFormButton_Click;
        }

        public MemberInfoForm(string type)
        {

            InitializeComponent();
            if (type == "parent")
            {
                relationshipComboBox.Text = "Bố/Mẹ";

            }
            if (type == "spouse")
            {
                relationshipComboBox.Text = "Vợ/Chồng";
            }
            if (type == "child")
            {
                relationshipComboBox.Text = "Con cái";
            }
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
            this.Hide();
        }
        private void cancelFormButtonFirstTime_Click(object sender, EventArgs e)
        {
            this.Hide();
            familyTree.instance.ucFirstTimeUserPage.Show();
        }

        private void saveFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // TODO: Add all filled data to database
        }

        private void aliveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (aliveCheckBox.Checked == true)
            {
                dateOfDeathBox.Enabled = false;
                DateTime dateOfDeath = new DateTime(3000, 01, 02);
                dateOfDeathBox.Value = dateOfDeath;
            }
            else
            {
                dateOfDeathBox.Enabled = true;

            }
        }
    }
}
