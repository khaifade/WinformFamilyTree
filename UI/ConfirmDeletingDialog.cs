using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformFamilyTree.TreeClasses;

namespace WinformFamilyTree.UI
{
    public partial class ConfirmDeletingDialog : Form
    {
        MemberClass member;
        public ConfirmDeletingDialog()
        {
            InitializeComponent();
        }
        public ConfirmDeletingDialog(MemberClass member)
        {
            InitializeComponent();
            this.member = member;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            int numMembers = member.numMember();
            int[] listMemberNeedDel = new int[numMembers]; // mảng lưu ID các thành viên cần phải xoá
            Array.Clear(listMemberNeedDel,0,listMemberNeedDel.Length);
            int[] listRelSpouseNeedDel = new int[numMembers]; // mảng lưu các mối quan hệ vợ chồng cần phải xoá
            Array.Clear(listRelSpouseNeedDel, 0, listRelSpouseNeedDel.Length);
            int MemberIndex = 0; // index của listMemberNeedDel
            int RelSpouseIndex = 0; // index của listRelSpouseNeedDel

            int[] listMemberCheck = new int[numMembers]; // mảng chứa ID các thành viên cần kiểm tra
            int memberCheckIndex = 0;
            listMemberCheck[memberCheckIndex] = member.ID; // thêm thành viên chỉ định vào mảng cần xoá
            memberCheckIndex++;

            while (!isEmpty(listMemberCheck)) // kiểm tra từ thành viên chỉ định xuống tìm vợ/ chồng và con, từ con đi xuống 
            {
                int memberPresent = listMemberCheck[0]; 
                listMemberNeedDel[MemberIndex] = memberPresent;
                MemberIndex++;
                to_Gather(ref listMemberCheck);
                memberCheckIndex--;
                int parentID = member.getParentID(memberPresent);
                int spouseID = member.getSpouseID(memberPresent);
                if(parentID != -1) // nếu thành viên chỉ địng là người trong phả thì xoá nguyên cả nhánh từ người đó đi xuống, nếu là người ngoài thì chỉ xoá người đó
                {
                    member.getChildID(spouseID,ref listMemberCheck, ref memberCheckIndex); // thêm các con vào mảng kiểm tra để kiểm tra 
                    if (spouseID != -1) // nếu có vợ/ chồng thì thêm ng đó vào mảng cần xoá
                    {
                        listRelSpouseNeedDel[RelSpouseIndex] = spouseID;
                        listMemberNeedDel[MemberIndex] = member.getMemberPartner(spouseID,memberPresent);
                        MemberIndex++;
                        RelSpouseIndex++;
                    }

                } else
                {
                    if (spouseID != -1) 
                    {
                        listRelSpouseNeedDel[RelSpouseIndex] = spouseID;
                        RelSpouseIndex++;
                    }
                }
                
            }
             
            member.delParent(member.ID);
            // xoá các mối liên hệ giữa cha mẹ và con 
            for(int i = 0; i< RelSpouseIndex; i++)
            {
                member.delChild(listRelSpouseNeedDel[i]);                        
            }
            // xoá các mối liên hệ giữa vợ chồng
            for (int i = 0; i < RelSpouseIndex; i++)
            {
                member.delSpouse(listRelSpouseNeedDel[i]);
            }
            // xoá các thành viên cần xoá
            for (int i = 0; i< MemberIndex; i++)
            {
                member.Delete(listMemberNeedDel[i]);
            }
            MessageBox.Show("xoá thành công!");
            


            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool isEmpty(int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] != 0)
                    return false;
            }
            return true;
        }

        public void clearArray(ref int[] array)
        {
            for(int i=0; i< array.Length; i++)
            { array[i] = 0; }
        }

        public void to_Gather(ref int[] array)
        {
            for(int i =0; i< array.Length - 1; i++)
            {
                array[i] = array[i+1];
            }
            array[array.Length-1] = 0;
        }
    }
}
