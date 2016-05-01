namespace Boomkwekerij.Views
{
	partial class LeveringAdd
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
			this.dtpLeverdatum = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nudAantal = new System.Windows.Forms.NumericUpDown();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.epFields = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.nudAantal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epFields)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpLeverdatum
			// 
			this.dtpLeverdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpLeverdatum.Location = new System.Drawing.Point(112, 12);
			this.dtpLeverdatum.Name = "dtpLeverdatum";
			this.dtpLeverdatum.Size = new System.Drawing.Size(160, 20);
			this.dtpLeverdatum.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Leverdatum:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Aantal geleverd:";
			// 
			// nudAantal
			// 
			this.nudAantal.Location = new System.Drawing.Point(112, 38);
			this.nudAantal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudAantal.Name = "nudAantal";
			this.nudAantal.Size = new System.Drawing.Size(160, 20);
			this.nudAantal.TabIndex = 3;
			this.nudAantal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(197, 72);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Opslaan";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(12, 72);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Annuleer";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// epFields
			// 
			this.epFields.ContainerControl = this;
			// 
			// LeveringAdd
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(284, 107);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.nudAantal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpLeverdatum);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LeveringAdd";
			this.Text = "Levering toevoegen";
			((System.ComponentModel.ISupportInitialize)(this.nudAantal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epFields)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpLeverdatum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudAantal;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ErrorProvider epFields;
	}
}