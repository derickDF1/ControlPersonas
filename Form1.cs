using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonas
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona(); //Instanciar una clase, crear un objeto de esa clase.
        string Nombre;
        string Apellido;

        public Form1()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            persona.Dpi = TxtDpi.Text;
            persona.Nombre = txtNombre.Text;
            persona.Apellido = TxtApe.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            LblDpi.Text = persona.Dpi;
            LblNom.Text = persona.Nombre;
            LblApe.Text = persona.Apellido;
            LblFe.Text = persona.FechaNacimiento.ToShortDateString();
            labelEdad.Text = (persona.edad().ToString())+ " años";

            LblDpi.Visible = true;
            LblNom.Visible = true;
            LblApe.Visible = true;
            LblFe.Visible = true;
            labelEdad.Visible = true;
        }

        private void buttonInicialMayus_Click(object sender, EventArgs e)
        {
            persona.InicialMayus();
            LblNom.Text = persona.Nombre;
            LblApe.Text = persona.Apellido;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
