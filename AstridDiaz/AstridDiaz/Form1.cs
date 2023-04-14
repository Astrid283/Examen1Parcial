using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstridDiaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InteresesButton_Click(object sender, EventArgs e)
        {
            //Lista de los meses con  sus respectivos calculos de los intereses
            InteresesListBox.Items.Add("Enero            " + InteresesEnero());
            InteresesListBox.Items.Add("Febrero         " + InteresesFebrero());
            InteresesListBox.Items.Add("Marzo           " + InteresesMarzo());
            InteresesListBox.Items.Add("Abril              " + InteresesAbril());
            InteresesListBox.Items.Add("Mayo            " + InteresesMayo());
            InteresesListBox.Items.Add("Junio             " + InteresesJunio());
            InteresesListBox.Items.Add("Julio               " + InteresesJulio());
            InteresesListBox.Items.Add("Agosto           " + InteresesAgosto());
            InteresesListBox.Items.Add("Septiembre    " + InteresesSeptiembre());
            InteresesListBox.Items.Add("Octubre          " + InteresesOctubre());
            InteresesListBox.Items.Add("Noviembre     " + InteresesNoviembre());
            InteresesListBox.Items.Add("Diciembre       " + InteresesDiciembre());
        }
        //Funcion que calcule los intereses mensuales
        private decimal InteresesEnero()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 1);

            return interesesMensual;
        }

        private decimal InteresesFebrero()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 2);

            return interesesMensual;
        }

        private decimal InteresesMarzo()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 3);

            return interesesMensual;
        }

        private decimal InteresesAbril()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 4);

            return interesesMensual;
        }

        private decimal InteresesMayo()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 5);

            return interesesMensual;
        }

        private decimal InteresesJunio()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 6);

            return interesesMensual;
        }

        private decimal InteresesJulio()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 7);

            return interesesMensual;
        }

        private decimal InteresesAgosto()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 8);

            return interesesMensual;
        }

        private decimal InteresesSeptiembre()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 9);

            return interesesMensual;
        }

        private decimal InteresesOctubre()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 10);

            return interesesMensual;
        }

        private decimal InteresesNoviembre()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 11);

            return interesesMensual;
        }

        private decimal InteresesDiciembre()
        {
            decimal interesesMensual = 0;

            //Formula para calcular el interes simple
            interesesMensual = (decimal)(200000 * 0.015 * 12);

            return interesesMensual;
        }
    }
}
