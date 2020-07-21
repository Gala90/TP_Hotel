using Entidades;
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

namespace Solucion.Formulario
{
    public partial class FrmHabitaciones : Form
    {




        public FrmHabitaciones()
        {
            InitializeComponent();
        }




        private void btnVolverHotel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnAltaHotel_Click(object sender, EventArgs e)
        {
            FrmAltaHabitacion f2 = new FrmAltaHabitacion();
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }

        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            /*           HotelServicio _servicioHotel = new HotelServicio();

                        foreach (Hotel h in _servicioHotel.TraerHoteles())

                        {
                            comboBox1.Items.Add(h.nombre);
                            comboBox1.ValueMember = h.id.ToString();
                        }*/

            textBox1.Enabled = false;

            List<string> listaHoteles = new List<string>();

            HotelServicio servicio = new HotelServicio();

            List<Hotel> lst = servicio.TraerHoteles();

            foreach (Hotel Hotel in lst)
            {
                listaHoteles.Add(Hotel.id.ToString());
            }

            

            comboBox1.DataSource = listaHoteles;

        }

        /*
        Lista de habitacion



        */


        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          
                List<string> listaHoteles = new List<string>();

                HotelServicio servicio = new HotelServicio();

                List<Hotel> lst = servicio.TraerHoteles();

                foreach (Hotel Hotel in lst)
                {
                       if (comboBox1.Text == Hotel.id.ToString())
                {
                    textBox1.Text = Hotel.ToString();
                }

                }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> listaHabitaciones = new List<string>();

            HabitacionServicio servicio = new HabitacionServicio();

            List<Habitacion> lst = servicio.TraerHabitaciones(Convert.ToInt32(comboBox1.Text));

            foreach (Habitacion h in lst)
            {
                listaHabitaciones.Add(h.ToString());
            }

            listBox1.DataSource = listaHabitaciones;

        }
    }
}
