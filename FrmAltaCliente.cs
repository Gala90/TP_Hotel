using Solucion.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Solucion.Formulario
{
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void TextNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Textemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try 
            { 
            ClienteServicio servicio = new ClienteServicio();
            servicio.Alta_Cliente(textNombre.Text.ToString(), textApellido.Text.ToString(), textDireccion.Text.ToString(), textemail.Text.ToString(), textTelefono.Text.ToString(), DateTime.Today, true);
                MessageBox.Show("El cliente ha sido agregado con exito");
                textNombre.Clear();
                textApellido.Clear();
                textemail.Clear();
                textTelefono.Clear();
                textDireccion.Clear();

                this.Owner.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Owner.Show();
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textNombre.Clear();
            textApellido.Clear();
            textemail.Clear();
            textTelefono.Clear();
            textDireccion.Clear();

        }
    }
}
