namespace Boomkwekerij
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
			this.msMain = new System.Windows.Forms.MenuStrip();
			this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beheerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.klantenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.msMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// msMain
			// 
			this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.beheerToolStripMenuItem});
			this.msMain.Location = new System.Drawing.Point(0, 0);
			this.msMain.Name = "msMain";
			this.msMain.Size = new System.Drawing.Size(634, 24);
			this.msMain.TabIndex = 0;
			this.msMain.Text = "menuStrip1";
			// 
			// bestandToolStripMenuItem
			// 
			this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
			this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.bestandToolStripMenuItem.Text = "Bestand";
			// 
			// beheerToolStripMenuItem
			// 
			this.beheerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klantenToolStripMenuItem});
			this.beheerToolStripMenuItem.Name = "beheerToolStripMenuItem";
			this.beheerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.beheerToolStripMenuItem.Text = "Beheer";
			// 
			// klantenToolStripMenuItem
			// 
			this.klantenToolStripMenuItem.Name = "klantenToolStripMenuItem";
			this.klantenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.klantenToolStripMenuItem.Text = "Klanten";
			this.klantenToolStripMenuItem.Click += new System.EventHandler(this.klantenToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 441);
			this.Controls.Add(this.msMain);
			this.MainMenuStrip = this.msMain;
			this.Name = "MainForm";
			this.Text = "Boomkwekerij";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.msMain.ResumeLayout(false);
			this.msMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msMain;
		private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem beheerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem klantenToolStripMenuItem;
	}
}

