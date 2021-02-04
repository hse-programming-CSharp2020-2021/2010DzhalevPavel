
namespace NotepadPlus
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textArea1 = new System.Windows.Forms.RichTextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.boldTool = new System.Windows.Forms.ToolStripButton();
			this.italicTool = new System.Windows.Forms.ToolStripButton();
			this.underlineTool = new System.Windows.Forms.ToolStripButton();
			this.strikeoutTool = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.openFileWindow = new System.Windows.Forms.OpenFileDialog();
			this.fileTabs = new System.Windows.Forms.TabControl();
			this.tabName = new System.Windows.Forms.TabPage();
			this.saveFileWindow = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.fileTabs.SuspendLayout();
			this.tabName.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuButton,
            this.editMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileMenuButton
			// 
			this.fileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuButton,
            this.openMenu,
            this.toolStripSeparator,
            this.saveMenu,
            this.saveAsMenu,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
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
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			// 
			// editMenuItem
			// 
			this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
			this.editMenuItem.Name = "editMenuItem";
			this.editMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editMenuItem.Text = "&Edit";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.undoToolStripMenuItem.Text = "&Undo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.redoToolStripMenuItem.Text = "&Redo";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
			this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.cutToolStripMenuItem.Text = "Cu&t";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
			this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
			this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.pasteToolStripMenuItem.Text = "&Paste";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.selectAllToolStripMenuItem.Text = "Select &All";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.customizeToolStripMenuItem.Text = "&Customize";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// contentsToolStripMenuItem
			// 
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.contentsToolStripMenuItem.Text = "&Contents";
			// 
			// indexToolStripMenuItem
			// 
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.indexToolStripMenuItem.Text = "&Index";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.searchToolStripMenuItem.Text = "&Search";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			// 
			// textArea1
			// 
			this.textArea1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textArea1.Location = new System.Drawing.Point(3, 3);
			this.textArea1.Name = "textArea1";
			this.textArea1.Size = new System.Drawing.Size(786, 369);
			this.textArea1.TabIndex = 1;
			this.textArea1.Text = "";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldTool,
            this.italicTool,
            this.underlineTool,
            this.strikeoutTool,
            this.toolStripSeparator6});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
			// openFileWindow
			// 
			this.openFileWindow.FileName = "openFileWindow";
			// 
			// fileTabs
			// 
			this.fileTabs.Controls.Add(this.tabName);
			this.fileTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileTabs.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.fileTabs.Location = new System.Drawing.Point(0, 49);
			this.fileTabs.Name = "fileTabs";
			this.fileTabs.SelectedIndex = 0;
			this.fileTabs.Size = new System.Drawing.Size(800, 401);
			this.fileTabs.TabIndex = 3;
			// 
			// tabName
			// 
			this.tabName.Controls.Add(this.textArea1);
			this.tabName.Location = new System.Drawing.Point(4, 22);
			this.tabName.Name = "tabName";
			this.tabName.Padding = new System.Windows.Forms.Padding(3);
			this.tabName.Size = new System.Drawing.Size(792, 375);
			this.tabName.TabIndex = 0;
			this.tabName.Text = "untitled";
			this.tabName.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.fileTabs);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.fileTabs.ResumeLayout(false);
			this.tabName.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.RichTextBox textArea1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton boldTool;
		private System.Windows.Forms.ToolStripButton italicTool;
		private System.Windows.Forms.ToolStripButton underlineTool;
		private System.Windows.Forms.ToolStripButton strikeoutTool;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.OpenFileDialog openFileWindow;
		private System.Windows.Forms.TabControl fileTabs;
		private System.Windows.Forms.TabPage tabName;
		private System.Windows.Forms.SaveFileDialog saveFileWindow;
	}
}

