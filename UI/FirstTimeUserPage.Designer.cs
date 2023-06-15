namespace WinformFamilyTree.UI
{
    partial class FirstTimeUserPage
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.TableLayoutPanel();
            this.navGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.wrappedNavLayout = new System.Windows.Forms.TableLayoutPanel();
            this.wrappedUserLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.AvatarProfilePicture = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.userNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.borderEdge = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.startButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.MainPanel.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navGroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navGroupBox.Panel)).BeginInit();
            this.navGroupBox.Panel.SuspendLayout();
            this.navGroupBox.SuspendLayout();
            this.wrappedNavLayout.SuspendLayout();
            this.wrappedUserLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.container);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.TabIndex = 0;
            // 
            // container
            // 
            this.container.ColumnCount = 3;
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.container.Controls.Add(this.navGroupBox, 1, 1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(0);
            this.container.Name = "container";
            this.container.RowCount = 3;
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.container.Size = new System.Drawing.Size(1280, 720);
            this.container.TabIndex = 0;
            // 
            // navGroupBox
            // 
            this.navGroupBox.Location = new System.Drawing.Point(256, 144);
            this.navGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.navGroupBox.Name = "navGroupBox";
            // 
            // navGroupBox.Panel
            // 
            this.navGroupBox.Panel.Controls.Add(this.wrappedNavLayout);
            this.navGroupBox.Size = new System.Drawing.Size(768, 432);
            this.navGroupBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.navGroupBox.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.navGroupBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.navGroupBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.navGroupBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.navGroupBox.StateCommon.Border.Rounding = 20;
            this.navGroupBox.StateCommon.Border.Width = 2;
            this.navGroupBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 10);
            this.navGroupBox.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(186)))), ((int)(((byte)(239)))));
            this.navGroupBox.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(85)))));
            this.navGroupBox.StateCommon.Content.ShortText.ColorAngle = 225F;
            this.navGroupBox.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.navGroupBox.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navGroupBox.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.navGroupBox.TabIndex = 10;
            this.navGroupBox.Values.Heading = "Phần mềm quản lý cây gia phả";
            // 
            // wrappedNavLayout
            // 
            this.wrappedNavLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrappedNavLayout.BackColor = System.Drawing.Color.Transparent;
            this.wrappedNavLayout.ColumnCount = 1;
            this.wrappedNavLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wrappedNavLayout.Controls.Add(this.wrappedUserLayout, 0, 0);
            this.wrappedNavLayout.Controls.Add(this.startButton, 0, 1);
            this.wrappedNavLayout.Location = new System.Drawing.Point(0, 0);
            this.wrappedNavLayout.Name = "wrappedNavLayout";
            this.wrappedNavLayout.RowCount = 2;
            this.wrappedNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.31169F));
            this.wrappedNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.68831F));
            this.wrappedNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wrappedNavLayout.Size = new System.Drawing.Size(750, 390);
            this.wrappedNavLayout.TabIndex = 0;
            // 
            // wrappedUserLayout
            // 
            this.wrappedUserLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.wrappedUserLayout.AutoSize = true;
            this.wrappedUserLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wrappedUserLayout.Controls.Add(this.AvatarProfilePicture);
            this.wrappedUserLayout.Controls.Add(this.userNameLabel);
            this.wrappedUserLayout.Controls.Add(this.borderEdge);
            this.wrappedUserLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.wrappedUserLayout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrappedUserLayout.Location = new System.Drawing.Point(264, 0);
            this.wrappedUserLayout.Margin = new System.Windows.Forms.Padding(0);
            this.wrappedUserLayout.Name = "wrappedUserLayout";
            this.wrappedUserLayout.Size = new System.Drawing.Size(221, 266);
            this.wrappedUserLayout.TabIndex = 2;
            // 
            // AvatarProfilePicture
            // 
            this.AvatarProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AvatarProfilePicture.Enabled = false;
            this.AvatarProfilePicture.Location = new System.Drawing.Point(35, 20);
            this.AvatarProfilePicture.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.AvatarProfilePicture.Name = "AvatarProfilePicture";
            this.AvatarProfilePicture.Size = new System.Drawing.Size(150, 150);
            this.AvatarProfilePicture.StateCommon.Back.Image = global::WinformFamilyTree.Properties.Resources.family_tree_logo;
            this.AvatarProfilePicture.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.AvatarProfilePicture.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.AvatarProfilePicture.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AvatarProfilePicture.StateCommon.Border.Rounding = 100;
            this.AvatarProfilePicture.StateCommon.Border.Width = 3;
            this.AvatarProfilePicture.TabIndex = 1;
            this.AvatarProfilePicture.Values.Image = global::WinformFamilyTree.Properties.Resources.family_tree_logo;
            this.AvatarProfilePicture.Values.Text = "";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userNameLabel.Location = new System.Drawing.Point(0, 180);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(221, 29);
            this.userNameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.userNameLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Values.Text = "Xin chào `userName`";
            // 
            // borderEdge
            // 
            this.borderEdge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.borderEdge.Location = new System.Drawing.Point(60, 214);
            this.borderEdge.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.borderEdge.Name = "borderEdge";
            this.borderEdge.Size = new System.Drawing.Size(100, 5);
            this.borderEdge.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.borderEdge.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.borderEdge.StateCommon.ColorAngle = 180F;
            this.borderEdge.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.borderEdge.StateCommon.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.borderEdge.StateCommon.Width = 5;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Location = new System.Drawing.Point(283, 266);
            this.startButton.Margin = new System.Windows.Forms.Padding(0);
            this.startButton.Name = "startButton";
            this.startButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.startButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.startButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.startButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.startButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.startButton.OverrideDefault.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.startButton.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.startButton.Size = new System.Drawing.Size(183, 46);
            this.startButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.startButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.startButton.StateCommon.Back.ColorAngle = 180F;
            this.startButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.startButton.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.startButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.startButton.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.startButton.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.startButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.startButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.startButton.StateCommon.Border.Rounding = 20;
            this.startButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.startButton.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.startButton.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.startButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.startButton.StateNormal.Back.ColorAngle = 180F;
            this.startButton.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.startButton.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.startButton.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.startButton.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.startButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.startButton.StateNormal.Border.Rounding = 20;
            this.startButton.StateNormal.Content.LongText.Color1 = System.Drawing.Color.White;
            this.startButton.StateNormal.Content.LongText.Color2 = System.Drawing.Color.White;
            this.startButton.StateNormal.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.startButton.StateNormal.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.startButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.startButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.startButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.startButton.StateTracking.Back.ColorAngle = 180F;
            this.startButton.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.startButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.startButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.startButton.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.startButton.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.startButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.startButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.startButton.StateTracking.Border.Rounding = 20;
            this.startButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.startButton.TabIndex = 9;
            this.startButton.Values.Text = "Bắt đầu tạo cây";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // FirstTimeUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FirstTimeUserPage";
            this.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.ResumeLayout(false);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navGroupBox.Panel)).EndInit();
            this.navGroupBox.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navGroupBox)).EndInit();
            this.navGroupBox.ResumeLayout(false);
            this.wrappedNavLayout.ResumeLayout(false);
            this.wrappedNavLayout.PerformLayout();
            this.wrappedUserLayout.ResumeLayout(false);
            this.wrappedUserLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel container;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox navGroupBox;
        private System.Windows.Forms.TableLayoutPanel wrappedNavLayout;
        private System.Windows.Forms.FlowLayoutPanel wrappedUserLayout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AvatarProfilePicture;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel userNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderEdge;
        private ComponentFactory.Krypton.Toolkit.KryptonButton startButton;
    }
}
