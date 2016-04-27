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
			this.lvPlantenInBestelling = new System.Windows.Forms.ListView();
			this.chAantalGeleverd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chLeverdatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chLeverstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.lvPlantenInVoorraad = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.cmsVoorraad = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toevoegenAanBestellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblGeselecteerdePlant = new System.Windows.Forms.Label();
			this.nudAantal = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.btnToevoegenAanBestelling = new System.Windows.Forms.Button();
			this.cmsVoorraad.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAantal)).BeginInit();
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
			this.cbKlant.Location = new System.Drawing.Point(163, 12);
			this.cbKlant.Name = "cbKlant";
			this.cbKlant.Size = new System.Drawing.Size(206, 21);
			this.cbKlant.TabIndex = 1;
			// 
			// lvPlantenInBestelling
			// 
			this.lvPlantenInBestelling.AllowColumnReorder = true;
			this.lvPlantenInBestelling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvPlantenInBestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAantalGeleverd,
            this.chLeverdatum,
            this.chLeverstatus});
			this.lvPlantenInBestelling.FullRowSelect = true;
			this.lvPlantenInBestelling.Location = new System.Drawing.Point(12, 314);
			this.lvPlantenInBestelling.Name = "lvPlantenInBestelling";
			this.lvPlantenInBestelling.Size = new System.Drawing.Size(354, 169);
			this.lvPlantenInBestelling.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvPlantenInBestelling.TabIndex = 14;
			this.lvPlantenInBestelling.UseCompatibleStateImageBehavior = false;
			this.lvPlantenInBestelling.View = System.Windows.Forms.View.Details;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 298);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Planten in bestelling:";
			// 
			// lvPlantenInVoorraad
			// 
			this.lvPlantenInVoorraad.AllowColumnReorder = true;
			this.lvPlantenInVoorraad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvPlantenInVoorraad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvPlantenInVoorraad.FullRowSelect = true;
			this.lvPlantenInVoorraad.Location = new System.Drawing.Point(15, 70);
			this.lvPlantenInVoorraad.Name = "lvPlantenInVoorraad";
			this.lvPlantenInVoorraad.Size = new System.Drawing.Size(354, 169);
			this.lvPlantenInVoorraad.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvPlantenInVoorraad.TabIndex = 16;
			this.lvPlantenInVoorraad.UseCompatibleStateImageBehavior = false;
			this.lvPlantenInVoorraad.View = System.Windows.Forms.View.Details;
			this.lvPlantenInVoorraad.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvPlantenInVoorraad_ItemSelectionChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Aantal";
			this.columnHeader1.Width = 42;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Leverdatum";
			this.columnHeader2.Width = 68;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Afgeleverd";
			this.columnHeader3.Width = 292;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Planten in voorraad:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(258, 486);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Bestelling plaatsen";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 486);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(111, 23);
			this.button2.TabIndex = 19;
			this.button2.Text = "Annuleer";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// cmsVoorraad
			// 
			this.cmsVoorraad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toevoegenAanBestellingToolStripMenuItem});
			this.cmsVoorraad.Name = "cmsVoorraad";
			this.cmsVoorraad.Size = new System.Drawing.Size(209, 26);
			// 
			// toevoegenAanBestellingToolStripMenuItem
			// 
			this.toevoegenAanBestellingToolStripMenuItem.Name = "toevoegenAanBestellingToolStripMenuItem";
			this.toevoegenAanBestellingToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.toevoegenAanBestellingToolStripMenuItem.Text = "Toevoegen aan bestelling";
			// 
			// lblGeselecteerdePlant
			// 
			this.lblGeselecteerdePlant.AutoSize = true;
			this.lblGeselecteerdePlant.Location = new System.Drawing.Point(14, 242);
			this.lblGeselecteerdePlant.Name = "lblGeselecteerdePlant";
			this.lblGeselecteerdePlant.Size = new System.Drawing.Size(0, 13);
			this.lblGeselecteerdePlant.TabIndex = 21;
			// 
			// nudAantal
			// 
			this.nudAantal.Location = new System.Drawing.Point(60, 264);
			this.nudAantal.Name = "nudAantal";
			this.nudAantal.Size = new System.Drawing.Size(120, 20);
			this.nudAantal.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 266);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 23;
			this.label4.Text = "Aantal:";
			// 
			// btnToevoegenAanBestelling
			// 
			this.btnToevoegenAanBestelling.Location = new System.Drawing.Point(186, 263);
			this.btnToevoegenAanBestelling.Name = "btnToevoegenAanBestelling";
			this.btnToevoegenAanBestelling.Size = new System.Drawing.Size(73, 23);
			this.btnToevoegenAanBestelling.TabIndex = 24;
			this.btnToevoegenAanBestelling.Text = "Voeg toe";
			this.btnToevoegenAanBestelling.UseVisualStyleBackColor = true;
			this.btnToevoegenAanBestelling.Click += new System.EventHandler(this.btnToevoegenAanBestelling_Click);
			// 
			// BestellingAddEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 514);
			this.Controls.Add(this.btnToevoegenAanBestelling);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nudAantal);
			this.Controls.Add(this.lblGeselecteerdePlant);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lvPlantenInVoorraad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lvPlantenInBestelling);
			this.Controls.Add(this.cbKlant);
			this.Controls.Add(this.label1);
			this.Name = "BestellingAddEdit";
			this.Text = "BestellingAddEdit";
			this.Load += new System.EventHandler(this.BestellingAddEdit_Load);
			this.cmsVoorraad.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudAantal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbKlant;
		private System.Windows.Forms.ListView lvPlantenInBestelling;
		private System.Windows.Forms.ColumnHeader chAantalGeleverd;
		private System.Windows.Forms.ColumnHeader chLeverdatum;
		private System.Windows.Forms.ColumnHeader chLeverstatus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView lvPlantenInVoorraad;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ContextMenuStrip cmsVoorraad;
		private System.Windows.Forms.ToolStripMenuItem toevoegenAanBestellingToolStripMenuItem;
		private System.Windows.Forms.Label lblGeselecteerdePlant;
		private System.Windows.Forms.NumericUpDown nudAantal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnToevoegenAanBestelling;
	}
}