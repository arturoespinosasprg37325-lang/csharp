/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC16
 * Fecha: 23/10/2026
 * Hora: 07:36 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace multiplica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double r= double.Parse (textBox1.Text) *double.Parse ( textBox2.Text );
			MessageBox.Show("Multiplicacion: " +r);
		}
	}
}
