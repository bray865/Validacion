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
            // Nivel de Estudios
            if (txtMatricula.Text[0] == '1')
                txtNivelEstudios.Text = "Licenciatura";
            if (txtMatricula.Text[0] == '2')
                txtNivelEstudios.Text = "Maestría";
            if (txtMatricula.Text[0] == '3')
                txtNivelEstudios.Text = "Doctorado";

            // Periodo de Ingreso
            if (txtMatricula.Text[1] == '1')
                txtPeriodoIngreso.Text = "Enero-Abril";
            if (txtMatricula.Text[1] == '2')
                txtPeriodoIngreso.Text = "Mayo-Agosto";
            if (txtMatricula.Text[1] == '3')
                txtPeriodoIngreso.Text = "Septiembre-Diciembre";

            // Año de Ingreso
            txtAñoIngreso.Text = "20" + txtMatricula.Text[2] + txtMatricula.Text[3];

            // Generación
            txtGeneracion.Text = "" + txtMatricula.Text[4] + txtMatricula.Text[5];

            // Carrera (dígito en la posición 6 indica la carrera)
            if (txtMatricula.Text[6] == '1')
                txtCarrera.Text = "Licenciatura en Ingeniería en Manufactura Avanzada";
            if (txtMatricula.Text[6] == '2')
                txtCarrera.Text = "Licenciatura en Ingeniería Financiera";
            if (txtMatricula.Text[6] == '3')
                txtCarrera.Text = "Licenciatura en Ingeniería en Tecnologías de la Información e Innovación Digital";
            if (txtMatricula.Text[6] == '4')
                txtCarrera.Text = "Licenciatura en Ingeniería Mecánica Automotriz";
            if (txtMatricula.Text[6] == '5')
                txtCarrera.Text = "Licenciatura en Comercio Internacional y Aduanas";

            // Número Consecutivo (últimos 3 dígitos de la matrícula)
            txtNumeroConsecutivo.Text = txtMatricula.Text.Substring(7, 3);
        }
    }
}
