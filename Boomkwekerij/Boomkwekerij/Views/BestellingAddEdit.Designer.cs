namespace Boomkwekerij.Views
{
	partial class BestellingAddEdit
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
			this.label1 = new System.Windows.Forms.Label();
			this.cbKlant = new System.Windows.Forms.ComboBox();
			this.lvPlantenInVoorraad = new System.Windows.Forms.ListView();
			this.chAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chPlant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chLengte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chLeeftijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chOpmerking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnPlaatsBestelling = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cmsPlantenVoorBestelling = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toevoegenAanBestellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblGeselecteerdePlant = new System.Windows.Forms.Label();
			this.nudAantal = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.btnToevoegenAanBestelling = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gbOrderLine = new System.Windows.Forms.GroupBox();
			this.nudCenten = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nudEuro = new System.Windows.Forms.NumericUpDown();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lvPlantenInBestelling = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.epFields = new System.Windows.Forms.ErrorProvider(this.components);
			this.lblTotaalExInfo = new System.Windows.Forms.Label();
			this.lblToeslagPercentageInfo = new System.Windows.Forms.Label();
			this.lblTotaalprijsInfo = new System.Windows.Forms.Label();
			this.lblTotaalEx = new System.Windows.Forms.Label();
			this.lblToeslagPercentage = new System.Windows.Forms.Label();
			this.lblTotaalprijs = new System.Windows.Forms.Label();
			this.cmsPlantenVoorBestelling.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAantal)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.gbOrderLine.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCenten)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEuro)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.epFields)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nieuwe bestelling voor:";
			// 
			// cbKlant
			// 
			this.cbKlant.FormattingEnabled = true;
			this.cbKlant.Location = new System.Drawing.Point(135, 12);
			this.cbKlant.Name = "cbKlant";
			this.cbKlant.Size = new System.Drawing.Size(350, 21);
			this.cbKlant.TabIndex = 1;
			this.cbKlant.SelectedIndexChanged += new System.EventHandler(this.nud_ValueChanged);
			// 
			// lvPlantenInVoorraad
			// 
			this.lvPlantenInVoorraad.AllowColumnReorder = true;
			this.lvPlantenInVoorraad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvPlantenInVoorraad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAantal,
            this.chPlant,
            this.chLengte,
            this.chLeeftijd,
            this.chOpmerking});
			this.lvPlantenInVoorraad.FullRowSelect = true;
			this.lvPlantenInVoorraad.Location = new System.Drawing.Point(5, 19);
			this.lvPlantenInVoorraad.Name = "lvPlantenInVoorraad";
			this.lvPlantenInVoorraad.Size = new System.Drawing.Size(492, 166);
			this.lvPlantenInVoorraad.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvPlantenInVoorraad.TabIndex = 16;
			this.lvPlantenInVoorraad.UseCompatibleStateImageBehavior = false;
			this.lvPlantenInVoorraad.View = System.Windows.Forms.View.Details;
			this.lvPlantenInVoorraad.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvPlantenInVoorraad_ItemSelectionChanged);
			// 
			// chAantal
			// 
			this.chAantal.Text = "Aantal";
			// 
			// chPlant
			// 
			this.chPlant.Text = "Plant";
			this.chPlant.Width = 120;
			// 
			// chLengte
			// 
			this.chLengte.Text = "Lengte";
			this.chLengte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.chLengte.Width = 80;
			// 
			// chLeeftijd
			// 
			this.chLeeftijd.Text = "Leeftijd";
			this.chLeeftijd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.chLeeftijd.Width = 80;
			// 
			// chOpmerking
			// 
			this.chOpmerking.Text = "Opmerking";
			this.chOpmerking.Width = 145;
			// 
			// btnPlaatsBestelling
			// 
			this.btnPlaatsBestelling.Location = new System.Drawing.Point(405, 600);
			this.btnPlaatsBestelling.Name = "btnPlaatsBestelling";
			this.btnPlaatsBestelling.Size = new System.Drawing.Size(111, 23);
			this.btnPlaatsBestelling.TabIndex = 18;
			this.btnPlaatsBestelling.Text = "Bestelling plaatsen";
			this.btnPlaatsBestelling.UseVisualStyleBackColor = true;
			this.btnPlaatsBestelling.Click += new System.EventHandler(this.btnPlaatsBestelling_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(12, 600);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(111, 23);
			this.btnCancel.TabIndex = 19;
			this.btnCancel.Text = "Annuleer";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// cmsPlantenVoorBestelling
			// 
			this.cmsPlantenVoorBestelling.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toevoegenAanBestellingToolStripMenuItem});
			this.cmsPlantenVoorBestelling.Name = "cmsVoorraad";
			this.cmsPlantenVoorBestelling.Size = new System.Drawing.Size(207, 26);
			// 
			// toevoegenAanBestellingToolStripMenuItem
			// 
			this.toevoegenAanBestellingToolStripMenuItem.Name = "toevoegenAanBestellingToolStripMenuItem";
			this.toevoegenAanBestellingToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.toevoegenAanBestellingToolStripMenuItem.Text = "Verwijderen uit bestelling";
			// 
			// lblGeselecteerdePlant
			// 
			this.lblGeselecteerdePlant.AutoSize = true;
			this.lblGeselecteerdePlant.Location = new System.Drawing.Point(9, 21);
			this.lblGeselecteerdePlant.Name = "lblGeselecteerdePlant";
			this.lblGeselecteerdePlant.Size = new System.Drawing.Size(268, 13);
			this.lblGeselecteerdePlant.TabIndex = 21;
			this.lblGeselecteerdePlant.Text = "Selecteer een plant om toe te voegen aan de bestelling";
			// 
			// nudAantal
			// 
			this.nudAantal.Location = new System.Drawing.Point(55, 42);
			this.nudAantal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.nudAantal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudAantal.Name = "nudAantal";
			this.nudAantal.Size = new System.Drawing.Size(131, 20);
			this.nudAantal.TabIndex = 22;
			this.nudAantal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudAantal.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 23;
			this.label4.Text = "Aantal:";
			// 
			// btnToevoegenAanBestelling
			// 
			this.btnToevoegenAanBestelling.Location = new System.Drawing.Point(429, 39);
			this.btnToevoegenAanBestelling.Name = "btnToevoegenAanBestelling";
			this.btnToevoegenAanBestelling.Size = new System.Drawing.Size(62, 23);
			this.btnToevoegenAanBestelling.TabIndex = 24;
			this.btnToevoegenAanBestelling.Text = "Voeg toe";
			this.btnToevoegenAanBestelling.UseVisualStyleBackColor = true;
			this.btnToevoegenAanBestelling.Click += new System.EventHandler(this.btnToevoegenAanBestelling_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lvPlantenInVoorraad);
			this.groupBox1.Location = new System.Drawing.Point(12, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(504, 191);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Planten in voorraad";
			// 
			// gbOrderLine
			// 
			this.gbOrderLine.Controls.Add(this.nudCenten);
			this.gbOrderLine.Controls.Add(this.label5);
			this.gbOrderLine.Controls.Add(this.label3);
			this.gbOrderLine.Controls.Add(this.nudEuro);
			this.gbOrderLine.Controls.Add(this.lblGeselecteerdePlant);
			this.gbOrderLine.Controls.Add(this.label4);
			this.gbOrderLine.Controls.Add(this.nudAantal);
			this.gbOrderLine.Controls.Add(this.btnToevoegenAanBestelling);
			this.gbOrderLine.Enabled = false;
			this.gbOrderLine.Location = new System.Drawing.Point(12, 245);
			this.gbOrderLine.Name = "gbOrderLine";
			this.gbOrderLine.Size = new System.Drawing.Size(504, 80);
			this.gbOrderLine.TabIndex = 26;
			this.gbOrderLine.TabStop = false;
			this.gbOrderLine.Text = "Planten toevoegen aan de bestelling";
			// 
			// nudCenten
			// 
			this.nudCenten.Enabled = false;
			this.nudCenten.Location = new System.Drawing.Point(364, 42);
			this.nudCenten.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.nudCenten.Name = "nudCenten";
			this.nudCenten.Size = new System.Drawing.Size(59, 20);
			this.nudCenten.TabIndex = 27;
			this.nudCenten.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(348, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(10, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = ",";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(192, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "Prjis per plant: €:";
			// 
			// nudEuro
			// 
			this.nudEuro.Enabled = false;
			this.nudEuro.Location = new System.Drawing.Point(283, 42);
			this.nudEuro.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.nudEuro.Name = "nudEuro";
			this.nudEuro.Size = new System.Drawing.Size(59, 20);
			this.nudEuro.TabIndex = 25;
			this.nudEuro.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lvPlantenInBestelling);
			this.groupBox3.Location = new System.Drawing.Point(12, 331);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(504, 191);
			this.groupBox3.TabIndex = 27;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Planten in bestelling";
			// 
			// lvPlantenInBestelling
			// 
			this.lvPlantenInBestelling.AllowColumnReorder = true;
			this.lvPlantenInBestelling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvPlantenInBestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lvPlantenInBestelling.FullRowSelect = true;
			this.lvPlantenInBestelling.Location = new System.Drawing.Point(5, 19);
			this.lvPlantenInBestelling.Name = "lvPlantenInBestelling";
			this.lvPlantenInBestelling.Size = new System.Drawing.Size(493, 166);
			this.lvPlantenInBestelling.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvPlantenInBestelling.TabIndex = 17;
			this.lvPlantenInBestelling.UseCompatibleStateImageBehavior = false;
			this.lvPlantenInBestelling.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Aantal";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Plant";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Lengte";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 80;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Leeftijd";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 80;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Prijs per stuk";
			this.columnHeader5.Width = 73;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Subtotaal";
			this.columnHeader6.Width = 73;
			// 
			// epFields
			// 
			this.epFields.ContainerControl = this;
			// 
			// lblTotaalExInfo
			// 
			this.lblTotaalExInfo.AutoSize = true;
			this.lblTotaalExInfo.Location = new System.Drawing.Point(12, 535);
			this.lblTotaalExInfo.Name = "lblTotaalExInfo";
			this.lblTotaalExInfo.Size = new System.Drawing.Size(111, 13);
			this.lblTotaalExInfo.TabIndex = 28;
			this.lblTotaalExInfo.Text = "Totaalprijis ex toeslag:";
			// 
			// lblToeslagPercentageInfo
			// 
			this.lblToeslagPercentageInfo.AutoSize = true;
			this.lblToeslagPercentageInfo.Location = new System.Drawing.Point(12, 557);
			this.lblToeslagPercentageInfo.Name = "lblToeslagPercentageInfo";
			this.lblToeslagPercentageInfo.Size = new System.Drawing.Size(102, 13);
			this.lblToeslagPercentageInfo.TabIndex = 29;
			this.lblToeslagPercentageInfo.Text = "Toeslagpercentage:";
			// 
			// lblTotaalprijsInfo
			// 
			this.lblTotaalprijsInfo.AutoSize = true;
			this.lblTotaalprijsInfo.Location = new System.Drawing.Point(12, 580);
			this.lblTotaalprijsInfo.Name = "lblTotaalprijsInfo";
			this.lblTotaalprijsInfo.Size = new System.Drawing.Size(60, 13);
			this.lblTotaalprijsInfo.TabIndex = 30;
			this.lblTotaalprijsInfo.Text = "Totaalprijis:";
			// 
			// lblTotaalEx
			// 
			this.lblTotaalEx.AutoSize = true;
			this.lblTotaalEx.Location = new System.Drawing.Point(132, 535);
			this.lblTotaalEx.Name = "lblTotaalEx";
			this.lblTotaalEx.Size = new System.Drawing.Size(0, 13);
			this.lblTotaalEx.TabIndex = 31;
			// 
			// lblToeslagPercentage
			// 
			this.lblToeslagPercentage.AutoSize = true;
			this.lblToeslagPercentage.Location = new System.Drawing.Point(132, 557);
			this.lblToeslagPercentage.Name = "lblToeslagPercentage";
			this.lblToeslagPercentage.Size = new System.Drawing.Size(0, 13);
			this.lblToeslagPercentage.TabIndex = 32;
			// 
			// lblTotaalprijs
			// 
			this.lblTotaalprijs.AutoSize = true;
			this.lblTotaalprijs.Location = new System.Drawing.Point(132, 580);
			this.lblTotaalprijs.Name = "lblTotaalprijs";
			this.lblTotaalprijs.Size = new System.Drawing.Size(0, 13);
			this.lblTotaalprijs.TabIndex = 33;
			// 
			// BestellingAddEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(528, 635);
			this.Controls.Add(this.lblTotaalprijs);
			this.Controls.Add(this.lblToeslagPercentage);
			this.Controls.Add(this.lblTotaalEx);
			this.Controls.Add(this.lblTotaalprijsInfo);
			this.Controls.Add(this.lblToeslagPercentageInfo);
			this.Controls.Add(this.lblTotaalExInfo);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.gbOrderLine);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnPlaatsBestelling);
			this.Controls.Add(this.cbKlant);
			this.Controls.Add(this.label1);
			this.Name = "BestellingAddEdit";
			this.Text = "BestellingAddEdit";
			this.Load += new System.EventHandler(this.BestellingAddEdit_Load);
			this.cmsPlantenVoorBestelling.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudAantal)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.gbOrderLine.ResumeLayout(false);
			this.gbOrderLine.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCenten)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEuro)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.epFields)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbKlant;
		private System.Windows.Forms.ListView lvPlantenInVoorraad;
		private System.Windows.Forms.ColumnHeader chAantal;
		private System.Windows.Forms.ColumnHeader chPlant;
		private System.Windows.Forms.ColumnHeader chLengte;
		private System.Windows.Forms.Button btnPlaatsBestelling;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ContextMenuStrip cmsPlantenVoorBestelling;
		private System.Windows.Forms.ToolStripMenuItem toevoegenAanBestellingToolStripMenuItem;
		private System.Windows.Forms.Label lblGeselecteerdePlant;
		private System.Windows.Forms.NumericUpDown nudAantal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnToevoegenAanBestelling;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gbOrderLine;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ColumnHeader chLeeftijd;
		private System.Windows.Forms.ColumnHeader chOpmerking;
		private System.Windows.Forms.NumericUpDown nudCenten;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudEuro;
		private System.Windows.Forms.ListView lvPlantenInBestelling;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ErrorProvider epFields;
		private System.Windows.Forms.Label lblToeslagPercentageInfo;
		private System.Windows.Forms.Label lblTotaalExInfo;
		private System.Windows.Forms.Label lblTotaalprijsInfo;
		private System.Windows.Forms.Label lblTotaalEx;
		private System.Windows.Forms.Label lblTotaalprijs;
		private System.Windows.Forms.Label lblToeslagPercentage;
	}
}