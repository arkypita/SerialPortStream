namespace TestForm
{
	partial class Form1
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.BtnOpen = new System.Windows.Forms.Button();
			this.BtnClose = new System.Windows.Forms.Button();
			this.TxtCom = new System.Windows.Forms.TextBox();
			this.TxtTX = new System.Windows.Forms.TextBox();
			this.BtnTX = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.TxtRX = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BtnOpen
			// 
			this.BtnOpen.Location = new System.Drawing.Point(174, 21);
			this.BtnOpen.Name = "BtnOpen";
			this.BtnOpen.Size = new System.Drawing.Size(63, 32);
			this.BtnOpen.TabIndex = 0;
			this.BtnOpen.Text = "OPEN";
			this.BtnOpen.UseVisualStyleBackColor = true;
			this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
			// 
			// BtnClose
			// 
			this.BtnClose.Location = new System.Drawing.Point(243, 21);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(63, 32);
			this.BtnClose.TabIndex = 1;
			this.BtnClose.Text = "CLOSE";
			this.BtnClose.UseVisualStyleBackColor = true;
			this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// TxtCom
			// 
			this.TxtCom.Location = new System.Drawing.Point(35, 28);
			this.TxtCom.Name = "TxtCom";
			this.TxtCom.Size = new System.Drawing.Size(106, 20);
			this.TxtCom.TabIndex = 2;
			// 
			// TxtTX
			// 
			this.TxtTX.Location = new System.Drawing.Point(36, 78);
			this.TxtTX.Name = "TxtTX";
			this.TxtTX.Size = new System.Drawing.Size(172, 20);
			this.TxtTX.TabIndex = 3;
			// 
			// BtnTX
			// 
			this.BtnTX.Location = new System.Drawing.Point(243, 71);
			this.BtnTX.Name = "BtnTX";
			this.BtnTX.Size = new System.Drawing.Size(63, 32);
			this.BtnTX.TabIndex = 4;
			this.BtnTX.Text = "TX";
			this.BtnTX.UseVisualStyleBackColor = true;
			this.BtnTX.Click += new System.EventHandler(this.BtnTX_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// TxtRX
			// 
			this.TxtRX.Location = new System.Drawing.Point(45, 215);
			this.TxtRX.Multiline = true;
			this.TxtRX.Name = "TxtRX";
			this.TxtRX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TxtRX.Size = new System.Drawing.Size(717, 203);
			this.TxtRX.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TxtRX);
			this.Controls.Add(this.BtnTX);
			this.Controls.Add(this.TxtTX);
			this.Controls.Add(this.TxtCom);
			this.Controls.Add(this.BtnClose);
			this.Controls.Add(this.BtnOpen);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnOpen;
		private System.Windows.Forms.Button BtnClose;
		private System.Windows.Forms.TextBox TxtCom;
		private System.Windows.Forms.TextBox TxtTX;
		private System.Windows.Forms.Button BtnTX;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox TxtRX;
	}
}

