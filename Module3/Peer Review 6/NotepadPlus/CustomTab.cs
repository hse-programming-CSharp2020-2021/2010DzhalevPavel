using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadPlus
{
	class CustomTab : TabPage
	{
		private RichTextBox text;
		private ContextMenuStrip menu;

		public RichTextBox CustomTextBox { get => text; set { text = value; } }
		public ContextMenuStrip CustomContextMenu { get => menu; set { menu = value; } }

		public CustomTab() 
		{
			CustomTextBox = new RichTextBox();
			CustomContextMenu = new ContextMenuStrip();
			this.Text = "untitled";
			text.ContextMenuStrip = CustomContextMenu;

			CustomContextMenu.Items.Add("Select all");
			CustomContextMenu.Items.Add("Cut");
			CustomContextMenu.Items.Add("Copy");
			CustomContextMenu.Items.Add("Paste");
			CustomContextMenu.Items.Add("Format");
			CustomContextMenu.ItemClicked += new ToolStripItemClickedEventHandler(customContextMenu_ItemClicked);

			text.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Controls.Add(text);
			text.Dock = DockStyle.Fill;
		}

		public void customContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			ToolStripItem item = e.ClickedItem;
			if (item.Text == "Select all") 
			{
				CustomTextBox.SelectAll();
			}
			if (item.Text == "Cut")
			{
				Clipboard.SetText(CustomTextBox.SelectedText);
				CustomTextBox.SelectedText = "";
			}
			if (item.Text == "Copy")
			{
				Clipboard.SetText(CustomTextBox.SelectedText);
			}
			if (item.Text == "Paste")
			{
				CustomTextBox.SelectedText = Clipboard.GetText();
			}
			else { }
			//TODO:Summon error message 
		}


	}
}
