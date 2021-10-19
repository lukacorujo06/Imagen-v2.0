using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Imagen_v2._
{

	public partial class MainForm : Form
	{
		public string[] imagenes;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			imagenes = new string[5];
			string direccion  = "D:\\planetas\\";
			imagenes[0] = direccion + "MERCURIO.jpg";
			imagenes[1] = direccion + "VENUS.jpg";
			imagenes[2] = direccion + "TIERRA.jpg";
			imagenes[3] = direccion + "MARTE.jpg";
			imagenes[4] = direccion + "JUPITER.jpg";			
		}
		
		void Btn_mostrarClick(object sender, EventArgs e)
		{
			Random n = new Random();
			pic_imagen.Image = Image.FromFile(imagenes[n.Next(0,4)]);
		}
	}
}
