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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            //Lllamamos a la funcion
            Multiplos();

        }
        //Funcion que calcule los multiplos y que devuelva el nombre/apellido
        private int Multiplos()
        {
            int numeros;
            //Mostrar los numeros del 0 al 100
            for (numeros = 1; numeros <= 100; numeros++)
            {
                //Imprimos los numeros 
                NumerosListBox.Items.Add(numeros);

                //Sacamos los multiplos del 3
                if (numeros % 3 == 0)
                {
                    //Mostramos el nombre si el numero es del 3
                    NumerosListBox.Items.Add("Astrid");
                }

                //Sacamos los multiplos del 5
                if (numeros % 5 == 0)
                {
                    //Mostramos el apellido si el numero es del 5
                    NumerosListBox.Items.Add("Diaz");
                }
            }
            return numeros;
        }

        private void NumerosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
