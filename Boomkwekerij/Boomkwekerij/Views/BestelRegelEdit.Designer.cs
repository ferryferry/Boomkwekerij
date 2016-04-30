namespace Boomkwekerij.Views
{
	partial class BestelRegelEdit
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
			this.nudCenten = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nudEuro = new System.Windows.Forms.NumericUpDown();
			this.lblGeselecteerdePlant = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nudAantal = new System.Windows.Forms.NumericUpDown();
			this.btnBewerkBestelregel = new System.Windows.Forms.Button();
			this.epFields = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudCenten)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEuro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAantal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epFields)).BeginInit();
			this.SuspendLayout();
			// 
			// nudCenten
			// 
			this.nudCenten.Location = new System.Drawing.Point(230, 55);
			this.nudCenten.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.nudCenten.Name = "nudCenten";
			this.nudCenten.Size = new System.Drawing.Size(50, 20);
			this.nudCenten.TabIndex = 27;
			this.nudCenten.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(205, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(10, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = ",";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "Prjis per plant: €:";
			// 
			// nudEuro
			// 
			this.nudEuro.Location = new System.Drawing.Point(149, 55);
			this.nudEuro.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.nudEuro.Name = "nudEuro";
			this.nudEuro.Size = new System.Drawing.Size(50, 20);
			this.nudEuro.TabIndex = 25;
			this.nudEuro.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
			// 
			// lblGeselecteerdePlant
			// 
			this.lblGeselecteerdePlant.AutoSize = true;
			this.lblGeselecteerdePlant.Location = new System.Drawing.Point(12, 9);
			this.lblGeselecteerdePlant.Name = "lblGeselecteerdePlant";
			this.lblGeselecteerdePlant.Size = new System.Drawing.Size(268, 13);
			this.lblGeselecteerdePlant.TabIndex = 21;
			this.lblGeselecteerdePlant.Text = "Selecteer een plant om toe te voegen aan de bestelling";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 23;
			this.label4.Text = "Aantal:";
			// 
			// nudAantal
			// 
			this.nudAantal.Location = new System.Drawing.Point(149, 29);
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
			// btnBewerkBestelregel
			// 
			this.btnBewerkBestelregel.Location = new System.Drawing.Point(218, 81);
			this.btnBewerkBestelregel.Name = "btnBewerkBestelregel";
			this.btnBewerkBestelregel.Size = new System.Drawing.Size(62, 23);
			this.btnBewerkBestelregel.TabIndex = 24;
			this.btnBewerkBestelregel.Text = "Opslaan";
			this.btnBewerkBestelregel.UseVisualStyleBackColor = true;
			this.btnBewerkBestelregel.Click += new System.EventHandler(this.btnBewerkBestelregel_Click);
			// 
			// epFields
			// 
			this.epFields.ContainerControl = this;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(15, 81);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(62, 23);
			this.btnCancel.TabIndex = 28;
			this.btnCancel.Text = "Annuleer";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// BestelRegelEdit
			// 
			this.AcceptButton = this.btnBewerkBestelregel;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(295, 116);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnBewerkBestelregel);
			this.Controls.Add(this.nudEuro);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nudCenten);
			this.Controls.Add(this.lblGeselecteerdePlant);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nudAantal);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "BestelRegelEdit";
			this.Text = "Bewerk bestelregel";
			this.Load += new System.EventHandler(this.BestelRegelEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudCenten)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEuro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAantal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epFields)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudCenten;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudEuro;
		private System.Windows.Forms.Label lblGeselecteerdePlant;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudAantal;
		private System.Windows.Forms.Button btnBewerkBestelregel;
		private System.Windows.Forms.ErrorProvider epFields;
		private System.Windows.Forms.Button btnCancel;
	}
}