
namespace NotepadPlus
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this.newMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.fontEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.boldTool = new System.Windows.Forms.ToolStripButton();
			this.italicTool = new System.Windows.Forms.ToolStripButton();
			this.underlineTool = new System.Windows.Forms.ToolStripButton();
			this.strikeoutTool = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.biggerTextTool = new System.Windows.Forms.ToolStripButton();
			this.smallerTextTool = new System.Windows.Forms.ToolStripButton();
			this.openFileWindow = new System.Windows.Forms.OpenFileDialog();
			this.fileTabs = new System.Windows.Forms.TabControl();
			this.saveFileWindow = new System.Windows.Forms.SaveFileDialog();
			this.fontWindow = new System.Windows.Forms.FontDialog();
			this.newWindowMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuButton,
            this.editMenu,
            this.toolsMenu,
            this.helpMenu});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip.Size = new System.Drawing.Size(828, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileMenuButton
			// 
			this.fileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuButton,
            this.newWindowMenu,
            this.openMenu,
            this.toolStripSeparator,
            this.saveMenu,
            this.saveAsMenu,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitMenu});
			this.fileMenuButton.Name = "fileMenuButton";
			this.fileMenuButton.Size = new System.Drawing.Size(37, 20);
			this.fileMenuButton.Text = "&File";
			// 
			// newMenuButton
			// 
			this.newMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("newMenuButton.Image")));
			this.newMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newMenuButton.Name = "newMenuButton";
			this.newMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newMenuButton.Size = new System.Drawing.Size(180, 22);
			this.newMenuButton.Text = "&New";
			this.newMenuButton.Click += new System.EventHandler(this.newMenuButton_Click);
			// 
			// openMenu
			// 
			this.openMenu.Image = ((System.Drawing.Image)(resources.GetObject("openMenu.Image")));
			this.openMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openMenu.Name = "openMenu";
			this.openMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openMenu.Size = new System.Drawing.Size(180, 22);
			this.openMenu.Text = "Open";
			this.openMenu.ToolTipText = "Open a file to edit";
			this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
			// 
			// saveMenu
			// 
			this.saveMenu.Image = ((System.Drawing.Image)(resources.GetObject("saveMenu.Image")));
			this.saveMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveMenu.Name = "saveMenu";
			this.saveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveMenu.Size = new System.Drawing.Size(180, 22);
			this.saveMenu.Text = "&Save";
			this.saveMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.saveMenu.ToolTipText = "Save a file (default format is .txt)";
			this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
			// 
			// saveAsMenu
			// 
			this.saveAsMenu.Name = "saveAsMenu";
			this.saveAsMenu.Size = new System.Drawing.Size(180, 22);
			this.saveAsMenu.Text = "Save &As";
			this.saveAsMenu.Click += new System.EventHandler(this.saveAsMenu_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
			this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.printToolStripMenuItem.Text = "&Print";
			// 
			// printPreviewToolStripMenuItem
			// 
			this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
			this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
			this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// exitMenu
			// 
			this.exitMenu.Name = "exitMenu";
			this.exitMenu.Size = new System.Drawing.Size(180, 22);
			this.exitMenu.Text = "E&xit";
			this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
			// 
			// editMenu
			// 
			this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontEdit});
			this.editMenu.Name = "editMenu";
			this.editMenu.Size = new System.Drawing.Size(39, 20);
			this.editMenu.Text = "&Edit";
			// 
			// fontEdit
			// 
			this.fontEdit.Name = "fontEdit";
			this.fontEdit.Size = new System.Drawing.Size(98, 22);
			this.fontEdit.Text = "Font";
			this.fontEdit.Click += new System.EventHandler(this.fontEdit_Click);
			// 
			// toolsMenu
			// 
			this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenu});
			this.toolsMenu.Name = "toolsMenu";
			this.toolsMenu.Size = new System.Drawing.Size(46, 20);
			this.toolsMenu.Text = "&Tools";
			// 
			// settingsMenu
			// 
			this.settingsMenu.Name = "settingsMenu";
			this.settingsMenu.Size = new System.Drawing.Size(116, 22);
			this.settingsMenu.Text = "Settings";
			this.settingsMenu.Click += new System.EventHandler(this.settingsMenu_Click);
			// 
			// helpMenu
			// 
			this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
			this.helpMenu.Name = "helpMenu";
			this.helpMenu.Size = new System.Drawing.Size(44, 20);
			this.helpMenu.Text = "&Help";
			// 
			// aboutMenu
			// 
			this.aboutMenu.Name = "aboutMenu";
			this.aboutMenu.Size = new System.Drawing.Size(116, 22);
			this.aboutMenu.Text = "&About...";
			this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldTool,
            this.italicTool,
            this.underlineTool,
            this.strikeoutTool,
            this.toolStripSeparator6,
            this.biggerTextTool,
            this.smallerTextTool});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(828, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// boldTool
			// 
			this.boldTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.boldTool.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.boldTool.Image = ((System.Drawing.Image)(resources.GetObject("boldTool.Image")));
			this.boldTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.boldTool.Name = "boldTool";
			this.boldTool.Size = new System.Drawing.Size(23, 22);
			this.boldTool.Text = "B";
			this.boldTool.ToolTipText = "Bold selected text";
			this.boldTool.Click += new System.EventHandler(this.boldTool_Click);
			// 
			// italicTool
			// 
			this.italicTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.italicTool.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.italicTool.Image = ((System.Drawing.Image)(resources.GetObject("italicTool.Image")));
			this.italicTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.italicTool.Name = "italicTool";
			this.italicTool.Size = new System.Drawing.Size(23, 22);
			this.italicTool.Text = "I";
			this.italicTool.ToolTipText = "Italicize selected text";
			this.italicTool.Click += new System.EventHandler(this.italicTool_Click);
			// 
			// underlineTool
			// 
			this.underlineTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.underlineTool.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
			this.underlineTool.Image = ((System.Drawing.Image)(resources.GetObject("underlineTool.Image")));
			this.underlineTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.underlineTool.Name = "underlineTool";
			this.underlineTool.Size = new System.Drawing.Size(23, 22);
			this.underlineTool.Text = "U";
			this.underlineTool.ToolTipText = "Underline selected text";
			this.underlineTool.Click += new System.EventHandler(this.UnderlineTool_Click);
			// 
			// strikeoutTool
			// 
			this.strikeoutTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.strikeoutTool.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
			this.strikeoutTool.Image = ((System.Drawing.Image)(resources.GetObject("strikeoutTool.Image")));
			this.strikeoutTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.strikeoutTool.Name = "strikeoutTool";
			this.strikeoutTool.Size = new System.Drawing.Size(23, 22);
			this.strikeoutTool.Text = "S";
			this.strikeoutTool.ToolTipText = "Strikeout selected text";
			this.strikeoutTool.Click += new System.EventHandler(this.strikeoutTool_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// biggerTextTool
			// 
			this.biggerTextTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.biggerTextTool.Image = ((System.Drawing.Image)(resources.GetObject("biggerTextTool.Image")));
			this.biggerTextTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.biggerTextTool.Name = "biggerTextTool";
			this.biggerTextTool.Size = new System.Drawing.Size(27, 22);
			this.biggerTextTool.Text = "A+";
			this.biggerTextTool.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.biggerTextTool.ToolTipText = "biggerText";
			this.biggerTextTool.Click += new System.EventHandler(this.biggerTextTool_Click);
			// 
			// smallerTextTool
			// 
			this.smallerTextTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.smallerTextTool.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.smallerTextTool.Image = ((System.Drawing.Image)(resources.GetObject("smallerTextTool.Image")));
			this.smallerTextTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.smallerTextTool.Name = "smallerTextTool";
			this.smallerTextTool.Size = new System.Drawing.Size(23, 22);
			this.smallerTextTool.Text = "a-";
			this.smallerTextTool.Click += new System.EventHandler(this.smallerTextTool_Click);
			// 
			// openFileWindow
			// 
			this.openFileWindow.FileName = "openFileWindow";
			// 
			// fileTabs
			// 
			this.fileTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileTabs.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.fileTabs.Location = new System.Drawing.Point(0, 49);
			this.fileTabs.Name = "fileTabs";
			this.fileTabs.SelectedIndex = 0;
			this.fileTabs.Size = new System.Drawing.Size(828, 451);
			this.fileTabs.TabIndex = 3;
			this.fileTabs.Visible = false;
			this.fileTabs.SelectedIndexChanged += new System.EventHandler(this.fileTabs_SelectedIndexChanged);
			// 
			// newWindowMenu
			// 
			this.newWindowMenu.Name = "newWindowMenu";
			this.newWindowMenu.Size = new System.Drawing.Size(180, 22);
			this.newWindowMenu.Text = "New window";
			this.newWindowMenu.Click += new System.EventHandler(this.newWindowMenu_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(828, 500);
			this.Controls.Add(this.fileTabs);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Notepad+";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileMenuButton;
		private System.Windows.Forms.ToolStripMenuItem newMenuButton;
		private System.Windows.Forms.ToolStripMenuItem openMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem saveMenu;
		private System.Windows.Forms.ToolStripMenuItem saveAsMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitMenu;
		private System.Windows.Forms.ToolStripMenuItem editMenu;
		private System.Windows.Forms.ToolStripMenuItem toolsMenu;
		private System.Windows.Forms.ToolStripMenuItem helpMenu;
		private System.Windows.Forms.ToolStripMenuItem aboutMenu;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton boldTool;
		private System.Windows.Forms.ToolStripButton italicTool;
		private System.Windows.Forms.ToolStripButton underlineTool;
		private System.Windows.Forms.ToolStripButton strikeoutTool;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.OpenFileDialog openFileWindow;
		private System.Windows.Forms.TabControl fileTabs;
		private System.Windows.Forms.SaveFileDialog saveFileWindow;
		private System.Windows.Forms.ToolStripButton biggerTextTool;
		private System.Windows.Forms.FontDialog fontWindow;
		private System.Windows.Forms.ToolStripMenuItem fontEdit;
		private System.Windows.Forms.ToolStripButton smallerTextTool;
		private System.Windows.Forms.ToolStripMenuItem settingsMenu;
		private System.Windows.Forms.ToolStripMenuItem newWindowMenu;
	}
}

