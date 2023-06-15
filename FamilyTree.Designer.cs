using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace WinformFamilyTree
{
    partial class familyTree
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(familyTree));
            this.containerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.navGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.wrappedNavLayout = new System.Windows.Forms.TableLayoutPanel();
            this.wrappedNavButtonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sharedButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.customButton = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.memberListButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.viewBiographyButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.homeScreenButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.wrappedUserLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.AvatarProfilePicture = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.userNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.customFont = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.borderEdge = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.workspaceGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.memberListScreen = new WinformFamilyTree.MemberListScreen();
            this.homeScreen = new WinformFamilyTree.HomeScreen();
            this.biographyScreen = new WinformFamilyTree.BiographyViewScreen();
            this.sharedScreen = new WinformFamilyTree.SharedScreen();
            this.searchBoxContainer = new System.Windows.Forms.Panel();
            this.seachGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.wrappedSearchBox = new System.Windows.Forms.FlowLayoutPanel();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.searchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.customForm = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.containerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navGroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navGroupBox.Panel)).BeginInit();
            this.navGroupBox.Panel.SuspendLayout();
            this.navGroupBox.SuspendLayout();
            this.wrappedNavLayout.SuspendLayout();
            this.wrappedNavButtonLayout.SuspendLayout();
            this.wrappedUserLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceGroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceGroupBox.Panel)).BeginInit();
            this.workspaceGroupBox.Panel.SuspendLayout();
            this.workspaceGroupBox.SuspendLayout();
            this.searchBoxContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seachGroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seachGroupBox.Panel)).BeginInit();
            this.seachGroupBox.Panel.SuspendLayout();
            this.seachGroupBox.SuspendLayout();
            this.wrappedSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerLayout
            // 
            this.containerLayout.BackColor = System.Drawing.Color.Transparent;
            this.containerLayout.ColumnCount = 9;
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.containerLayout.Controls.Add(this.navGroupBox, 1, 2);
            this.containerLayout.Controls.Add(this.workspaceGroupBox, 6, 3);
            this.containerLayout.Controls.Add(this.searchBoxContainer, 7, 2);
            this.containerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerLayout.Location = new System.Drawing.Point(0, 0);
            this.containerLayout.Margin = new System.Windows.Forms.Padding(0);
            this.containerLayout.Name = "containerLayout";
            this.containerLayout.RowCount = 9;
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerLayout.Size = new System.Drawing.Size(1264, 681);
            this.containerLayout.TabIndex = 9;
            this.containerLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // navGroupBox
            // 
            this.containerLayout.SetColumnSpan(this.navGroupBox, 5);
            this.navGroupBox.Location = new System.Drawing.Point(30, 50);
            this.navGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.navGroupBox.Name = "navGroupBox";
            // 
            // navGroupBox.Panel
            // 
            this.navGroupBox.Panel.Controls.Add(this.wrappedNavLayout);
            this.containerLayout.SetRowSpan(this.navGroupBox, 5);
            this.navGroupBox.Size = new System.Drawing.Size(340, 580);
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
            this.navGroupBox.TabIndex = 9;
            this.navGroupBox.Values.Heading = "Phần mềm quản lý cây gia phả";
            // 
            // wrappedNavLayout
            // 
            this.wrappedNavLayout.BackColor = System.Drawing.Color.Transparent;
            this.wrappedNavLayout.ColumnCount = 1;
            this.wrappedNavLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wrappedNavLayout.Controls.Add(this.wrappedNavButtonLayout, 0, 1);
            this.wrappedNavLayout.Controls.Add(this.wrappedUserLayout, 0, 0);
            this.wrappedNavLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrappedNavLayout.Location = new System.Drawing.Point(0, 0);
            this.wrappedNavLayout.Name = "wrappedNavLayout";
            this.wrappedNavLayout.RowCount = 2;
            this.wrappedNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.wrappedNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.wrappedNavLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wrappedNavLayout.Size = new System.Drawing.Size(322, 538);
            this.wrappedNavLayout.TabIndex = 0;
            // 
            // wrappedNavButtonLayout
            // 
            this.wrappedNavButtonLayout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.wrappedNavButtonLayout.AutoSize = true;
            this.wrappedNavButtonLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wrappedNavButtonLayout.Controls.Add(this.sharedButton);
            this.wrappedNavButtonLayout.Controls.Add(this.memberListButton);
            this.wrappedNavButtonLayout.Controls.Add(this.viewBiographyButton);
            this.wrappedNavButtonLayout.Controls.Add(this.homeScreenButton);
            this.wrappedNavButtonLayout.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.wrappedNavButtonLayout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrappedNavButtonLayout.Location = new System.Drawing.Point(18, 282);
            this.wrappedNavButtonLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.wrappedNavButtonLayout.Name = "wrappedNavButtonLayout";
            this.wrappedNavButtonLayout.Size = new System.Drawing.Size(285, 226);
            this.wrappedNavButtonLayout.TabIndex = 3;
            this.wrappedNavButtonLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.wrappedNavButtonLayout_Paint);
            // 
            // sharedButton
            // 
            this.sharedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sharedButton.Location = new System.Drawing.Point(0, 177);
            this.sharedButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.sharedButton.Name = "sharedButton";
            this.sharedButton.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.sharedButton.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.sharedButton.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.sharedButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.sharedButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.sharedButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharedButton.Palette = this.customButton;
            this.sharedButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.sharedButton.Size = new System.Drawing.Size(285, 49);
            this.sharedButton.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.sharedButton.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.sharedButton.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.sharedButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.sharedButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.sharedButton.StatePressed.Content.ShortText.ColorAngle = 90F;
            this.sharedButton.StatePressed.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.sharedButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharedButton.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.sharedButton.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.sharedButton.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.sharedButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.sharedButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharedButton.TabIndex = 6;
            this.sharedButton.Values.Text = "Chia sẻ cây";
            this.sharedButton.Click += new System.EventHandler(this.shareButton_Click);
            // 
            // customButton
            // 
            this.customButton.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.customButton.Common.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.customButton.Common.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.customButton.Common.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.customButton.Common.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.customButton.Common.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.customButton.Common.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.customButton.Common.StateCommon.Border.Rounding = 20;
            this.customButton.Common.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.customButton.Common.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // memberListButton
            // 
            this.memberListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memberListButton.Location = new System.Drawing.Point(0, 118);
            this.memberListButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.memberListButton.Name = "memberListButton";
            this.memberListButton.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.memberListButton.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.memberListButton.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.memberListButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.memberListButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.memberListButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberListButton.Palette = this.customButton;
            this.memberListButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.memberListButton.Size = new System.Drawing.Size(285, 49);
            this.memberListButton.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.memberListButton.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.memberListButton.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.memberListButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.memberListButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.memberListButton.StatePressed.Content.ShortText.ColorAngle = 90F;
            this.memberListButton.StatePressed.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.memberListButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberListButton.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.memberListButton.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.memberListButton.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.memberListButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.memberListButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberListButton.TabIndex = 5;
            this.memberListButton.Values.Text = "Danh sách thành viên";
            this.memberListButton.Click += new System.EventHandler(this.memberListButton_Click);
            // 
            // viewBiographyButton
            // 
            this.viewBiographyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewBiographyButton.Location = new System.Drawing.Point(0, 59);
            this.viewBiographyButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.viewBiographyButton.Name = "viewBiographyButton";
            this.viewBiographyButton.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.viewBiographyButton.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.viewBiographyButton.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.viewBiographyButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.viewBiographyButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.viewBiographyButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBiographyButton.Palette = this.customButton;
            this.viewBiographyButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.viewBiographyButton.Size = new System.Drawing.Size(285, 49);
            this.viewBiographyButton.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.viewBiographyButton.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.viewBiographyButton.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.viewBiographyButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.viewBiographyButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.viewBiographyButton.StatePressed.Content.ShortText.ColorAngle = 90F;
            this.viewBiographyButton.StatePressed.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.viewBiographyButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBiographyButton.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.viewBiographyButton.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.viewBiographyButton.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.viewBiographyButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.viewBiographyButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBiographyButton.TabIndex = 4;
            this.viewBiographyButton.Values.Text = "Xem tiểu sử";
            this.viewBiographyButton.Click += new System.EventHandler(this.viewBiographyButton_Click);
            // 
            // homeScreenButton
            // 
            this.homeScreenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeScreenButton.Location = new System.Drawing.Point(0, 0);
            this.homeScreenButton.Margin = new System.Windows.Forms.Padding(0);
            this.homeScreenButton.Name = "homeScreenButton";
            this.homeScreenButton.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.homeScreenButton.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.homeScreenButton.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.homeScreenButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.homeScreenButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.homeScreenButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScreenButton.Palette = this.customButton;
            this.homeScreenButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.homeScreenButton.Size = new System.Drawing.Size(285, 49);
            this.homeScreenButton.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.homeScreenButton.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.homeScreenButton.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.homeScreenButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.homeScreenButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.homeScreenButton.StatePressed.Content.ShortText.ColorAngle = 90F;
            this.homeScreenButton.StatePressed.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.homeScreenButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScreenButton.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.homeScreenButton.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.homeScreenButton.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.homeScreenButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.homeScreenButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScreenButton.TabIndex = 3;
            this.homeScreenButton.Values.Text = "Màn hình chính";
            this.homeScreenButton.Click += new System.EventHandler(this.homeScreenButton_Click);
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
            this.wrappedUserLayout.Location = new System.Drawing.Point(86, 0);
            this.wrappedUserLayout.Margin = new System.Windows.Forms.Padding(0);
            this.wrappedUserLayout.Name = "wrappedUserLayout";
            this.wrappedUserLayout.Size = new System.Drawing.Size(150, 215);
            this.wrappedUserLayout.TabIndex = 2;
            // 
            // AvatarProfilePicture
            // 
            this.AvatarProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AvatarProfilePicture.Enabled = false;
            this.AvatarProfilePicture.Location = new System.Drawing.Point(0, 20);
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
            this.userNameLabel.Palette = this.customFont;
            this.userNameLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.userNameLabel.Size = new System.Drawing.Size(149, 23);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Values.Text = "Người dùng khách";
            // 
            // customFont
            // 
            this.customFont.Common.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.customFont.Common.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // borderEdge
            // 
            this.borderEdge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.borderEdge.Location = new System.Drawing.Point(25, 203);
            this.borderEdge.Margin = new System.Windows.Forms.Padding(0);
            this.borderEdge.Name = "borderEdge";
            this.borderEdge.Size = new System.Drawing.Size(100, 5);
            this.borderEdge.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.borderEdge.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.borderEdge.StateCommon.ColorAngle = 180F;
            this.borderEdge.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.borderEdge.StateCommon.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.borderEdge.StateCommon.Width = 5;
            // 
            // workspaceGroupBox
            // 
            this.containerLayout.SetColumnSpan(this.workspaceGroupBox, 2);
            this.workspaceGroupBox.Location = new System.Drawing.Point(380, 100);
            this.workspaceGroupBox.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.workspaceGroupBox.Name = "workspaceGroupBox";
            // 
            // workspaceGroupBox.Panel
            // 
            this.workspaceGroupBox.Panel.AutoScroll = true;
            this.workspaceGroupBox.Panel.Controls.Add(this.memberListScreen);
            this.workspaceGroupBox.Panel.Controls.Add(this.homeScreen);
            this.workspaceGroupBox.Panel.Controls.Add(this.biographyScreen);
            this.workspaceGroupBox.Panel.Controls.Add(this.sharedScreen);
            this.containerLayout.SetRowSpan(this.workspaceGroupBox, 4);
            this.workspaceGroupBox.Size = new System.Drawing.Size(862, 530);
            this.workspaceGroupBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.workspaceGroupBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.workspaceGroupBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.workspaceGroupBox.StateCommon.Border.Rounding = 20;
            this.workspaceGroupBox.StateCommon.Border.Width = 2;
            this.workspaceGroupBox.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workspaceGroupBox.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.workspaceGroupBox.TabIndex = 12;
            this.workspaceGroupBox.Values.Heading = "Tổng quan";
            // 
            // memberListScreen
            // 
            this.memberListScreen.BackColor = System.Drawing.Color.White;
            this.memberListScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberListScreen.Location = new System.Drawing.Point(0, 0);
            this.memberListScreen.Margin = new System.Windows.Forms.Padding(0);
            this.memberListScreen.Name = "memberListScreen";
            this.memberListScreen.Size = new System.Drawing.Size(844, 500);
            this.memberListScreen.TabIndex = 2;
            // 
            // homeScreen
            // 
            this.homeScreen.AutoScroll = true;
            this.homeScreen.BackColor = System.Drawing.Color.White;
            this.homeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeScreen.Location = new System.Drawing.Point(0, 0);
            this.homeScreen.Margin = new System.Windows.Forms.Padding(0);
            this.homeScreen.MaximumSize = new System.Drawing.Size(844, 499);
            this.homeScreen.Name = "homeScreen";
            this.homeScreen.Size = new System.Drawing.Size(844, 499);
            this.homeScreen.TabIndex = 0;
            // 
            // biographyScreen
            // 
            this.biographyScreen.BackColor = System.Drawing.Color.White;
            this.biographyScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biographyScreen.Location = new System.Drawing.Point(0, 0);
            this.biographyScreen.Margin = new System.Windows.Forms.Padding(0);
            this.biographyScreen.Name = "biographyScreen";
            this.biographyScreen.Size = new System.Drawing.Size(844, 500);
            this.biographyScreen.TabIndex = 1;
            // 
            // sharedScreen
            // 
            this.sharedScreen.BackColor = System.Drawing.Color.White;
            this.sharedScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sharedScreen.Location = new System.Drawing.Point(0, 0);
            this.sharedScreen.Margin = new System.Windows.Forms.Padding(0);
            this.sharedScreen.Name = "sharedScreen";
            this.sharedScreen.Size = new System.Drawing.Size(844, 500);
            this.sharedScreen.TabIndex = 3;
            this.sharedScreen.Load += new System.EventHandler(this.sharedScreen_Load);
            // 
            // searchBoxContainer
            // 
            this.searchBoxContainer.Controls.Add(this.seachGroupBox);
            this.searchBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBoxContainer.Location = new System.Drawing.Point(1027, 53);
            this.searchBoxContainer.Name = "searchBoxContainer";
            this.searchBoxContainer.Size = new System.Drawing.Size(212, 44);
            this.searchBoxContainer.TabIndex = 13;
            // 
            // seachGroupBox
            // 
            this.seachGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seachGroupBox.Location = new System.Drawing.Point(0, 0);
            this.seachGroupBox.Name = "seachGroupBox";
            // 
            // seachGroupBox.Panel
            // 
            this.seachGroupBox.Panel.Controls.Add(this.wrappedSearchBox);
            this.seachGroupBox.Size = new System.Drawing.Size(212, 44);
            this.seachGroupBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.seachGroupBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.seachGroupBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.seachGroupBox.StateCommon.Border.Rounding = 20;
            this.seachGroupBox.StateCommon.Border.Width = 2;
            this.seachGroupBox.TabIndex = 11;
            // 
            // wrappedSearchBox
            // 
            this.wrappedSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.wrappedSearchBox.Controls.Add(this.searchIcon);
            this.wrappedSearchBox.Controls.Add(this.searchBox);
            this.wrappedSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrappedSearchBox.Location = new System.Drawing.Point(0, 0);
            this.wrappedSearchBox.Margin = new System.Windows.Forms.Padding(0);
            this.wrappedSearchBox.Name = "wrappedSearchBox";
            this.wrappedSearchBox.Size = new System.Drawing.Size(194, 26);
            this.wrappedSearchBox.TabIndex = 0;
            // 
            // searchIcon
            // 
            this.searchIcon.Image = global::WinformFamilyTree.Properties.Resources.search;
            this.searchIcon.Location = new System.Drawing.Point(0, 0);
            this.searchIcon.Margin = new System.Windows.Forms.Padding(0);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(25, 25);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 0;
            this.searchIcon.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(25, 0);
            this.searchBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(163, 26);
            this.searchBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.searchBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.searchBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchBox.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.searchBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.TabIndex = 10;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.containerLayout);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1264, 681);
            this.MainPanel.TabIndex = 13;
            // 
            // familyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "familyTree";
            this.Palette = this.customForm;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.containerLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navGroupBox.Panel)).EndInit();
            this.navGroupBox.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navGroupBox)).EndInit();
            this.navGroupBox.ResumeLayout(false);
            this.wrappedNavLayout.ResumeLayout(false);
            this.wrappedNavLayout.PerformLayout();
            this.wrappedNavButtonLayout.ResumeLayout(false);
            this.wrappedUserLayout.ResumeLayout(false);
            this.wrappedUserLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceGroupBox.Panel)).EndInit();
            this.workspaceGroupBox.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workspaceGroupBox)).EndInit();
            this.workspaceGroupBox.ResumeLayout(false);
            this.searchBoxContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seachGroupBox.Panel)).EndInit();
            this.seachGroupBox.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seachGroupBox)).EndInit();
            this.seachGroupBox.ResumeLayout(false);
            this.wrappedSearchBox.ResumeLayout(false);
            this.wrappedSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel containerLayout;
        private SharedScreen sharedScreen;
        private MemberListScreen memberListScreen;
        private BiographyViewScreen biographyScreen;
        private HomeScreen homeScreen;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox navGroupBox;
        private TableLayoutPanel wrappedNavLayout;
        private FlowLayoutPanel wrappedNavButtonLayout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton homeScreenButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette customButton;
        private FlowLayoutPanel wrappedUserLayout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AvatarProfilePicture;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel userNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette customFont;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge borderEdge;
        private ComponentFactory.Krypton.Toolkit.KryptonButton sharedButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton memberListButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton viewBiographyButton;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup seachGroupBox;
        private FlowLayoutPanel wrappedSearchBox;
        private PictureBox searchIcon;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchBox;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox workspaceGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette customForm;
        private Panel MainPanel;
        private Panel searchBoxContainer;
    }
}

