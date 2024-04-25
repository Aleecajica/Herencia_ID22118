using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia

  /*clase principal o clase papa que guarda los metodos de lectura de valores y almecenado de valor en variables */
//Nombre de la clase
class operacion
{
    // declarar de variables que usa la clase 
    // tipo de acceso  tipo dato         nombre de dato 
    protected            int         valor1;
    protected           int          valor2;
    protected           int         resultado;
}
/// <sumary>
/// punto de entrada principal para la aplicacion
///</sumary>
[STAThread]
public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
