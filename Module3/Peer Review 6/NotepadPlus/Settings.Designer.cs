
namespace NotepadPlus
{
	partial class SettingsForm
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
			this.autoSaveLabel = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.minsLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// autoSaveLabel
			// 
			this.autoSaveLabel.AutoSize = true;
			this.autoSaveLabel.Location = new System.Drawing.Point(54, 56);
			this.autoSaveLabel.Name = "autoSaveLabel";
			this.autoSaveLabel.Size = new System.Drawing.Size(87, 13);
			this.autoSaveLabel.TabIndex = 0;
			this.autoSaveLabel.Text = "Auto-save period";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.comboBox1.FormatString = "N2";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "30",
            "60"});
			this.comboBox1.Location = new System.Drawing.Point(147, 53);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(39, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// minsLabel
			// 
			this.minsLabel.AutoSize = true;
			this.minsLabel.Location = new System.Drawing.Point(192, 56);
			this.minsLabel.Name = "minsLabel";
			this.minsLabel.Size = new System.Drawing.Size(28, 13);
			this.minsLabel.TabIndex = 2;
			this.minsLabel.Text = "mins";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 277);
			this.Controls.Add(this.minsLabel);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.autoSaveLabel);
			this.MinimumSize = new System.Drawing.Size(320, 200);
			this.Name = "SettingsForm";
			this.Text = " Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label autoSaveLabel;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label minsLabel;
	}
}