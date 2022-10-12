namespace Moanso_GitHub
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblSeguro = new System.Windows.Forms.Label();
            this.RbBásico = new System.Windows.Forms.RadioButton();
            this.RbTerceros = new System.Windows.Forms.RadioButton();
            this.RbTotal = new System.Windows.Forms.RadioButton();
            this.GbSeguro = new System.Windows.Forms.GroupBox();
            this.GbEquipamiento = new System.Windows.Forms.GroupBox();
            this.CbAudio = new System.Windows.Forms.CheckBox();
            this.CbAire = new System.Windows.Forms.CheckBox();
            this.LblEquipo = new System.Windows.Forms.Label();
            this.LblCosto = new System.Windows.Forms.Label();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.BtnCotizar = new System.Windows.Forms.Button();
            this.TxtCotizacion = new System.Windows.Forms.TextBox();
            this.GbSeguro.SuspendLayout();
            this.GbEquipamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(20, 35);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(67, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre edit:";
            this.LblNombre.Click += new System.EventHandler(this.LblNombre_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(80, 32);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(78, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // LblSeguro
            // 
            this.LblSeguro.AutoSize = true;
            this.LblSeguro.Location = new System.Drawing.Point(4, 25);
            this.LblSeguro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSeguro.Name = "LblSeguro";
            this.LblSeguro.Size = new System.Drawing.Size(41, 13);
            this.LblSeguro.TabIndex = 2;
            this.LblSeguro.Text = "Seguro";
            // 
            // RbBásico
            // 
            this.RbBásico.AutoSize = true;
            this.RbBásico.Checked = true;
            this.RbBásico.Location = new System.Drawing.Point(64, 35);
            this.RbBásico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbBásico.Name = "RbBásico";
            this.RbBásico.Size = new System.Drawing.Size(57, 17);
            this.RbBásico.TabIndex = 3;
            this.RbBásico.TabStop = true;
            this.RbBásico.Text = "Básico";
            this.RbBásico.UseVisualStyleBackColor = true;
            // 
            // RbTerceros
            // 
            this.RbTerceros.AutoSize = true;
            this.RbTerceros.Location = new System.Drawing.Point(64, 56);
            this.RbTerceros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbTerceros.Name = "RbTerceros";
            this.RbTerceros.Size = new System.Drawing.Size(77, 17);
            this.RbTerceros.TabIndex = 4;
            this.RbTerceros.Text = "A Terceros";
            this.RbTerceros.UseVisualStyleBackColor = true;
            // 
            // RbTotal
            // 
            this.RbTotal.AutoSize = true;
            this.RbTotal.Location = new System.Drawing.Point(64, 77);
            this.RbTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbTotal.Name = "RbTotal";
            this.RbTotal.Size = new System.Drawing.Size(49, 17);
            this.RbTotal.TabIndex = 5;
            this.RbTotal.Text = "Total";
            this.RbTotal.UseVisualStyleBackColor = true;
            // 
            // GbSeguro
            // 
            this.GbSeguro.Controls.Add(this.LblSeguro);
            this.GbSeguro.Controls.Add(this.RbTotal);
            this.GbSeguro.Controls.Add(this.RbBásico);
            this.GbSeguro.Controls.Add(this.RbTerceros);
            this.GbSeguro.Location = new System.Drawing.Point(22, 68);
            this.GbSeguro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbSeguro.Name = "GbSeguro";
            this.GbSeguro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbSeguro.Size = new System.Drawing.Size(175, 116);
            this.GbSeguro.TabIndex = 6;
            this.GbSeguro.TabStop = false;
            this.GbSeguro.Text = "Seguros a Seleccionar: ";
            // 
            // GbEquipamiento
            // 
            this.GbEquipamiento.Controls.Add(this.CbAudio);
            this.GbEquipamiento.Controls.Add(this.CbAire);
            this.GbEquipamiento.Controls.Add(this.LblEquipo);
            this.GbEquipamiento.Location = new System.Drawing.Point(208, 68);
            this.GbEquipamiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbEquipamiento.Name = "GbEquipamiento";
            this.GbEquipamiento.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbEquipamiento.Size = new System.Drawing.Size(182, 116);
            this.GbEquipamiento.TabIndex = 7;
            this.GbEquipamiento.TabStop = false;
            this.GbEquipamiento.Text = "Equipamiento";
            this.GbEquipamiento.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CbAudio
            // 
            this.CbAudio.AutoSize = true;
            this.CbAudio.Location = new System.Drawing.Point(54, 77);
            this.CbAudio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbAudio.Name = "CbAudio";
            this.CbAudio.Size = new System.Drawing.Size(108, 17);
            this.CbAudio.TabIndex = 2;
            this.CbAudio.Text = "Sistema de Audio";
            this.CbAudio.UseVisualStyleBackColor = true;
            // 
            // CbAire
            // 
            this.CbAire.AutoSize = true;
            this.CbAire.Location = new System.Drawing.Point(54, 49);
            this.CbAire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbAire.Name = "CbAire";
            this.CbAire.Size = new System.Drawing.Size(118, 17);
            this.CbAire.TabIndex = 1;
            this.CbAire.Text = "Aire Acondicionado";
            this.CbAire.UseVisualStyleBackColor = true;
            // 
            // LblEquipo
            // 
            this.LblEquipo.AutoSize = true;
            this.LblEquipo.Location = new System.Drawing.Point(4, 25);
            this.LblEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEquipo.Name = "LblEquipo";
            this.LblEquipo.Size = new System.Drawing.Size(46, 13);
            this.LblEquipo.TabIndex = 0;
            this.LblEquipo.Text = "Equipo: ";
            this.LblEquipo.Click += new System.EventHandler(this.LblEquipo_Click);
            // 
            // LblCosto
            // 
            this.LblCosto.AutoSize = true;
            this.LblCosto.Location = new System.Drawing.Point(20, 211);
            this.LblCosto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCosto.Name = "LblCosto";
            this.LblCosto.Size = new System.Drawing.Size(43, 13);
            this.LblCosto.TabIndex = 8;
            this.LblCosto.Text = "Costo : ";
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(80, 211);
            this.TxtCosto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(78, 20);
            this.TxtCosto.TabIndex = 9;
            this.TxtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCotizar
            // 
            this.BtnCotizar.Location = new System.Drawing.Point(208, 211);
            this.BtnCotizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCotizar.Name = "BtnCotizar";
            this.BtnCotizar.Size = new System.Drawing.Size(74, 20);
            this.BtnCotizar.TabIndex = 10;
            this.BtnCotizar.Text = "Cotizar";
            this.BtnCotizar.UseVisualStyleBackColor = true;
            this.BtnCotizar.Click += new System.EventHandler(this.BtnCotizar_Click);
            // 
            // TxtCotizacion
            // 
            this.TxtCotizacion.Location = new System.Drawing.Point(22, 249);
            this.TxtCotizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCotizacion.Multiline = true;
            this.TxtCotizacion.Name = "TxtCotizacion";
            this.TxtCotizacion.Size = new System.Drawing.Size(369, 196);
            this.TxtCotizacion.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 506);
            this.Controls.Add(this.TxtCotizacion);
            this.Controls.Add(this.BtnCotizar);
            this.Controls.Add(this.TxtCosto);
            this.Controls.Add(this.LblCosto);
            this.Controls.Add(this.GbEquipamiento);
            this.Controls.Add(this.GbSeguro);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbSeguro.ResumeLayout(false);
            this.GbSeguro.PerformLayout();
            this.GbEquipamiento.ResumeLayout(false);
            this.GbEquipamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblNombre;
		private System.Windows.Forms.TextBox TxtNombre;
		private System.Windows.Forms.Label LblSeguro;
		private System.Windows.Forms.RadioButton RbBásico;
		private System.Windows.Forms.RadioButton RbTerceros;
		private System.Windows.Forms.RadioButton RbTotal;
		private System.Windows.Forms.GroupBox GbSeguro;
		private System.Windows.Forms.GroupBox GbEquipamiento;
		private System.Windows.Forms.Label LblEquipo;
		private System.Windows.Forms.CheckBox CbAudio;
		private System.Windows.Forms.CheckBox CbAire;
		private System.Windows.Forms.Label LblCosto;
		private System.Windows.Forms.TextBox TxtCosto;
		private System.Windows.Forms.Button BtnCotizar;
		private System.Windows.Forms.TextBox TxtCotizacion;
	}
}

