namespace WinformFamilyTree.UI
{
    partial class memberNode
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
            this.infoGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.memberBirthYearLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.memberNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.memberProfilePicture = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.infoGroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoGroupBox.Panel)).BeginInit();
            this.infoGroupBox.Panel.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Location = new System.Drawing.Point(0, 100);
            this.infoGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.infoGroupBox.Name = "infoGroupBox";
            // 
            // infoGroupBox.Panel
            // 
            this.infoGroupBox.Panel.Controls.Add(this.memberBirthYearLabel);
            this.infoGroupBox.Panel.Controls.Add(this.memberNameLabel);
            this.infoGroupBox.Size = new System.Drawing.Size(200, 50);
            this.infoGroupBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.infoGroupBox.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.infoGroupBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.infoGroupBox.StateCommon.Border.Rounding = 20;
            this.infoGroupBox.TabIndex = 0;
            this.infoGroupBox.Values.Heading = "";
            // 
            // memberBirthYearLabel
            // 
            this.memberBirthYearLabel.Location = new System.Drawing.Point(134, 7);
            this.memberBirthYearLabel.Margin = new System.Windows.Forms.Padding(0);
            this.memberBirthYearLabel.Name = "memberBirthYearLabel";
            this.memberBirthYearLabel.Size = new System.Drawing.Size(52, 24);
            this.memberBirthYearLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.memberBirthYearLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberBirthYearLabel.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.memberBirthYearLabel.TabIndex = 0;
            this.memberBirthYearLabel.Values.Text = "1923";
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.Location = new System.Drawing.Point(0, 7);
            this.memberNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(98, 24);
            this.memberNameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.memberNameLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLabel.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.memberNameLabel.TabIndex = 0;
            this.memberNameLabel.Values.Text = "Lê Quý Gia";
            // 
            // memberProfilePicture
            // 
            this.memberProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberProfilePicture.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.memberProfilePicture.Location = new System.Drawing.Point(50, 0);
            this.memberProfilePicture.Margin = new System.Windows.Forms.Padding(0);
            this.memberProfilePicture.Name = "memberProfilePicture";
            this.memberProfilePicture.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.memberProfilePicture.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.memberProfilePicture.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.memberProfilePicture.OverrideDefault.Border.Rounding = 20;
            this.memberProfilePicture.OverrideDefault.Border.Width = 5;
            this.memberProfilePicture.Size = new System.Drawing.Size(100, 100);
            this.memberProfilePicture.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.memberProfilePicture.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.memberProfilePicture.StateCommon.Back.Image = global::WinformFamilyTree.Properties.Resources.chu_chim_canh_cut_con_nhin_cute_de_thuong_113124382;
            this.memberProfilePicture.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.memberProfilePicture.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.memberProfilePicture.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.memberProfilePicture.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.memberProfilePicture.StateCommon.Border.Rounding = 20;
            this.memberProfilePicture.StateCommon.Border.Width = 5;
            this.memberProfilePicture.TabIndex = 6;
            this.memberProfilePicture.Values.Text = "";
            this.memberProfilePicture.Click += new System.EventHandler(this.memberProfilePicture_Click);
            // 
            // memberNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.memberProfilePicture);
            this.Controls.Add(this.infoGroupBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "memberNode";
            this.Size = new System.Drawing.Size(200, 150);
            ((System.ComponentModel.ISupportInitialize)(this.infoGroupBox.Panel)).EndInit();
            this.infoGroupBox.Panel.ResumeLayout(false);
            this.infoGroupBox.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoGroupBox)).EndInit();
            this.infoGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox infoGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel memberBirthYearLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel memberNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton memberProfilePicture;
    }
}
