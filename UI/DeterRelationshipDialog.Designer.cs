namespace WinformFamilyTree.UI
{
    partial class DeterRelationshipDialog
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Container = new System.Windows.Forms.TableLayoutPanel();
            this.deterRelationshipLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.relationship = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.memberNode1 = new WinformFamilyTree.UI.memberNode();
            this.memberNode2 = new WinformFamilyTree.UI.memberNode();
            this.MainPanel.SuspendLayout();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Container);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(544, 261);
            this.MainPanel.TabIndex = 0;
            // 
            // Container
            // 
            this.Container.ColumnCount = 3;
            this.Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Container.Controls.Add(this.deterRelationshipLabel, 0, 0);
            this.Container.Controls.Add(this.memberNode1, 0, 1);
            this.Container.Controls.Add(this.memberNode2, 2, 1);
            this.Container.Controls.Add(this.relationship, 1, 1);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Margin = new System.Windows.Forms.Padding(0);
            this.Container.Name = "Container";
            this.Container.RowCount = 2;
            this.Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.Container.Size = new System.Drawing.Size(544, 261);
            this.Container.TabIndex = 0;
            // 
            // deterRelationshipLabel
            // 
            this.deterRelationshipLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Container.SetColumnSpan(this.deterRelationshipLabel, 3);
            this.deterRelationshipLabel.Location = new System.Drawing.Point(90, 29);
            this.deterRelationshipLabel.Margin = new System.Windows.Forms.Padding(0);
            this.deterRelationshipLabel.Name = "deterRelationshipLabel";
            this.deterRelationshipLabel.Size = new System.Drawing.Size(364, 45);
            this.deterRelationshipLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(186)))), ((int)(((byte)(239)))));
            this.deterRelationshipLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(85)))));
            this.deterRelationshipLabel.StateCommon.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.deterRelationshipLabel.StateCommon.ShortText.ColorAngle = 180F;
            this.deterRelationshipLabel.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.deterRelationshipLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Inter ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deterRelationshipLabel.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.deterRelationshipLabel.StateCommon.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.deterRelationshipLabel.StateCommon.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.deterRelationshipLabel.TabIndex = 7;
            this.deterRelationshipLabel.Values.Text = "Xác định mối quan hệ";
            // 
            // relationship
            // 
            this.relationship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relationship.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.relationship.Cursor = System.Windows.Forms.Cursors.Cross;
            this.relationship.Location = new System.Drawing.Point(217, 159);
            this.relationship.Margin = new System.Windows.Forms.Padding(0);
            this.relationship.Name = "relationship";
            this.relationship.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.relationship.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.relationship.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.relationship.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.relationship.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.relationship.OverrideDefault.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.relationship.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.relationship.Size = new System.Drawing.Size(108, 46);
            this.relationship.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.relationship.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.relationship.StateCommon.Back.ColorAngle = 180F;
            this.relationship.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.relationship.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.relationship.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.relationship.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.relationship.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.relationship.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.relationship.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.relationship.StateCommon.Border.Rounding = 20;
            this.relationship.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationship.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.relationship.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.relationship.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.relationship.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.relationship.StateNormal.Back.ColorAngle = 180F;
            this.relationship.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.relationship.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.relationship.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.relationship.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.relationship.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.relationship.StateNormal.Border.Rounding = 20;
            this.relationship.StateNormal.Content.LongText.Color1 = System.Drawing.Color.White;
            this.relationship.StateNormal.Content.LongText.Color2 = System.Drawing.Color.White;
            this.relationship.StateNormal.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.relationship.StateNormal.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonHighlight;
            this.relationship.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.relationship.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.relationship.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.relationship.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.relationship.StateTracking.Back.ColorAngle = 180F;
            this.relationship.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.relationship.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.relationship.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.relationship.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.relationship.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.relationship.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.relationship.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.relationship.StateTracking.Border.Rounding = 20;
            this.relationship.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.relationship.TabIndex = 10;
            this.relationship.Values.Text = "Anh - Em";
            // 
            // memberNode1
            // 
            this.memberNode1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memberNode1.BackColor = System.Drawing.Color.Transparent;
            this.memberNode1.Location = new System.Drawing.Point(8, 107);
            this.memberNode1.Margin = new System.Windows.Forms.Padding(0);
            this.memberNode1.Name = "memberNode1";
            this.memberNode1.Size = new System.Drawing.Size(200, 150);
            this.memberNode1.TabIndex = 8;
            // 
            // memberNode2
            // 
            this.memberNode2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memberNode2.BackColor = System.Drawing.Color.Transparent;
            this.memberNode2.Location = new System.Drawing.Point(334, 107);
            this.memberNode2.Margin = new System.Windows.Forms.Padding(0);
            this.memberNode2.Name = "memberNode2";
            this.memberNode2.Size = new System.Drawing.Size(200, 150);
            this.memberNode2.TabIndex = 9;
            // 
            // DeterRelationshipDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 261);
            this.Controls.Add(this.MainPanel);
            this.MaximizeBox = false;
            this.Name = "DeterRelationshipDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác định mối quan hệ";
            this.MainPanel.ResumeLayout(false);
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel Container;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel deterRelationshipLabel;
        private memberNode memberNode1;
        private memberNode memberNode2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton relationship;
    }
}