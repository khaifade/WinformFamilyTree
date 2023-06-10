namespace WinformFamilyTree
{
    partial class BiographyViewScreen
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
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.fullNameCategory = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.fullNameText = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.genderCategory = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.genderText = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dateOfBirthCategory = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dateOfBirthText = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dataOfDeathCategory = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dataOfDeathText = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.placeOfOriginCategory = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.placeOfOriginText = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.biographyCategory = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.biographyText = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.AvatarProfilePicture = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.editInfoButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.editInfoButton);
            this.MainPanel.Controls.Add(this.AvatarProfilePicture);
            this.MainPanel.Controls.Add(this.biographyText);
            this.MainPanel.Controls.Add(this.placeOfOriginText);
            this.MainPanel.Controls.Add(this.dataOfDeathText);
            this.MainPanel.Controls.Add(this.dateOfBirthText);
            this.MainPanel.Controls.Add(this.genderText);
            this.MainPanel.Controls.Add(this.fullNameText);
            this.MainPanel.Controls.Add(this.biographyCategory);
            this.MainPanel.Controls.Add(this.placeOfOriginCategory);
            this.MainPanel.Controls.Add(this.dataOfDeathCategory);
            this.MainPanel.Controls.Add(this.dateOfBirthCategory);
            this.MainPanel.Controls.Add(this.genderCategory);
            this.MainPanel.Controls.Add(this.fullNameCategory);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(844, 499);
            this.MainPanel.TabIndex = 0;
            // 
            // fullNameCategory
            // 
            this.fullNameCategory.Location = new System.Drawing.Point(15, 13);
            this.fullNameCategory.Margin = new System.Windows.Forms.Padding(0);
            this.fullNameCategory.Name = "fullNameCategory";
            this.fullNameCategory.Size = new System.Drawing.Size(93, 24);
            this.fullNameCategory.StateCommon.ShortText.Font = new System.Drawing.Font("Inter ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameCategory.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.fullNameCategory.TabIndex = 0;
            this.fullNameCategory.Values.Text = "Họ và tên:";
            // 
            // fullNameText
            // 
            this.fullNameText.Location = new System.Drawing.Point(108, 13);
            this.fullNameText.Margin = new System.Windows.Forms.Padding(0);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(140, 24);
            this.fullNameText.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameText.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.fullNameText.TabIndex = 0;
            this.fullNameText.Values.Text = "Richard Naldoko";
            // 
            // genderCategory
            // 
            this.genderCategory.Location = new System.Drawing.Point(15, 37);
            this.genderCategory.Margin = new System.Windows.Forms.Padding(0);
            this.genderCategory.Name = "genderCategory";
            this.genderCategory.Size = new System.Drawing.Size(85, 24);
            this.genderCategory.StateCommon.ShortText.Font = new System.Drawing.Font("Inter ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCategory.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.genderCategory.TabIndex = 0;
            this.genderCategory.Values.Text = "Giới tính:";
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(100, 37);
            this.genderText.Margin = new System.Windows.Forms.Padding(0);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(48, 24);
            this.genderText.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderText.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.genderText.TabIndex = 0;
            this.genderText.Values.Text = "Nam";
            // 
            // dateOfBirthCategory
            // 
            this.dateOfBirthCategory.Location = new System.Drawing.Point(15, 61);
            this.dateOfBirthCategory.Margin = new System.Windows.Forms.Padding(0);
            this.dateOfBirthCategory.Name = "dateOfBirthCategory";
            this.dateOfBirthCategory.Size = new System.Drawing.Size(188, 24);
            this.dateOfBirthCategory.StateCommon.ShortText.Font = new System.Drawing.Font("Inter ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthCategory.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.dateOfBirthCategory.TabIndex = 0;
            this.dateOfBirthCategory.Values.Text = "Ngày tháng năm sinh:";
            // 
            // dateOfBirthText
            // 
            this.dateOfBirthText.Location = new System.Drawing.Point(199, 61);
            this.dateOfBirthText.Margin = new System.Windows.Forms.Padding(0);
            this.dateOfBirthText.Name = "dateOfBirthText";
            this.dateOfBirthText.Size = new System.Drawing.Size(103, 24);
            this.dateOfBirthText.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthText.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.dateOfBirthText.TabIndex = 0;
            this.dateOfBirthText.Values.Text = "30/02/2031";
            // 
            // dataOfDeathCategory
            // 
            this.dataOfDeathCategory.Location = new System.Drawing.Point(15, 85);
            this.dataOfDeathCategory.Margin = new System.Windows.Forms.Padding(0);
            this.dataOfDeathCategory.Name = "dataOfDeathCategory";
            this.dataOfDeathCategory.Size = new System.Drawing.Size(184, 24);
            this.dataOfDeathCategory.StateCommon.ShortText.Font = new System.Drawing.Font("Inter ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataOfDeathCategory.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.dataOfDeathCategory.TabIndex = 0;
            this.dataOfDeathCategory.Values.Text = "Ngày tháng năm mất:";
            // 
            // dataOfDeathText
            // 
            this.dataOfDeathText.Location = new System.Drawing.Point(199, 85);
            this.dataOfDeathText.Margin = new System.Windows.Forms.Padding(0);
            this.dataOfDeathText.Name = "dataOfDeathText";
            this.dataOfDeathText.Size = new System.Drawing.Size(132, 24);
            this.dataOfDeathText.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataOfDeathText.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.dataOfDeathText.TabIndex = 0;
            this.dataOfDeathText.Values.Text = "Không xác định";
            // 
            // placeOfOriginCategory
            // 
            this.placeOfOriginCategory.Location = new System.Drawing.Point(15, 109);
            this.placeOfOriginCategory.Margin = new System.Windows.Forms.Padding(0);
            this.placeOfOriginCategory.Name = "placeOfOriginCategory";
            this.placeOfOriginCategory.Size = new System.Drawing.Size(83, 24);
            this.placeOfOriginCategory.StateCommon.ShortText.Font = new System.Drawing.Font("Inter ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOfOriginCategory.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.placeOfOriginCategory.TabIndex = 0;
            this.placeOfOriginCategory.Values.Text = "Nơi sinh:";
            // 
            // placeOfOriginText
            // 
            this.placeOfOriginText.Location = new System.Drawing.Point(98, 109);
            this.placeOfOriginText.Margin = new System.Windows.Forms.Padding(0);
            this.placeOfOriginText.Name = "placeOfOriginText";
            this.placeOfOriginText.Size = new System.Drawing.Size(92, 24);
            this.placeOfOriginText.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOfOriginText.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.placeOfOriginText.TabIndex = 0;
            this.placeOfOriginText.Values.Text = "Hải Phòng";
            // 
            // biographyCategory
            // 
            this.biographyCategory.Location = new System.Drawing.Point(15, 151);
            this.biographyCategory.Margin = new System.Windows.Forms.Padding(0);
            this.biographyCategory.Name = "biographyCategory";
            this.biographyCategory.Size = new System.Drawing.Size(78, 24);
            this.biographyCategory.StateCommon.ShortText.Font = new System.Drawing.Font("Inter ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biographyCategory.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.biographyCategory.TabIndex = 0;
            this.biographyCategory.Values.Text = "Tiểu sử:";
            // 
            // biographyText
            // 
            this.biographyText.Location = new System.Drawing.Point(15, 178);
            this.biographyText.Margin = new System.Windows.Forms.Padding(0);
            this.biographyText.Name = "biographyText";
            this.biographyText.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.biographyText.ReadOnly = true;
            this.biographyText.Size = new System.Drawing.Size(565, 301);
            this.biographyText.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.biographyText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.biographyText.StateCommon.Content.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.biographyText.StateCommon.Content.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biographyText.TabIndex = 1;
            this.biographyText.Text = "Một ngày nào đó em sẽ giống như là anh sẽ đớn đau cho mà xem, em yêu người ta hết" +
    " rồi, thật sự nhiều lúc, anh nhớ đến em ngày xưa, em biết em mất gì chưa? Em của" +
    " ngày xưa đâu mất.";
            // 
            // AvatarProfilePicture
            // 
            this.AvatarProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AvatarProfilePicture.Enabled = false;
            this.AvatarProfilePicture.Location = new System.Drawing.Point(452, 13);
            this.AvatarProfilePicture.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.AvatarProfilePicture.Name = "AvatarProfilePicture";
            this.AvatarProfilePicture.Size = new System.Drawing.Size(128, 150);
            this.AvatarProfilePicture.StateCommon.Back.Image = global::WinformFamilyTree.Properties.Resources.family_tree_logo;
            this.AvatarProfilePicture.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.AvatarProfilePicture.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(186)))), ((int)(((byte)(239)))));
            this.AvatarProfilePicture.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(85)))));
            this.AvatarProfilePicture.StateCommon.Border.ColorAngle = 225F;
            this.AvatarProfilePicture.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.AvatarProfilePicture.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AvatarProfilePicture.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.AvatarProfilePicture.StateCommon.Border.Rounding = 20;
            this.AvatarProfilePicture.StateCommon.Border.Width = 3;
            this.AvatarProfilePicture.TabIndex = 2;
            this.AvatarProfilePicture.Values.Image = global::WinformFamilyTree.Properties.Resources.family_tree_logo;
            this.AvatarProfilePicture.Values.Text = "";
            // 
            // editInfoButton
            // 
            this.editInfoButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.editInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editInfoButton.Location = new System.Drawing.Point(681, 443);
            this.editInfoButton.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.editInfoButton.Name = "editInfoButton";
            this.editInfoButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.editInfoButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.editInfoButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.editInfoButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editInfoButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.editInfoButton.OverrideDefault.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.editInfoButton.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.editInfoButton.Size = new System.Drawing.Size(134, 46);
            this.editInfoButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.editInfoButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.editInfoButton.StateCommon.Back.ColorAngle = 180F;
            this.editInfoButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.editInfoButton.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.editInfoButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.editInfoButton.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.editInfoButton.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.editInfoButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editInfoButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.editInfoButton.StateCommon.Border.Rounding = 20;
            this.editInfoButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInfoButton.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.editInfoButton.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.editInfoButton.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.editInfoButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.editInfoButton.StateNormal.Back.ColorAngle = 180F;
            this.editInfoButton.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.editInfoButton.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.editInfoButton.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.editInfoButton.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.editInfoButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editInfoButton.StateNormal.Border.Rounding = 20;
            this.editInfoButton.StateNormal.Content.LongText.Color1 = System.Drawing.Color.White;
            this.editInfoButton.StateNormal.Content.LongText.Color2 = System.Drawing.Color.White;
            this.editInfoButton.StateNormal.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.editInfoButton.StateNormal.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.editInfoButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.editInfoButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editInfoButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.editInfoButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.editInfoButton.StateTracking.Back.ColorAngle = 180F;
            this.editInfoButton.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.editInfoButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.editInfoButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.editInfoButton.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.editInfoButton.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.editInfoButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editInfoButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.editInfoButton.StateTracking.Border.Rounding = 20;
            this.editInfoButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.editInfoButton.TabIndex = 8;
            this.editInfoButton.Values.Text = "Chỉnh sửa";
            // 
            // BiographyViewScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BiographyViewScreen";
            this.Size = new System.Drawing.Size(844, 499);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel fullNameText;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel fullNameCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel genderText;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel genderCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox biographyText;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel placeOfOriginText;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dataOfDeathText;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dateOfBirthText;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel biographyCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel placeOfOriginCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dataOfDeathCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dateOfBirthCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AvatarProfilePicture;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editInfoButton;
    }
}
