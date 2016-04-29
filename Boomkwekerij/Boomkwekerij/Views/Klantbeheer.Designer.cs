namespace Boomkwekerij.Views
{
	partial class Klantbeheer
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
			this.cmsKlant = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.msKlantBeheer = new System.Windows.Forms.MenuStrip();
			this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miNewKlant = new System.Windows.Forms.ToolStripMenuItem();
			this.lvKlanten = new System.Windows.Forms.ListView();
			this.chNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chPostcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chWoonplaats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chTelefoonnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmsKlant.SuspendLayout();
			this.msKlantBeheer.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmsKlant
			// 
			this.cmsKlant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
			this.cmsKlant.Name = "cmsKlant";
			this.cmsKlant.Size = new System.Drawing.Size(123, 48);
			// 
			// tsmiEdit
			// 
			this.tsmiEdit.Name = "tsmiEdit";
			this.tsmiEdit.Size = new System.Drawing.Size(122, 22);
			this.tsmiEdit.Text = "Bewerk";
			this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(122, 22);
			this.tsmiDelete.Text = "Verwijder";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// msKlantBeheer
			// 
			this.msKlantBeheer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem});
			this.msKlantBeheer.Location = new System.Drawing.Point(0, 0);
			this.msKlantBeheer.Name = "msKlantBeheer";
			this.msKlantBeheer.Size = new System.Drawing.Size(679, 24);
			this.msKlantBeheer.TabIndex = 5;
			this.msKlantBeheer.Text = "msKlantBeheer";
			// 
			// nieuwToolStripMenuItem
			// 
			this.nieuwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewKlant});
			this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
			this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.nieuwToolStripMenuItem.Text = "Nieuw";
			// 
			// miNewKlant
			// 
			this.miNewKlant.Name = "miNewKlant";
			this.miNewKlant.Size = new System.Drawing.Size(101, 22);
			this.miNewKlant.Text = "Klant";
			this.miNewKlant.Click += new System.EventHandler(this.miNewKlant_Click);
			// 
			// lvKlanten
			// 
			this.lvKlanten.AllowColumnReorder = true;
			this.lvKlanten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvKlanten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNaam,
            this.chAdres,
            this.chPostcode,
            this.chWoonplaats,
            this.chTelefoonnummer,
            this.chEmail});
			this.lvKlanten.ContextMenuStrip = this.cmsKlant;
			this.lvKlanten.FullRowSelect = true;
			this.lvKlanten.Location = new System.Drawing.Point(12, 58);
			this.lvKlanten.Name = "lvKlanten";
			this.lvKlanten.Size = new System.Drawing.Size(655, 336);
			this.lvKlanten.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvKlanten.TabIndex = 1;
			this.lvKlanten.UseCompatibleStateImageBehavior = false;
			this.lvKlanten.View = System.Windows.Forms.View.Details;
			this.lvKlanten.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvKlanten_ColumnClick);
			this.lvKlanten.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvKlanten_ItemSelectionChanged);
			this.lvKlanten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKlanten_KeyDown);
			this.lvKlanten.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvKlanten_MouseDoubleClick);
			// 
			// chNaam
			// 
			this.chNaam.Text = "Naam";
			this.chNaam.Width = 130;
			// 
			// chAdres
			// 
			this.chAdres.Text = "Adres";
			this.chAdres.Width = 150;
			// 
			// chPostcode
			// 
			this.chPostcode.Text = "Postcode";
			this.chPostcode.Width = 57;
			// 
			// chWoonplaats
			// 
			this.chWoonplaats.Text = "Woonplaats";
			this.chWoonplaats.Width = 100;
			// 
			// chTelefoonnummer
			// 
			this.chTelefoonnummer.Text = "Telefoonnummer";
			this.chTelefoonnummer.Width = 91;
			// 
			// chEmail
			// 
			this.chEmail.Text = "Email";
			this.chEmail.Width = 123;
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(53, 32);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(158, 20);
			this.txtFilter.TabIndex = 6;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Zoek:";
			// 
			// Klantbeheer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 406);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.lvKlanten);
			this.Controls.Add(this.msKlantBeheer);
			this.MainMenuStrip = this.msKlantBeheer;
			this.Name = "Klantbeheer";
			this.Text = "Klantbeheer";
			this.Load += new System.EventHandler(this.Klantbeheer_Load);
			this.cmsKlant.ResumeLayout(false);
			this.msKlantBeheer.ResumeLayout(false);
			this.msKlantBeheer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip cmsKlant;
		private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.MenuStrip msKlantBeheer;
		private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miNewKlant;
		private System.Windows.Forms.ListView lvKlanten;
		private System.Windows.Forms.ColumnHeader chNaam;
		private System.Windows.Forms.ColumnHeader chAdres;
		private System.Windows.Forms.ColumnHeader chPostcode;
		private System.Windows.Forms.ColumnHeader chWoonplaats;
		private System.Windows.Forms.ColumnHeader chTelefoonnummer;
		private System.Windows.Forms.ColumnHeader chEmail;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.Label label1;
	}
}