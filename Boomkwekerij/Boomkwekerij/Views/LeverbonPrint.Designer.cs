namespace Boomkwekerij.Views
{
	partial class LeverbonPrint
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnMaakLeverbon = new System.Windows.Forms.Button();
			this.cbDate = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Maak leverbon voor:";
			// 
			// btnMaakLeverbon
			// 
			this.btnMaakLeverbon.Location = new System.Drawing.Point(12, 82);
			this.btnMaakLeverbon.Name = "btnMaakLeverbon";
			this.btnMaakLeverbon.Size = new System.Drawing.Size(75, 23);
			this.btnMaakLeverbon.TabIndex = 2;
			this.btnMaakLeverbon.Text = "Maak bon";
			this.btnMaakLeverbon.UseVisualStyleBackColor = true;
			this.btnMaakLeverbon.Click += new System.EventHandler(this.btnMaakLeverbon_Click);
			// 
			// cbDate
			// 
			this.cbDate.FormattingEnabled = true;
			this.cbDate.Location = new System.Drawing.Point(12, 34);
			this.cbDate.Name = "cbDate";
			this.cbDate.Size = new System.Drawing.Size(260, 21);
			this.cbDate.TabIndex = 3;
			// 
			// LeverbonPrint
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 117);
			this.Controls.Add(this.cbDate);
			this.Controls.Add(this.btnMaakLeverbon);
			this.Controls.Add(this.label1);
			this.Name = "LeverbonPrint";
			this.Text = "LeverbonPrint";
			this.Load += new System.EventHandler(this.LeverbonPrint_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMaakLeverbon;
		private System.Windows.Forms.ComboBox cbDate;
	}
}