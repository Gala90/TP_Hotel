using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solucion.Negocio;

namespace Solucion.Formulario
{
    public partial class FrmAltaHotel : Form
    {
        public FrmAltaHotel()
        {
            InitializeComponent();
        }

        private void FrmAltaHotel_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                HotelServicio servicio = new HotelServicio();

                if (checkBox1.Checked)
                {
                    servicio.Alta_Hotel(textBox1.Text.ToString(), textBox2.Text.ToString(), Convert.ToInt32(textBox3.Text), true);
                    MessageBox.Show("El Hotel " + textBox1.Text.ToString() + " ha sido agregado.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                    this.Owner.Refresh();
                }
                else
                {
                    servicio.Alta_Hotel(textBox1.Text.ToString(), textBox2.Text.ToString(), Convert.ToInt32(textBox3.Text), false);
                    MessageBox.Show("El Hotel " + textBox1.Text.ToString() + " ha sido agregado.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                    this.Owner.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnagregarhabitacion_Click(object sender, EventArgs e)
        {

        }
    }
}
