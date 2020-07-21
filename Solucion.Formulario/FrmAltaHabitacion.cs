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
using Entidades;

namespace Solucion.Formulario
{
    public partial class FrmAltaHabitacion : Form
    {
        public FrmAltaHabitacion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            textBox1.Clear();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            try
            {
                HabitacionServicio servicio = new HabitacionServicio();

                if (comboBox3.Text.ToUpper() == "Reembolsable")
                {
                    servicio.Alta_Habitacion(Convert.ToInt32(comboBox4.ValueMember), comboBox1.Text.ToString(), Convert.ToInt32(textBox2.Text),true, Convert.ToDouble(textBox1.Text));

                    MessageBox.Show("La Habitacion ha sigo agregada con exito.");
                    this.Owner.Refresh();

                    comboBox1.SelectedIndex = -1;
                    textBox2.Clear();
                    comboBox3.SelectedIndex = -1;
                    comboBox4.SelectedIndex = -1;
                    textBox1.Clear();
                }
                else
                {
                    servicio.Alta_Habitacion(Convert.ToInt32(comboBox4.Text), comboBox1.Text.ToString(), Convert.ToInt32(textBox2.Text), false, Convert.ToDouble(textBox1.Text));

                    MessageBox.Show("La Habitacion ha sigo agregada con exito.");
                    this.Owner.Refresh();

                    comboBox1.SelectedIndex = -1;
                    textBox2.Clear();
                    comboBox3.SelectedIndex = -1;
                    comboBox4.SelectedIndex = -1;
                    textBox1.Clear();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtidhabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaHabitacion_Load(object sender, EventArgs e)
        {
            /*  HotelServicio _servicioHotel = new HotelServicio();

              foreach (Hotel h in _servicioHotel.TraerHoteles())

              {
                  comboBox4.Items.Add(h.nombre);
                  comboBox4.ValueMember = h.id.ToString();
              }*/

            List<string> listaHoteles = new List<string>();

            HotelServicio servicio = new HotelServicio();

            List<Hotel> lst = servicio.TraerHoteles();

            foreach (Hotel Hotel in lst)
            {
                listaHoteles.Add(Hotel.id.ToString());
            }



            comboBox4.DataSource = listaHoteles;
        }
    }
}
