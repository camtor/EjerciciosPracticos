using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string seleccion;

            if (checkBox1.Checked == true)
            {
                contador++;

            }
            if (checkBox2.Checked == true)
            {
                contador++;
            }
            if (radioButton1.Checked == true)
            {
                seleccion = "Visa / Master Card";
            }
            else
            {
                seleccion = "Paypal";
            }

            MessageBox.Show("Haz seleccionado los siguientes productos:" + contador + " y el medio de pago es:"+ seleccion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 Ventana1 = new Form1();
            Ventana1.Show();
        }
    }
}
