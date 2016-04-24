namespace Boomkwekerij.Views
{
	partial class Voorraadbeheer
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
			this.cmsVoorraad = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.msVoorraadBeheer = new System.Windows.Forms.MenuStrip();
			this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.plantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lvVoorraad = new System.Windows.Forms.ListView();
			this.chAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chPlant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chGrootte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chJaren = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chOpmerking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.cmsVoorraad.SuspendLayout();
			this.msVoorraadBeheer.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmsVoorraad
			// 
			this.cmsVoorraad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
			this.cmsVoorraad.Name = "cmsKlant";
			this.cmsVoorraad.Size = new System.Drawing.Size(153, 70);
			// 
			// tsmiEdit
			// 
			this.tsmiEdit.Name = "tsmiEdit";
			this.tsmiEdit.Size = new System.Drawing.Size(152, 22);
			this.tsmiEdit.Text = "Bewerk";
			this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(152, 22);
			this.tsmiDelete.Text = "Verwijder";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// msVoorraadBeheer
			// 
			this.msVoorraadBeheer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem});
			this.msVoorraadBeheer.Location = new System.Drawing.Point(0, 0);
			this.msVoorraadBeheer.Name = "msVoorraadBeheer";
			this.msVoorraadBeheer.Size = new System.Drawing.Size(684, 24);
			this.msVoorraadBeheer.TabIndex = 9;
			this.msVoorraadBeheer.Text = "msKlantBeheer";
			// 
			// nieuwToolStripMenuItem
			// 
			this.nieuwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plantToolStripMenuItem});
			this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
			this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.nieuwToolStripMenuItem.Text = "Nieuw";
			// 
			// plantToolStripMenuItem
			// 
			this.plantToolStripMenuItem.Name = "plantToolStripMenuItem";
			this.plantToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.plantToolStripMenuItem.Text = "Plant";
			this.plantToolStripMenuItem.Click += new System.EventHandler(this.plantToolStripMenuItem_Click);
			// 
			// lvVoorraad
			// 
			this.lvVoorraad.AllowColumnReorder = true;
			this.lvVoorraad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvVoorraad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAantal,
            this.chPlant,
            this.chGrootte,
            this.chJaren,
            this.chOpmerking});
			this.lvVoorraad.ContextMenuStrip = this.cmsVoorraad;
			this.lvVoorraad.FullRowSelect = true;
			this.lvVoorraad.Location = new System.Drawing.Point(0, 58);
			this.lvVoorraad.Name = "lvVoorraad";
			this.lvVoorraad.Size = new System.Drawing.Size(684, 353);
			this.lvVoorraad.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvVoorraad.TabIndex = 8;
			this.lvVoorraad.UseCompatibleStateImageBehavior = false;
			this.lvVoorraad.View = System.Windows.Forms.View.Details;
			this.lvVoorraad.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvVoorraad_ColumnClick);
			this.lvVoorraad.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvVoorraad_ItemSelectionChanged);
			this.lvVoorraad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvVoorraad_KeyDown);
			this.lvVoorraad.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvVoorraad_MouseDoubleClick);
			// 
			// chAantal
			// 
			this.chAantal.Text = "Aantal";
			// 
			// chPlant
			// 
			this.chPlant.Text = "Plant";
			this.chPlant.Width = 90;
			// 
			// chGrootte
			// 
			this.chGrootte.Text = "Grootte";
			this.chGrootte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.chGrootte.Width = 81;
			// 
			// chJaren
			// 
			this.chJaren.Text = "Jaren";
			this.chJaren.Width = 72;
			// 
			// chOpmerking
			// 
			this.chOpmerking.Text = "Opmerking";
			this.chOpmerking.Width = 373;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Zoek:";
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(53, 32);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(158, 20);
			this.txtFilter.TabIndex = 10;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			// 
			// Voorraadbeheer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 411);
			this.Controls.Add(this.msVoorraadBeheer);
			this.Controls.Add(this.lvVoorraad);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFilter);
			this.Name = "Voorraadbeheer";
			this.Text = "Voorraadbeheer";
			this.Load += new System.EventHandler(this.Voorraadbeheer_Load);
			this.cmsVoorraad.ResumeLayout(false);
			this.msVoorraadBeheer.ResumeLayout(false);
			this.msVoorraadBeheer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip cmsVoorraad;
		private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.MenuStrip msVoorraadBeheer;
		private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
		private System.Windows.Forms.ListView lvVoorraad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.ColumnHeader chAantal;
		private System.Windows.Forms.ColumnHeader chPlant;
		private System.Windows.Forms.ColumnHeader chGrootte;
		private System.Windows.Forms.ColumnHeader chJaren;
		private System.Windows.Forms.ColumnHeader chOpmerking;
		private System.Windows.Forms.ToolStripMenuItem plantToolStripMenuItem;
	}
}