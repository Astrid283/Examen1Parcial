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
    public partial class Form2 : Form
    {
        List<string> ListaProducto = new List<string>();
        List<decimal> ListaCantidad = new List<decimal>();
        List<decimal> ListaPrecios = new List<decimal>();
        public Form2()
        {
            InitializeComponent();
        }
        //Funcion asincrona para calcular el descuento y el total
        private async Task<decimal> TotalPagoAsync(decimal precio)
        {
            decimal Total = await Task.Run(() =>
            {
                decimal Total = 0;
                decimal Descuento = 0;

                //Sumamos los precios que estan dentro de la lista
                for (int i = 0; i < PrecioListBox.Items.Count; i++)
                {
                    Total += Convert.ToDecimal(PrecioListBox.Items[i]);
                }

                Descuento = Total * 15 / 100;
                return Total - Descuento;
            });
            return Total;
        }

        private async void TotalButton_Click(object sender, EventArgs e)
        {
            //Llamamos a la funcion asincrona
            decimal total = await TotalPagoAsync(Convert.ToDecimal(PrecioTextBox.Text));

            MessageBox.Show("El total es: " + total);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = ProductoTextBox.Text;
            decimal precio;
            precio = Convert.ToDecimal(PrecioTextBox.Text);

            //Acumulamos los nombres en la lista
            ListaProducto.Add(nombre);
            ProductoListBox.DataSource = null;
            ProductoListBox.DataSource = ListaProducto;

            //Acumulamos los precios en la lista
            ListaPrecios.Add(precio);
            PrecioListBox.DataSource = null;
            PrecioListBox.DataSource = ListaPrecios;
        }
    }
}
