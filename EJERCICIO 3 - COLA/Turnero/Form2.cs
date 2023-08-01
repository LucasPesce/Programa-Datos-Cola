using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnero
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //INICIALIZAMOS el Labael con un cartel de Bienvenido
            lblApellidoNombre.Text = "Bienvenido";
        }
        public void LlamarPaciente(String nombre)
        {   
            //METODO que se se le asigna un STRING para mostrarlo por la ventana de este formulario.
            lblApellidoNombre.Text = nombre;
        }
    }
}
