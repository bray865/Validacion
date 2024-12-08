using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidarMatricula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text[0] == '1')
                txtNivelEstudios.Text = "Licenciatura";
            if (txtMatricula.Text[0] == '2')
                txtNivelEstudios.Text = "Maestria";
            if (txtMatricula.Text[0] == '3')
                txtNivelEstudios.Text = "Doctorado";
            if (txtMatricula.Text[1] == '1')
                txtPeriodoIngreso.Text = "Enero-Abril";
            if (txtMatricula.Text[1] == '2')
                txtPeriodoIngreso.Text = "Mayo-Agosto";
            if (txtMatricula.Text[1] == '3')
                txtPeriodoIngreso.Text = "Septiembre-Diciembre";
            txtAñoIngreso.Text = "20" + txtMatricula.Text[2] + txtMatricula.Text[3];
            txtGeneracion.Text = ""+ txtMatricula.Text[4] + txtMatricula.Text[5];

           
        }
    }
}
