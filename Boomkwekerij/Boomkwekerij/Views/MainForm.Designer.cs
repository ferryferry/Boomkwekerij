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
			this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bestellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.klantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.plantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beheerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.klantenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.voorraadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lvBestellingen = new System.Windows.Forms.ListView();
			this.chBestelnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chBesteldatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chKlant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chFactuurdatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chLaatstAfgedrukt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chToeslagPercentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chBetaald = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gbLeveringen = new System.Windows.Forms.GroupBox();
			this.lvLeveringen = new System.Windows.Forms.ListView();
			this.chAantalGeleverd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chLeverdatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chLeverstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lvPlantenInBestelling = new System.Windows.Forms.ListView();
			this.chPlant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chGrootte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chJaren = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chOpmerking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.msMain.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbLeveringen.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// msMain
			// 
			this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.beheerToolStripMenuItem});
			this.msMain.Location = new System.Drawing.Point(0, 0);
			this.msMain.Name = "msMain";
			this.msMain.Size = new System.Drawing.Size(896, 24);
			this.msMain.TabIndex = 0;
			this.msMain.Text = "menuStrip1";
			// 
			// bestandToolStripMenuItem
			// 
			this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem});
			this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
			this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.bestandToolStripMenuItem.Text = "Bestand";
			// 
			// nieuwToolStripMenuItem
			// 
			this.nieuwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestellingToolStripMenuItem,
            this.klantToolStripMenuItem,
            this.plantToolStripMenuItem});
			this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
			this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.nieuwToolStripMenuItem.Text = "Nieuw";
			// 
			// bestellingToolStripMenuItem
			// 
			this.bestellingToolStripMenuItem.Name = "bestellingToolStripMenuItem";
			this.bestellingToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.bestellingToolStripMenuItem.Text = "Bestelling";
			this.bestellingToolStripMenuItem.Click += new System.EventHandler(this.bestellingToolStripMenuItem_Click);
			// 
			// klantToolStripMenuItem
			// 
			this.klantToolStripMenuItem.Name = "klantToolStripMenuItem";
			this.klantToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.klantToolStripMenuItem.Text = "Klant";
			this.klantToolStripMenuItem.Click += new System.EventHandler(this.klantToolStripMenuItem_Click);
			// 
			// plantToolStripMenuItem
			// 
			this.plantToolStripMenuItem.Name = "plantToolStripMenuItem";
			this.plantToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.plantToolStripMenuItem.Text = "Plant";
			// 
			// beheerToolStripMenuItem
			// 
			this.beheerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klantenToolStripMenuItem,
            this.voorraadToolStripMenuItem});
			this.beheerToolStripMenuItem.Name = "beheerToolStripMenuItem";
			this.beheerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.beheerToolStripMenuItem.Text = "Beheer";
			// 
			// klantenToolStripMenuItem
			// 
			this.klantenToolStripMenuItem.Name = "klantenToolStripMenuItem";
			this.klantenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.klantenToolStripMenuItem.Text = "Klanten";
			this.klantenToolStripMenuItem.Click += new System.EventHandler(this.klantenToolStripMenuItem_Click);
			// 
			// voorraadToolStripMenuItem
			// 
			this.voorraadToolStripMenuItem.Name = "voorraadToolStripMenuItem";
			this.voorraadToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.voorraadToolStripMenuItem.Text = "Voorraad";
			this.voorraadToolStripMenuItem.Click += new System.EventHandler(this.voorraadToolStripMenuItem_Click);
			// 
			// lvBestellingen
			// 
			this.lvBestellingen.AllowColumnReorder = true;
			this.lvBestellingen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvBestellingen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBestelnummer,
            this.chBesteldatum,
            this.chKlant,
            this.chFactuurdatum,
            this.chLaatstAfgedrukt,
            this.chToeslagPercentage,
            this.chBetaald});
			this.lvBestellingen.FullRowSelect = true;
			this.lvBestellingen.Location = new System.Drawing.Point(12, 57);
			this.lvBestellingen.Name = "lvBestellingen";
			this.lvBestellingen.Size = new System.Drawing.Size(872, 284);
			this.lvBestellingen.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvBestellingen.TabIndex = 2;
			this.lvBestellingen.UseCompatibleStateImageBehavior = false;
			this.lvBestellingen.View = System.Windows.Forms.View.Details;
			this.lvBestellingen.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvBestellingen_ItemSelectionChanged);
			// 
			// chBestelnummer
			// 
			this.chBestelnummer.Text = "Bestelnummer";
			this.chBestelnummer.Width = 78;
			// 
			// chBesteldatum
			// 
			this.chBesteldatum.Text = "Besteldatum";
			this.chBesteldatum.Width = 70;
			// 
			// chKlant
			// 
			this.chKlant.Text = "Klant";
			this.chKlant.Width = 110;
			// 
			// chFactuurdatum
			// 
			this.chFactuurdatum.Text = "Factuurdatum";
			this.chFactuurdatum.Width = 77;
			// 
			// chLaatstAfgedrukt
			// 
			this.chLaatstAfgedrukt.Text = "Laatst afgedrukt";
			this.chLaatstAfgedrukt.Width = 89;
			// 
			// chToeslagPercentage
			// 
			this.chToeslagPercentage.Text = "Toeslagpercentage";
			this.chToeslagPercentage.Width = 104;
			// 
			// chBetaald
			// 
			this.chBetaald.Text = "Rekening betaald";
			this.chBetaald.Width = 96;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Zoek:";
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(50, 31);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(158, 20);
			this.txtFilter.TabIndex = 8;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.gbLeveringen);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 347);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(872, 273);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Geselecteerde bestelling informatie";
			// 
			// gbLeveringen
			// 
			this.gbLeveringen.Controls.Add(this.lvLeveringen);
			this.gbLeveringen.Enabled = false;
			this.gbLeveringen.Location = new System.Drawing.Point(675, 19);
			this.gbLeveringen.Name = "gbLeveringen";
			this.gbLeveringen.Size = new System.Drawing.Size(191, 248);
			this.gbLeveringen.TabIndex = 15;
			this.gbLeveringen.TabStop = false;
			this.gbLeveringen.Text = "Leveringen";
			// 
			// lvLeveringen
			// 
			this.lvLeveringen.AllowColumnReorder = true;
			this.lvLeveringen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvLeveringen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAantalGeleverd,
            this.chLeverdatum,
            this.chLeverstatus});
			this.lvLeveringen.FullRowSelect = true;
			this.lvLeveringen.Location = new System.Drawing.Point(6, 19);
			this.lvLeveringen.Name = "lvLeveringen";
			this.lvLeveringen.Size = new System.Drawing.Size(179, 223);
			this.lvLeveringen.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvLeveringen.TabIndex = 13;
			this.lvLeveringen.UseCompatibleStateImageBehavior = false;
			this.lvLeveringen.View = System.Windows.Forms.View.Details;
			// 
			// chAantalGeleverd
			// 
			this.chAantalGeleverd.Text = "Aantal";
			this.chAantalGeleverd.Width = 42;
			// 
			// chLeverdatum
			// 
			this.chLeverdatum.Text = "Leverdatum";
			this.chLeverdatum.Width = 68;
			// 
			// chLeverstatus
			// 
			this.chLeverstatus.Text = "Afgeleverd";
			this.chLeverstatus.Width = 292;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lvPlantenInBestelling);
			this.groupBox2.Location = new System.Drawing.Point(6, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(663, 248);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Producten in bestelling";
			// 
			// lvPlantenInBestelling
			// 
			this.lvPlantenInBestelling.AllowColumnReorder = true;
			this.lvPlantenInBestelling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvPlantenInBestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPlant,
            this.chAantal,
            this.chPrijs,
            this.chGrootte,
            this.chJaren,
            this.chOpmerking});
			this.lvPlantenInBestelling.FullRowSelect = true;
			this.lvPlantenInBestelling.Location = new System.Drawing.Point(6, 17);
			this.lvPlantenInBestelling.Name = "lvPlantenInBestelling";
			this.lvPlantenInBestelling.Size = new System.Drawing.Size(651, 225);
			this.lvPlantenInBestelling.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvPlantenInBestelling.TabIndex = 11;
			this.lvPlantenInBestelling.UseCompatibleStateImageBehavior = false;
			this.lvPlantenInBestelling.View = System.Windows.Forms.View.Details;
			this.lvPlantenInBestelling.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvPlantenInBestelling_ItemSelectionChanged);
			// 
			// chPlant
			// 
			this.chPlant.Text = "Plant";
			this.chPlant.Width = 120;
			// 
			// chAantal
			// 
			this.chAantal.Text = "Aantal";
			// 
			// chPrijs
			// 
			this.chPrijs.Text = "Prijs";
			this.chPrijs.Width = 80;
			// 
			// chGrootte
			// 
			this.chGrootte.Text = "Grootte";
			this.chGrootte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.chGrootte.Width = 80;
			// 
			// chJaren
			// 
			this.chJaren.Text = "Jaren";
			this.chJaren.Width = 80;
			// 
			// chOpmerking
			// 
			this.chOpmerking.Text = "Opmerking";
			this.chOpmerking.Width = 200;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 632);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.lvBestellingen);
			this.Controls.Add(this.msMain);
			this.MainMenuStrip = this.msMain;
			this.Name = "MainForm";
			this.Text = "Boomkwekerij";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.msMain.ResumeLayout(false);
			this.msMain.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.gbLeveringen.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msMain;
		private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem beheerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem klantenToolStripMenuItem;
		private System.Windows.Forms.ListView lvBestellingen;
		private System.Windows.Forms.ColumnHeader chBestelnummer;
		private System.Windows.Forms.ColumnHeader chBesteldatum;
		private System.Windows.Forms.ColumnHeader chFactuurdatum;
		private System.Windows.Forms.ColumnHeader chLaatstAfgedrukt;
		private System.Windows.Forms.ColumnHeader chToeslagPercentage;
		private System.Windows.Forms.ColumnHeader chBetaald;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.ColumnHeader chKlant;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvPlantenInBestelling;
		private System.Windows.Forms.ColumnHeader chPlant;
		private System.Windows.Forms.ColumnHeader chGrootte;
		private System.Windows.Forms.ColumnHeader chJaren;
		private System.Windows.Forms.ColumnHeader chAantal;
		private System.Windows.Forms.ColumnHeader chPrijs;
		private System.Windows.Forms.ColumnHeader chOpmerking;
		private System.Windows.Forms.ListView lvLeveringen;
		private System.Windows.Forms.ColumnHeader chAantalGeleverd;
		private System.Windows.Forms.ColumnHeader chLeverdatum;
		private System.Windows.Forms.ColumnHeader chLeverstatus;
		private System.Windows.Forms.GroupBox gbLeveringen;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bestellingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem klantToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem plantToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem voorraadToolStripMenuItem;
	}
}

