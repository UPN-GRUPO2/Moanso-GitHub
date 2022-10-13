using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moanso_GitHub
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void LblEquipo_Click(object sender, EventArgs e)
		{

		}

		private void BtnCotizar_Click(object sender, EventArgs e)
		{
			double Costo = 0.0;
			string Cotizacion = "";

			Cotizacion = "Cotización de auto para : " + TxtNombre.Text + "\r\n";

			//Obtener costo inicial:
			
			Costo = Convert.ToDouble(TxtCosto.Text);

			//Verificación de Seguros: 
                        //probando
			if (RbBásico.Checked==true) {
				Costo = Costo + 600.00;
				Cotizacion += "Adquirió un seguro de $600 \r\n";
			}
			if (RbTerceros.Checked == true)
			{
				Costo += 800.00;
				Cotizacion += "Adquirió un seguro de $800 \r\n";
			}
			if (RbTotal.Checked == true)
			{
				Costo+= 1000.00;
				Cotizacion += "Adquirió un seguro de $1000 \r\n";
			}

			//Verificación de Equipamiento: 

			if (CbAire.Checked == true)
			{
				Costo += 600.00;
				Cotizacion += "Con aire acondicionado de $600 \r\n";
			}
			if (CbAudio.Checked == true)
			{
				Costo += 800.00;
				Cotizacion += "Más sistema de audio de $800 \r\n";
			}

			//Mostrar el Total: 

			Cotizacion += "El total a pagar es de: $" + Costo.ToString();
			TxtCotizacion.Text = Cotizacion;
		}

		private void LblNombre_Click(object sender, EventArgs e)
		{

		}
	}
}
