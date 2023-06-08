namespace WinformFamilyTree
{
    partial class HomeScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.memberNode1 = new WinformFamilyTree.UI.memberNode();
            this.memberNode2 = new WinformFamilyTree.UI.memberNode();
            this.SuspendLayout();
            // 
            // memberNode1
            // 
            this.memberNode1.BackColor = System.Drawing.Color.Transparent;
            this.memberNode1.Location = new System.Drawing.Point(410, 146);
            this.memberNode1.Margin = new System.Windows.Forms.Padding(0);
            this.memberNode1.Name = "memberNode1";
            this.memberNode1.Size = new System.Drawing.Size(200, 150);
            this.memberNode1.TabIndex = 0;
            // 
            // memberNode2
            // 
            this.memberNode2.BackColor = System.Drawing.Color.Transparent;
            this.memberNode2.Location = new System.Drawing.Point(167, 146);
            this.memberNode2.Margin = new System.Windows.Forms.Padding(0);
            this.memberNode2.Name = "memberNode2";
            this.memberNode2.Size = new System.Drawing.Size(200, 150);
            this.memberNode2.TabIndex = 1;
            // 
            // HomeScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.memberNode2);
            this.Controls.Add(this.memberNode1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(844, 499);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(844, 499);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.memberNode memberNode1;
        private UI.memberNode memberNode2;
    }
}
