namespace MyBlock.MainFormFolder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button buttonUnForbidden;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewAllow = new System.Windows.Forms.ListView();
            this.IconRight = new System.Windows.Forms.ColumnHeader();
            this.CaptionRight = new System.Windows.Forms.ColumnHeader();
            this.HostRight = new System.Windows.Forms.ColumnHeader();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.labelForbidden = new System.Windows.Forms.Label();
            this.labelWereForbiden = new System.Windows.Forms.Label();
            this.buttonForbidden = new System.Windows.Forms.Button();
            this.buttonForbiddenAll = new System.Windows.Forms.Button();
            this.buttonUnforbiddenAll = new System.Windows.Forms.Button();
            this.listViewForbidden = new System.Windows.Forms.ListView();
            this.Icon = new System.Windows.Forms.ColumnHeader();
            this.Caption = new System.Windows.Forms.ColumnHeader();
            this.Host = new System.Windows.Forms.ColumnHeader();
            this.Left = new System.Windows.Forms.ColumnHeader();
            this.labelUrl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.imageListButtons = new System.Windows.Forms.ImageList(this.components);
            this.myErrorProvider = new MyBlock.UI.MyErrorProvider();
            buttonUnForbidden = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUnForbidden
            // 
            buttonUnForbidden.Location = new System.Drawing.Point(6, 26);
            buttonUnForbidden.Name = "buttonUnForbidden";
            buttonUnForbidden.Size = new System.Drawing.Size(35, 23);
            buttonUnForbidden.TabIndex = 8;
            buttonUnForbidden.Text = ">";
            buttonUnForbidden.UseVisualStyleBackColor = true;
            buttonUnForbidden.Click += new System.EventHandler(this.buttonUnForbidden_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(43, 33);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(1072, 23);
            this.textBoxUrl.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(1121, 33);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(154, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Add to Forbidden";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1290, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // listViewAllow
            // 
            this.listViewAllow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IconRight,
            this.CaptionRight,
            this.HostRight});
            this.tableLayoutPanel.SetColumnSpan(this.listViewAllow, 2);
            this.listViewAllow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAllow.FullRowSelect = true;
            this.listViewAllow.GridLines = true;
            this.listViewAllow.HideSelection = false;
            this.listViewAllow.Location = new System.Drawing.Point(661, 33);
            this.listViewAllow.Name = "listViewAllow";
            this.tableLayoutPanel.SetRowSpan(this.listViewAllow, 3);
            this.listViewAllow.Size = new System.Drawing.Size(602, 580);
            this.listViewAllow.SmallImageList = this.imageList;
            this.listViewAllow.TabIndex = 5;
            this.listViewAllow.UseCompatibleStateImageBehavior = false;
            this.listViewAllow.View = System.Windows.Forms.View.Details;
            // 
            // IconRight
            // 
            this.IconRight.Text = "Icon";
            this.IconRight.Width = 40;
            // 
            // CaptionRight
            // 
            this.CaptionRight.Text = "Caption";
            this.CaptionRight.Width = 300;
            // 
            // HostRight
            // 
            this.HostRight.Text = "Host";
            this.HostRight.Width = 260;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelForbidden
            // 
            this.labelForbidden.AutoSize = true;
            this.labelForbidden.Location = new System.Drawing.Point(3, 0);
            this.labelForbidden.Name = "labelForbidden";
            this.labelForbidden.Size = new System.Drawing.Size(64, 15);
            this.labelForbidden.TabIndex = 6;
            this.labelForbidden.Text = "Forbidden:";
            // 
            // labelWereForbiden
            // 
            this.labelWereForbiden.AutoSize = true;
            this.labelWereForbiden.Location = new System.Drawing.Point(661, 0);
            this.labelWereForbiden.Name = "labelWereForbiden";
            this.labelWereForbiden.Size = new System.Drawing.Size(87, 15);
            this.labelWereForbiden.TabIndex = 7;
            this.labelWereForbiden.Text = "Were Forbiden:";
            // 
            // buttonForbidden
            // 
            this.buttonForbidden.Location = new System.Drawing.Point(6, 55);
            this.buttonForbidden.Name = "buttonForbidden";
            this.buttonForbidden.Size = new System.Drawing.Size(35, 23);
            this.buttonForbidden.TabIndex = 8;
            this.buttonForbidden.Text = "<";
            this.buttonForbidden.UseVisualStyleBackColor = true;
            this.buttonForbidden.Click += new System.EventHandler(this.buttonForbidden_Click);
            // 
            // buttonForbiddenAll
            // 
            this.buttonForbiddenAll.Location = new System.Drawing.Point(6, 113);
            this.buttonForbiddenAll.Name = "buttonForbiddenAll";
            this.buttonForbiddenAll.Size = new System.Drawing.Size(35, 23);
            this.buttonForbiddenAll.TabIndex = 8;
            this.buttonForbiddenAll.Text = "<<";
            this.buttonForbiddenAll.UseVisualStyleBackColor = true;
            this.buttonForbiddenAll.Click += new System.EventHandler(this.buttonForbiddenAll_Click);
            // 
            // buttonUnforbiddenAll
            // 
            this.buttonUnforbiddenAll.Location = new System.Drawing.Point(6, 84);
            this.buttonUnforbiddenAll.Name = "buttonUnforbiddenAll";
            this.buttonUnforbiddenAll.Size = new System.Drawing.Size(35, 23);
            this.buttonUnforbiddenAll.TabIndex = 8;
            this.buttonUnforbiddenAll.Text = ">>";
            this.buttonUnforbiddenAll.UseVisualStyleBackColor = true;
            this.buttonUnforbiddenAll.Click += new System.EventHandler(this.buttonUnforbiddenAll_Click);
            // 
            // listViewForbidden
            // 
            this.listViewForbidden.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Icon,
            this.Caption,
            this.Host,
            this.Left});
            this.listViewForbidden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewForbidden.FullRowSelect = true;
            this.listViewForbidden.GridLines = true;
            this.listViewForbidden.HideSelection = false;
            this.listViewForbidden.Location = new System.Drawing.Point(3, 33);
            this.listViewForbidden.Name = "listViewForbidden";
            this.tableLayoutPanel.SetRowSpan(this.listViewForbidden, 3);
            this.listViewForbidden.Size = new System.Drawing.Size(602, 580);
            this.listViewForbidden.SmallImageList = this.imageList;
            this.listViewForbidden.TabIndex = 5;
            this.listViewForbidden.UseCompatibleStateImageBehavior = false;
            this.listViewForbidden.View = System.Windows.Forms.View.Details;
            // 
            // Icon
            // 
            this.Icon.Text = "Icon";
            this.Icon.Width = 40;
            // 
            // Caption
            // 
            this.Caption.Text = "Caption";
            this.Caption.Width = 280;
            // 
            // Host
            // 
            this.Host.Text = "Host";
            this.Host.Width = 200;
            // 
            // Left
            // 
            this.Left.Text = "Time Left";
            this.Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Left.Width = 75;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(12, 33);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(25, 15);
            this.labelUrl.TabIndex = 9;
            this.labelUrl.Text = "Url:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(buttonUnForbidden);
            this.panel1.Controls.Add(this.buttonForbidden);
            this.panel1.Controls.Add(this.buttonForbiddenAll);
            this.panel1.Controls.Add(this.buttonUnforbiddenAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(611, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 179);
            this.panel1.TabIndex = 13;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelForbidden, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.listViewForbidden, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.listViewAllow, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.labelWereForbiden, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonRemove, 3, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 62);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.64269F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.64269F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.71461F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1266, 616);
            this.tableLayoutPanel.TabIndex = 14;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.Location = new System.Drawing.Point(1174, 0);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(92, 30);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // imageListButtons
            // 
            this.imageListButtons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtons.ImageStream")));
            this.imageListButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtons.Images.SetKeyName(0, "icons8-remove-48.png");
            // 
            // myErrorProvider
            // 
            this.myErrorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 690);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My Block Url";            
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ListView listViewAllow;
        private System.Windows.Forms.Label labelForbidden;
        private System.Windows.Forms.Label labelWereForbiden;
        private System.Windows.Forms.Button buttonForbidden;
        private System.Windows.Forms.Button buttonForbiddenAll;
        private System.Windows.Forms.Button buttonUnforbiddenAll;
        private System.Windows.Forms.ListView listViewForbidden;
        private System.Windows.Forms.ColumnHeader Icon;
        private System.Windows.Forms.ColumnHeader Caption;
        private System.Windows.Forms.ColumnHeader Left;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ColumnHeader Host;
        private System.Windows.Forms.ColumnHeader IconRight;
        private System.Windows.Forms.ColumnHeader CaptionRight;
        private System.Windows.Forms.ColumnHeader HostRight;
        private System.Windows.Forms.ImageList imageListButtons;
        protected internal System.Windows.Forms.Button buttonRemove;
        private UI.MyErrorProvider myErrorProvider;
    }
}
