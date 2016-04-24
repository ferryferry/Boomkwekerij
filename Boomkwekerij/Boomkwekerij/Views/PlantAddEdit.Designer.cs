namespace Boomkwekerij.Views
{
	partial class PlantAddEdit
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNaam = new System.Windows.Forms.TextBox();
			this.epFields = new System.Windows.Forms.ErrorProvider(this.components);
			this.nudMinHoogte = new System.Windows.Forms.NumericUpDown();
			this.nudMaxHoogte = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.nudVerplant = new System.Windows.Forms.NumericUpDown();
			this.nudJaarling = new System.Windows.Forms.NumericUpDown();
			this.txtOpmerking = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.nudAantal = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.epFields)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinHoogte)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxHoogte)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVerplant)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudJaarling)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAantal)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(16, 182);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(93, 23);
			this.btnCancel.TabIndex = 38;
			this.btnCancel.Text = "Annuleer";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(216, 182);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(93, 23);
			this.btnSave.TabIndex = 26;
			this.btnSave.Text = "Opslaan";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 36;
			this.label4.Text = "Aantal:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 37;
			this.label3.Text = "Jaren:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 33;
			this.label2.Text = "Grootte:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "Naam:";
			// 
			// txtNaam
			// 
			this.txtNaam.Location = new System.Drawing.Point(117, 6);
			this.txtNaam.Name = "txtNaam";
			this.txtNaam.Size = new System.Drawing.Size(192, 20);
			this.txtNaam.TabIndex = 25;
			this.txtNaam.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// epFields
			// 
			this.epFields.ContainerControl = this;
			// 
			// nudMinHoogte
			// 
			this.nudMinHoogte.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudMinHoogte.Location = new System.Drawing.Point(117, 32);
			this.nudMinHoogte.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
			this.nudMinHoogte.Name = "nudMinHoogte";
			this.nudMinHoogte.Size = new System.Drawing.Size(73, 20);
			this.nudMinHoogte.TabIndex = 39;
			this.nudMinHoogte.ValueChanged += new System.EventHandler(this.txtField_TextChanged);
			this.nudMinHoogte.VisibleChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// nudMaxHoogte
			// 
			this.nudMaxHoogte.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudMaxHoogte.Location = new System.Drawing.Point(236, 32);
			this.nudMaxHoogte.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nudMaxHoogte.Name = "nudMaxHoogte";
			this.nudMaxHoogte.Size = new System.Drawing.Size(73, 20);
			this.nudMaxHoogte.TabIndex = 40;
			this.nudMaxHoogte.ValueChanged += new System.EventHandler(this.txtField_TextChanged);
			this.nudMaxHoogte.VisibleChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(208, 35);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(10, 13);
			this.label7.TabIndex = 41;
			this.label7.Text = "-";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(208, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(10, 13);
			this.label8.TabIndex = 44;
			this.label8.Text = "-";
			// 
			// nudVerplant
			// 
			this.nudVerplant.Location = new System.Drawing.Point(236, 59);
			this.nudVerplant.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudVerplant.Name = "nudVerplant";
			this.nudVerplant.Size = new System.Drawing.Size(73, 20);
			this.nudVerplant.TabIndex = 43;
			this.nudVerplant.ValueChanged += new System.EventHandler(this.txtField_TextChanged);
			this.nudVerplant.VisibleChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// nudJaarling
			// 
			this.nudJaarling.Location = new System.Drawing.Point(117, 59);
			this.nudJaarling.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudJaarling.Name = "nudJaarling";
			this.nudJaarling.Size = new System.Drawing.Size(73, 20);
			this.nudJaarling.TabIndex = 42;
			this.nudJaarling.ValueChanged += new System.EventHandler(this.txtField_TextChanged);
			this.nudJaarling.VisibleChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// txtOpmerking
			// 
			this.txtOpmerking.Location = new System.Drawing.Point(117, 110);
			this.txtOpmerking.Multiline = true;
			this.txtOpmerking.Name = "txtOpmerking";
			this.txtOpmerking.Size = new System.Drawing.Size(192, 46);
			this.txtOpmerking.TabIndex = 31;
			this.txtOpmerking.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 35;
			this.label5.Text = "Opmerking:";
			// 
			// nudAantal
			// 
			this.nudAantal.Location = new System.Drawing.Point(117, 84);
			this.nudAantal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.nudAantal.Name = "nudAantal";
			this.nudAantal.Size = new System.Drawing.Size(192, 20);
			this.nudAantal.TabIndex = 45;
			this.nudAantal.ValueChanged += new System.EventHandler(this.txtField_TextChanged);
			this.nudAantal.VisibleChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// PlantAddEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(344, 221);
			this.Controls.Add(this.nudAantal);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.nudVerplant);
			this.Controls.Add(this.nudJaarling);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.nudMaxHoogte);
			this.Controls.Add(this.nudMinHoogte);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtOpmerking);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNaam);
			this.Name = "PlantAddEdit";
			this.Text = "PlantAddEdit";
			this.Load += new System.EventHandler(this.PlantAddEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.epFields)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinHoogte)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxHoogte)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVerplant)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudJaarling)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAantal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNaam;
		private System.Windows.Forms.ErrorProvider epFields;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown nudVerplant;
		private System.Windows.Forms.NumericUpDown nudJaarling;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nudMaxHoogte;
		private System.Windows.Forms.NumericUpDown nudMinHoogte;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtOpmerking;
		private System.Windows.Forms.NumericUpDown nudAantal;
	}
}