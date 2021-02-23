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
	//FROM THE AUTHOR	
	//WELCOME TO THE SOURCE CODE OF MY NOTEAPAD. I WILL TRY TO SAVE YOUR TIME BY TELLING YOU 
	//WHICH PARTS OF THE ASSIGNMENT ARE COMPLETED
	//YOU CAN CHECK THIS IN THE ABOUT WINDOW, LOCATED UNDER THE HELP MENU
	//THANK YOU IN ADVANCE FOR TAKING TIME TO LOOK AT THIS PROJECT AND RATING IT
	public partial class MainForm : Form
	{
		

		public MainForm()
		{
			InitializeComponent();
		}

		

		private void newMenuButton_Click(object sender, EventArgs e)
		{

			fileTabs.Visible = true;
			TabPage newPage = new CustomTab();
			fileTabs.TabPages.Add(newPage);
			fileTabs.SelectedTab = newPage;	
		}

		#region TextStyleTools
		/// <summary>
		/// Makes selected text bold or reverse.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void boldTool_Click(object sender, EventArgs e)
		{
			ChangeStyle(GetRichTextBox(), FontStyle.Bold);
		}

		/// <summary>
		/// Makes selected text italic or reverse.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void italicTool_Click(object sender, EventArgs e)
		{
			ChangeStyle(GetRichTextBox(), FontStyle.Italic);
		}

		/// <summary>
		/// Makes selected text underlined or reverse.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UnderlineTool_Click(object sender, EventArgs e)
		{
			ChangeStyle((RichTextBox)fileTabs.SelectedTab.Controls[0], FontStyle.Underline);
		}

		/// <summary>
		/// Makes selected text striked out or reverse.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
			try {
				if (text.SelectionFont != null)
				{
					System.Drawing.Font currentFont = text.SelectionFont;
					System.Drawing.FontStyle newFontStyle;

					if (text.SelectionFont.Style == (text.SelectionFont.Style | style))
					{
						newFontStyle = text.SelectionFont.Style & ~style;
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
			catch (Exception e) {
				string message = "You did not enter a server name. Cancel this operation?";
				string caption = "Unexpected error occured";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				DialogResult result = MessageBox.Show(message, caption, buttons);
				if (result == System.Windows.Forms.DialogResult.OK)
				{
					// Closes the parent form.
					this.Close();
				}
			}
			
		}

		/// <summary>
		/// Makes selected text bigger with 1em.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void biggerTextTool_Click(object sender, EventArgs e)
		{
			var text = GetRichTextBox();

			if (text.SelectionFont != null)
			{
				System.Drawing.Font currentFont = text.SelectionFont;
				var newsize = currentFont.Size + 1;

				text.SelectionFont = new Font(
				   currentFont.FontFamily,
				   newsize,
				   text.SelectionFont.Style
				);
			}
		}

		/// <summary>
		/// Makes selected text smaller with 1em.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void smallerTextTool_Click(object sender, EventArgs e)
		{
			var text = GetRichTextBox();

			if (text.SelectionFont != null)
			{
				System.Drawing.Font currentFont = text.SelectionFont;
				var newsize = currentFont.Size - 1;

				text.SelectionFont = new Font(
				   currentFont.FontFamily,
				   newsize,
				   text.SelectionFont.Style
				);
			}
		}
		#endregion

		#region Open & Save
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
		#endregion

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Determine if text has changed in the textbox by comparing to original text.
			if (fileTabs.SelectedTab.Controls[0].Text != "f")
			{
				// Display a MsgBox asking the user to save changes or abort.
				if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
				   MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					// Cancel the Closing event from closing the form.
					e.Cancel = true;
					// Call method to save file...
				}
			}
		}
		

		private void customizeMenu_Click(object sender, EventArgs e)
		{
			
		}

		private void aboutMenu_Click(object sender, EventArgs e)
		{
			Form aboutBox = new About();
			aboutBox.ShowDialog();
		}

		private void exitMenu_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		

		private void fontEdit_Click(object sender, EventArgs e)
		{
			if (fontWindow.ShowDialog() != DialogResult.Cancel)
			{
				GetRichTextBox().SelectionFont = fontWindow.Font;
			}
		}

		private RichTextBox GetRichTextBox() {
			RichTextBox rtb = null;
			TabPage tp = fileTabs.SelectedTab;

			if (tp != null)
				rtb = tp.Controls[0] as RichTextBox;
			return rtb;
		}

		private void settingsMenu_Click(object sender, EventArgs e)
		{
			Form settings = new SettingsForm();
			settings.ShowDialog();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.KeyPreview = true;
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			/*if (e.Control == true && e.KeyCode == Keys.K)
			{
				saveMenu.PerformClick();
			}*/
		}

		private void fileTabs_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void newWindowMenu_Click(object sender, EventArgs e)
		{
			var newWindow = new MainForm();
			newWindow.ShowDialog();
		}
	}
}
	