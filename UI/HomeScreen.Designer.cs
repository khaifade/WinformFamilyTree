﻿namespace WinformFamilyTree
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
            this.memberProfilePicture = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // memberNode1
            // 
            this.memberNode1.Location = new System.Drawing.Point(152, 151);
            this.memberNode1.Margin = new System.Windows.Forms.Padding(0);
            this.memberNode1.Name = "memberNode1";
            this.memberNode1.Size = new System.Drawing.Size(200, 150);
            this.memberNode1.TabIndex = 0;
            // 
            // memberProfilePicture
            // 
            this.memberProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.memberProfilePicture.Location = new System.Drawing.Point(437, 186);
            this.memberProfilePicture.Margin = new System.Windows.Forms.Padding(0);
            this.memberProfilePicture.Name = "memberProfilePicture";
            this.memberProfilePicture.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(186)))), ((int)(((byte)(239)))));
            this.memberProfilePicture.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(85)))));
            this.memberProfilePicture.OverrideDefault.Border.ColorAngle = 225F;
            this.memberProfilePicture.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.memberProfilePicture.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.memberProfilePicture.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.memberProfilePicture.OverrideDefault.Border.Rounding = 200;
            this.memberProfilePicture.OverrideDefault.Border.Width = 5;
            this.memberProfilePicture.Size = new System.Drawing.Size(100, 100);
            this.memberProfilePicture.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.memberProfilePicture.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.memberProfilePicture.StateCommon.Back.Image = global::WinformFamilyTree.Properties.Resources.chu_chim_canh_cut_con_nhin_cute_de_thuong_113124382;
            this.memberProfilePicture.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.memberProfilePicture.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(186)))), ((int)(((byte)(239)))));
            this.memberProfilePicture.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(85)))));
            this.memberProfilePicture.StateCommon.Border.ColorAngle = 225F;
            this.memberProfilePicture.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.memberProfilePicture.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.memberProfilePicture.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.memberProfilePicture.StateCommon.Border.Rounding = 300;
            this.memberProfilePicture.StateCommon.Border.Width = 5;
            this.memberProfilePicture.TabIndex = 5;
            this.memberProfilePicture.Values.Image = global::WinformFamilyTree.Properties.Resources.chu_chim_canh_cut_con_nhin_cute_de_thuong_113124382;
            this.memberProfilePicture.Values.Text = "";
            // 
            // HomeScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.memberProfilePicture);
            this.Controls.Add(this.memberNode1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(844, 499);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(844, 499);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.memberNode memberNode1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton memberProfilePicture;
    }
}
