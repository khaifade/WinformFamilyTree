using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformFamilyTree.TreeClasses;
using WinformFamilyTree.Properties;

namespace WinformFamilyTree.UI
{
    public partial class MemberInfoForm : UserControl
    {

        int rootID;
        string type;
        bool imageChanged = false;
        int curID;

        MemberClass member;

        public MemberInfoForm()
        {
            InitializeComponent();
            cancelFormButton.Click += cancelFormButtonFirstTime_Click;
        }
        public MemberInfoForm(string type, int rootID)
        {

            InitializeComponent();
            this.rootID = rootID;
            this.type = type;
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
        public MemberInfoForm(MemberClass member)
        {
            InitializeComponent();
            lastNameTextBox.Text = member.LastName;
            firstNameTextBox.Text = member.FirstName;
            genderComboBox.Text = member.Gender;
            dateOfBirthBox.Value = member.DateOfBirth;
            placeOfOriginTextBox.Text = member.PlaceOfOrigin;
            biographyRichTextBox.Text = member.Biography;
            curID = member.ID;
            type = "edit";
            this.relationshipComboBox.Visible = false;
            this.relationshipLabel.Visible = false;
        }
        private void attachImage_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                attachImage.Image = new Bitmap(openFileDialog.FileName);
                imageChanged = true;
            }
        }
        private void cancelFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            familyTree.instance.Controls.Remove(this);
        }
        private void cancelFormButtonFirstTime_Click(object sender, EventArgs e)
        {
            this.Hide();
            familyTree.instance.ucFirstTimeUserPage.Show();
        }

        private void saveFormButton_Click(object sender, EventArgs e)
        {

            // TODO: Add all filled data to database

            if (string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                MessageBox.Show("Lỗi, hãy điền họ tên!");
            }

            else
            {
                MemberClass member = new MemberClass();
                member.ID = curID;
                member.LastName = lastNameTextBox.Text;
                member.FirstName = firstNameTextBox.Text;
                member.Gender = genderComboBox.Text;
                member.DateOfBirth = dateOfBirthBox.Value;
                member.DateOfDeath = dateOfDeathBox.Value;
                member.PlaceOfOrigin = placeOfOriginTextBox.Text;
                member.Biography = biographyRichTextBox.Text;
                member.proFilePicture = getPicture(member.Gender);

                if (!aliveCheckBox.Checked)
                {
                    member.DateOfDeath = dateOfDeathBox.Value;
                }
                // the first member do not have any relatonship
                if (member.numMember() == 0)
                {
                    if (member.Insert(member))
                    {
                        MessageBox.Show("Thêm thành công!");
                        this.Hide();
                        familyTree.instance.refreshHomeScreen();
                        familyTree.instance.Controls.Remove(this);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi, hãy thử lại!");
                    }
                }
                else // the second member need to connect relationship
                {
                    if (this.type == "spouse") // add spouse 
                    {
                        if (member.getSpouseID(this.rootID) == -1)
                        {
                            if (member.Insert(member) && member.InsertSpouseRel(rootID, member.getMaxMemberID()))
                            {
                                MessageBox.Show("Thêm thành công!");
                                this.Hide();
                                familyTree.instance.refreshHomeScreen();
                                familyTree.instance.Controls.Remove(this);
                            }
                            else
                            {
                                member.Delete(member.getMemberID(member));
                                MessageBox.Show("Lỗi, hãy thử lại!");
                            }

                        }
                        else
                        {
                            if (member.Insert(member) && member.changePartner(member.getMemberID(member), rootID))
                            {
                                MessageBox.Show("Thêm thành công!");
                                this.Hide();
                                familyTree.instance.refreshHomeScreen();
                                familyTree.instance.Controls.Remove(this);
                            }
                            else
                            {
                                member.Delete(member.getMemberID(member));
                                MessageBox.Show("Lỗi, hãy thử lại!");
                            }
                        }
                    }
                    else if (this.type == "child") // add child
                    {
                        if (member.Insert(member) && member.InsertParentChildRel(member.getMaxMemberID(), member.getSpouseID(rootID)))
                        {
                            MessageBox.Show("Thêm thành công!");
                            this.Hide();
                            familyTree.instance.refreshHomeScreen();
                            familyTree.instance.Controls.Remove(this);
                        }
                        else
                        {
                            member.Delete(member.getMemberID(member));
                            MessageBox.Show("Lỗi, hãy thử lại!");
                        }
                    }
                    else if (this.type == "edit") // edit member's info
                    {
                        if (member.Update(member))
                        {
                            MessageBox.Show("Sửa thành công!");
                            this.Hide();
                            familyTree.instance.refreshHomeScreen();
                            BiographyViewScreen.mainPanel.Update();
                            familyTree.instance.Controls.Remove(this);
                        }
                        else
                        {
                            member.Delete(member.getMemberID(member));
                            MessageBox.Show("Lỗi, hãy thử lại!");
                        }
                    }
                    else if (this.type == "parent")
                    {

                    }
                }
            }
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

        private byte[] getPicture(string gender)
        {
            if (imageChanged == false)
            {
                if (gender == "Nam")
                {
                    attachImage.Image = Resources.male;
                }
                else if (gender == "Nữ")
                {
                    attachImage.Image = Resources.female;
                }
            }

            MemoryStream stream = new MemoryStream();
            attachImage.Image.Save(stream, attachImage.Image.RawFormat);
            Byte[] bytBLOBData = new Byte[stream.Length];
            stream.Position = 0;
            stream.Read(bytBLOBData, 0, Convert.ToInt32(stream.Length));
            return bytBLOBData;
        }
    }
}
