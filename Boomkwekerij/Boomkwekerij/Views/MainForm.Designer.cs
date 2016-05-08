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
			this.components = new System.ComponentModel.Container();
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
			this.lvPlantenInBestelling = new System.Windows.Forms.ListView();
			this.chPlant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chAantalBesteld = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chAantelGeleverd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chGrootte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chJaren = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chOpmerking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gbLeveringen = new System.Windows.Forms.GroupBox();
			this.btnLeverbon = new System.Windows.Forms.Button();
			this.btnLeverAlles = new System.Windows.Forms.Button();
			this.lvLeveringen = new System.Windows.Forms.ListView();
			this.chPlantLever = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chAantalGeleverd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chLeverdatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmsPlantenVoorBestelling = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiMaakLevering = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiVerwijderUitBestelling = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsBestellingen = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.bewerkBestellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsLeveringen = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiChangeStatus = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiVerwijderLevering = new System.Windows.Forms.ToolStripMenuItem();
			this.msMain.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbLeveringen.SuspendLayout();
			this.cmsPlantenVoorBestelling.SuspendLayout();
			this.cmsBestellingen.SuspendLayout();
			this.cmsLeveringen.SuspendLayout();
			this.SuspendLayout();
			// 
			// msMain
			// 
			this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.beheerToolStripMenuItem});
			this.msMain.Location = new System.Drawing.Point(0, 0);
			this.msMain.Name = "msMain";
			this.msMain.Size = new System.Drawing.Size(1134, 24);
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
			this.plantToolStripMenuItem.Click += new System.EventHandler(this.plantToolStripMenuItem_Click);
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
			this.lvBestellingen.Size = new System.Drawing.Size(1110, 284);
			this.lvBestellingen.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvBestellingen.TabIndex = 2;
			this.lvBestellingen.UseCompatibleStateImageBehavior = false;
			this.lvBestellingen.View = System.Windows.Forms.View.Details;
			this.lvBestellingen.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvBestellingen_ItemSelectionChanged);
			this.lvBestellingen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvBestellingen_KeyDown);
			this.lvBestellingen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvBestellingen_MouseClick);
			this.lvBestellingen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvBestellingen_MouseDoubleClick);
			// 
			// chBestelnummer
			// 
			this.chBestelnummer.Text = "Bestelnummer";
			this.chBestelnummer.Width = 78;
			// 
			// chBesteldatum
			// 
			this.chBesteldatum.Text = "Besteldatum";
			this.chBesteldatum.Width = 140;
			// 
			// chKlant
			// 
			this.chKlant.Text = "Klant";
			this.chKlant.Width = 110;
			// 
			// chFactuurdatum
			// 
			this.chFactuurdatum.Text = "Factuurdatum";
			this.chFactuurdatum.Width = 140;
			// 
			// chLaatstAfgedrukt
			// 
			this.chLaatstAfgedrukt.Text = "Laatst afgedrukt";
			this.chLaatstAfgedrukt.Width = 140;
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
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvPlantenInBestelling);
			this.groupBox1.Controls.Add(this.gbLeveringen);
			this.groupBox1.Location = new System.Drawing.Point(12, 347);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1110, 273);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Geselecteerde bestelling informatie";
			// 
			// lvPlantenInBestelling
			// 
			this.lvPlantenInBestelling.AllowColumnReorder = true;
			this.lvPlantenInBestelling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvPlantenInBestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPlant,
            this.chAantalBesteld,
            this.chAantelGeleverd,
            this.chPrijs,
            this.chGrootte,
            this.chJaren,
            this.chOpmerking});
			this.lvPlantenInBestelling.FullRowSelect = true;
			this.lvPlantenInBestelling.Location = new System.Drawing.Point(6, 19);
			this.lvPlantenInBestelling.Name = "lvPlantenInBestelling";
			this.lvPlantenInBestelling.Size = new System.Drawing.Size(641, 248);
			this.lvPlantenInBestelling.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvPlantenInBestelling.TabIndex = 11;
			this.lvPlantenInBestelling.UseCompatibleStateImageBehavior = false;
			this.lvPlantenInBestelling.View = System.Windows.Forms.View.Details;
			this.lvPlantenInBestelling.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvPlantenInBestelling_KeyDown);
			this.lvPlantenInBestelling.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvPlantenInBestelling_MouseClick);
			this.lvPlantenInBestelling.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPlantenInBestelling_MouseDoubleClick);
			// 
			// chPlant
			// 
			this.chPlant.Text = "Plant";
			this.chPlant.Width = 120;
			// 
			// chAantalBesteld
			// 
			this.chAantalBesteld.Text = "Aantal";
			// 
			// chAantelGeleverd
			// 
			this.chAantelGeleverd.Text = "Aantal geleverd";
			this.chAantelGeleverd.Width = 91;
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
			this.chGrootte.Width = 65;
			// 
			// chJaren
			// 
			this.chJaren.Text = "Jaren";
			this.chJaren.Width = 80;
			// 
			// chOpmerking
			// 
			this.chOpmerking.Text = "Opmerking";
			this.chOpmerking.Width = 138;
			// 
			// gbLeveringen
			// 
			this.gbLeveringen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbLeveringen.Controls.Add(this.btnLeverbon);
			this.gbLeveringen.Controls.Add(this.btnLeverAlles);
			this.gbLeveringen.Controls.Add(this.lvLeveringen);
			this.gbLeveringen.Enabled = false;
			this.gbLeveringen.Location = new System.Drawing.Point(653, 19);
			this.gbLeveringen.Name = "gbLeveringen";
			this.gbLeveringen.Size = new System.Drawing.Size(451, 248);
			this.gbLeveringen.TabIndex = 15;
			this.gbLeveringen.TabStop = false;
			this.gbLeveringen.Text = "Leveringen";
			// 
			// btnLeverbon
			// 
			this.btnLeverbon.Enabled = false;
			this.btnLeverbon.Location = new System.Drawing.Point(349, 19);
			this.btnLeverbon.Name = "btnLeverbon";
			this.btnLeverbon.Size = new System.Drawing.Size(96, 23);
			this.btnLeverbon.TabIndex = 15;
			this.btnLeverbon.Text = "Maak leverbon";
			this.btnLeverbon.UseVisualStyleBackColor = true;
			this.btnLeverbon.Click += new System.EventHandler(this.btnLeverbon_Click);
			// 
			// btnLeverAlles
			// 
			this.btnLeverAlles.Location = new System.Drawing.Point(6, 19);
			this.btnLeverAlles.Name = "btnLeverAlles";
			this.btnLeverAlles.Size = new System.Drawing.Size(75, 23);
			this.btnLeverAlles.TabIndex = 14;
			this.btnLeverAlles.Text = "Lever alles";
			this.btnLeverAlles.UseVisualStyleBackColor = true;
			this.btnLeverAlles.Click += new System.EventHandler(this.btnLeverAlles_Click);
			// 
			// lvLeveringen
			// 
			this.lvLeveringen.AllowColumnReorder = true;
			this.lvLeveringen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvLeveringen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPlantLever,
            this.chAantalGeleverd,
            this.chLeverdatum});
			this.lvLeveringen.FullRowSelect = true;
			this.lvLeveringen.Location = new System.Drawing.Point(6, 48);
			this.lvLeveringen.Name = "lvLeveringen";
			this.lvLeveringen.Size = new System.Drawing.Size(439, 194);
			this.lvLeveringen.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvLeveringen.TabIndex = 13;
			this.lvLeveringen.UseCompatibleStateImageBehavior = false;
			this.lvLeveringen.View = System.Windows.Forms.View.Details;
			this.lvLeveringen.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvLeveringen_ItemSelectionChanged);
			this.lvLeveringen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvLeveringen_MouseClick);
			// 
			// chPlantLever
			// 
			this.chPlantLever.Text = "Plant";
			this.chPlantLever.Width = 162;
			// 
			// chAantalGeleverd
			// 
			this.chAantalGeleverd.Text = "Aantal";
			this.chAantalGeleverd.Width = 90;
			// 
			// chLeverdatum
			// 
			this.chLeverdatum.Text = "Leverdatum";
			this.chLeverdatum.Width = 133;
			// 
			// cmsPlantenVoorBestelling
			// 
			this.cmsPlantenVoorBestelling.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMaakLevering,
            this.tsmiVerwijderUitBestelling});
			this.cmsPlantenVoorBestelling.Name = "cmsVoorraad";
			this.cmsPlantenVoorBestelling.Size = new System.Drawing.Size(207, 48);
			// 
			// tsmiMaakLevering
			// 
			this.tsmiMaakLevering.Name = "tsmiMaakLevering";
			this.tsmiMaakLevering.Size = new System.Drawing.Size(206, 22);
			this.tsmiMaakLevering.Text = "Maak levering aan";
			this.tsmiMaakLevering.Click += new System.EventHandler(this.tsmiMaakLevering_Click);
			// 
			// tsmiVerwijderUitBestelling
			// 
			this.tsmiVerwijderUitBestelling.Name = "tsmiVerwijderUitBestelling";
			this.tsmiVerwijderUitBestelling.Size = new System.Drawing.Size(206, 22);
			this.tsmiVerwijderUitBestelling.Text = "Verwijderen uit bestelling";
			this.tsmiVerwijderUitBestelling.Click += new System.EventHandler(this.tsmiVerwijderUitBestelling_Click);
			// 
			// cmsBestellingen
			// 
			this.cmsBestellingen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bewerkBestellingToolStripMenuItem});
			this.cmsBestellingen.Name = "cmsBestellingen";
			this.cmsBestellingen.Size = new System.Drawing.Size(167, 26);
			// 
			// bewerkBestellingToolStripMenuItem
			// 
			this.bewerkBestellingToolStripMenuItem.Name = "bewerkBestellingToolStripMenuItem";
			this.bewerkBestellingToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.bewerkBestellingToolStripMenuItem.Text = "Bewerk bestelling";
			this.bewerkBestellingToolStripMenuItem.Click += new System.EventHandler(this.bewerkBestellingToolStripMenuItem_Click);
			// 
			// cmsLeveringen
			// 
			this.cmsLeveringen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangeStatus,
            this.tsmiVerwijderLevering});
			this.cmsLeveringen.Name = "cmsBestellingen";
			this.cmsLeveringen.Size = new System.Drawing.Size(191, 48);
			// 
			// tsmiChangeStatus
			// 
			this.tsmiChangeStatus.Name = "tsmiChangeStatus";
			this.tsmiChangeStatus.Size = new System.Drawing.Size(190, 22);
			this.tsmiChangeStatus.Text = "Zet op status geleverd";
			this.tsmiChangeStatus.Click += new System.EventHandler(this.tsmiChangeStatus_Click);
			// 
			// tsmiVerwijderLevering
			// 
			this.tsmiVerwijderLevering.Name = "tsmiVerwijderLevering";
			this.tsmiVerwijderLevering.Size = new System.Drawing.Size(190, 22);
			this.tsmiVerwijderLevering.Text = "Verwijder levering";
			this.tsmiVerwijderLevering.Click += new System.EventHandler(this.tsmiVerwijderLevering_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 632);
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
			this.cmsPlantenVoorBestelling.ResumeLayout(false);
			this.cmsBestellingen.ResumeLayout(false);
			this.cmsLeveringen.ResumeLayout(false);
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
		private System.Windows.Forms.ColumnHeader chAantalBesteld;
		private System.Windows.Forms.ColumnHeader chPrijs;
		private System.Windows.Forms.ColumnHeader chOpmerking;
		private System.Windows.Forms.ListView lvLeveringen;
		private System.Windows.Forms.ColumnHeader chAantalGeleverd;
		private System.Windows.Forms.ColumnHeader chLeverdatum;
		private System.Windows.Forms.GroupBox gbLeveringen;
		private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bestellingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem klantToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem plantToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem voorraadToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip cmsPlantenVoorBestelling;
		private System.Windows.Forms.ToolStripMenuItem tsmiVerwijderUitBestelling;
		private System.Windows.Forms.ContextMenuStrip cmsBestellingen;
		private System.Windows.Forms.ToolStripMenuItem bewerkBestellingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiMaakLevering;
		private System.Windows.Forms.ColumnHeader chPlantLever;
		private System.Windows.Forms.ColumnHeader chAantelGeleverd;
		private System.Windows.Forms.Button btnLeverAlles;
		private System.Windows.Forms.ContextMenuStrip cmsLeveringen;
		private System.Windows.Forms.ToolStripMenuItem tsmiVerwijderLevering;
		private System.Windows.Forms.Button btnLeverbon;
		private System.Windows.Forms.ToolStripMenuItem tsmiChangeStatus;
	}
}

