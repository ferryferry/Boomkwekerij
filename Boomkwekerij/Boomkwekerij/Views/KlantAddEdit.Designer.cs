namespace Boomkwekerij.Views
{
	partial class KlantAddEdit
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
			this.btnSave = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtTelefoonnummer = new System.Windows.Forms.TextBox();
			this.txtWoonplaats = new System.Windows.Forms.TextBox();
			this.txtPostcode = new System.Windows.Forms.TextBox();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNaam = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.epFields = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.epFields)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(215, 188);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(93, 23);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "Opslaan";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Email:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Telefoonnummer:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "Woonplaats:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 23;
			this.label3.Text = "Postcode:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 19;
			this.label2.Text = "Adres:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(116, 142);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(192, 20);
			this.txtEmail.TabIndex = 18;
			this.txtEmail.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// txtTelefoonnummer
			// 
			this.txtTelefoonnummer.Location = new System.Drawing.Point(116, 116);
			this.txtTelefoonnummer.Name = "txtTelefoonnummer";
			this.txtTelefoonnummer.Size = new System.Drawing.Size(192, 20);
			this.txtTelefoonnummer.TabIndex = 17;
			this.txtTelefoonnummer.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// txtWoonplaats
			// 
			this.txtWoonplaats.Location = new System.Drawing.Point(116, 90);
			this.txtWoonplaats.Name = "txtWoonplaats";
			this.txtWoonplaats.Size = new System.Drawing.Size(192, 20);
			this.txtWoonplaats.TabIndex = 16;
			this.txtWoonplaats.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// txtPostcode
			// 
			this.txtPostcode.Location = new System.Drawing.Point(116, 64);
			this.txtPostcode.Name = "txtPostcode";
			this.txtPostcode.Size = new System.Drawing.Size(192, 20);
			this.txtPostcode.TabIndex = 15;
			this.txtPostcode.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// txtAdres
			// 
			this.txtAdres.Location = new System.Drawing.Point(116, 38);
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(192, 20);
			this.txtAdres.TabIndex = 14;
			this.txtAdres.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Naam:";
			// 
			// txtNaam
			// 
			this.txtNaam.Location = new System.Drawing.Point(116, 12);
			this.txtNaam.Name = "txtNaam";
			this.txtNaam.Size = new System.Drawing.Size(192, 20);
			this.txtNaam.TabIndex = 11;
			this.txtNaam.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(15, 188);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(93, 23);
			this.btnCancel.TabIndex = 24;
			this.btnCancel.Text = "Annuleer";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// epFields
			// 
			this.epFields.ContainerControl = this;
			// 
			// KlantAddEdit
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(343, 223);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtTelefoonnummer);
			this.Controls.Add(this.txtWoonplaats);
			this.Controls.Add(this.txtPostcode);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNaam);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "KlantAddEdit";
			this.Text = "Klant";
			this.Load += new System.EventHandler(this.KlantAddEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.epFields)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtTelefoonnummer;
		private System.Windows.Forms.TextBox txtWoonplaats;
		private System.Windows.Forms.TextBox txtPostcode;
		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNaam;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ErrorProvider epFields;
	}
}