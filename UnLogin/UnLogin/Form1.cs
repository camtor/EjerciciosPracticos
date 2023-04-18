using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // namespace especial

namespace UnLogin
{
    public partial class Form1 : Form // clase herencia
    {
        public Form1() // metodo constructor
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e) // metodo  por cada evento
        {
            if (Usuario.Text == "Administrador" && Password.Text == "Admin123")
            {
                // MessageBox.Show("A INGRESADO CORRECTAMENTE");
                this.Hide();
                Form2 Ventana2 = new Form2();
                Ventana2.Show();
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INVALIDOS INTENTE NUEVAMENTE");
                Usuario.Clear();
                Password.Clear();
                Usuario.Focus();
            }
        }

        private void Salir_Click(object sender, EventArgs e)// metodo  por cada evento
        {
            this.Close();
        }
    }
}
