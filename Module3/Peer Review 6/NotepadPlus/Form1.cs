using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadPlus
{
	public partial class Form1 : Form
	{
		List<RichTextBox> files = new List<RichTextBox>();

		public Form1()
		{
			InitializeComponent();
		}

		private void newMenuButton_Click(object sender, EventArgs e)
		{
			TabPage newPage = new TabPage();
			newPage.Text = "untitled";
			var textBox = new RichTextBox();
			newPage.Controls.Add(textBox);
			textBox.Dock = DockStyle.Fill;
			fileTabs.TabPages.Add(newPage);
			fileTabs.SelectedTab = newPage;
		}

		
		private void boldTool_Click(object sender, EventArgs e)
		{
			;
			ChangeStyle((RichTextBox)fileTabs.SelectedTab.Controls[0], FontStyle.Bold);
		}

		private void italicTool_Click(object sender, EventArgs e)
		{
			ChangeStyle((RichTextBox)fileTabs.SelectedTab.Controls[0], FontStyle.Italic);

		}

		private void UnderlineTool_Click(object sender, EventArgs e)
		{
			ChangeStyle((RichTextBox)fileTabs.SelectedTab.Controls[0], FontStyle.Underline);
		}

		private void strikeoutTool_Click(object sender, EventArgs e)
		{
				ChangeStyle((RichTextBox)fileTabs.SelectedTab.Controls[0], FontStyle.Strikeout);
		}

		/// <summary>
		/// Changes style of selected text in the given richTextBox.
		/// </summary>
		/// <param name="text"></param>
		/// <param name="style"></param>
		public void ChangeStyle(RichTextBox text, FontStyle style)
		{
			if (text.SelectionFont != null)
			{
				System.Drawing.Font currentFont = text.SelectionFont;
				System.Drawing.FontStyle newFontStyle;

				if (text.SelectionFont.Style == (text.SelectionFont.Style | style))
				{
					newFontStyle = text.SelectionFont.Style & ~ style;
				}
				else
				{
					newFontStyle = text.SelectionFont.Style | style;
				}

				text.SelectionFont = new Font(
				   currentFont.FontFamily,
				   currentFont.Size,
				   newFontStyle
				);
			}
		}

		private void openMenu_Click(object sender, EventArgs e)
		{
			openFileWindow.ShowDialog();
			var filePath = openFileWindow.FileName;
			var fileContent = File.ReadAllText(filePath);
			fileTabs.SelectedTab.Controls[0].Text = fileContent;
		}

		private void saveMenu_Click(object sender, EventArgs e)
		{
			var fileName = "untitled.txt";
			saveFileWindow.Filter = "Text files (*.txt)|*.txt";
			saveFileWindow.FilterIndex = 0;
			if (saveFileWindow.ShowDialog() == DialogResult.OK)
			{
				fileName = saveFileWindow.FileName;
				var fileContent = fileTabs.SelectedTab.Controls[0].Text;
				File.WriteAllText(fileName, fileContent);
				fileTabs.SelectedTab.Text = Path.GetFileName(fileName);
			}

		}

		private void saveAsMenu_Click(object sender, EventArgs e)
		{
			var fileName = "untitled.txt";
			saveFileWindow.Filter = "Text files (*.txt)|*.txt|Rich text files (*.rtf*)|*.rtf*|All filed (*.*)|*.";
			saveFileWindow.FilterIndex = 2;
			if (saveFileWindow.ShowDialog() == DialogResult.OK)
			{
				fileName = saveFileWindow.FileName;
				var fileContent = fileTabs.SelectedTab.Controls[0].Text;
				File.WriteAllText(fileName, fileContent);
				fileTabs.SelectedTab.Text = Path.GetFileName(fileName);
			}
			

		}
	}
}
	