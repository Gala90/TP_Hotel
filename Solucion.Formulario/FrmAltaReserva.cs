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
    public partial class FrmAltaReserva : Form
    {
        public FrmAltaReserva()
        {
            InitializeComponent();
        }

        private void FrmAltaReserva_Load(object sender, EventArgs e)
        {
            /*
            
            List<string> listaHoteles = new List<string>();

            HotelServicio servicio = new HotelServicio();

            List<Hotel> lst = servicio.TraerHoteles();

            foreach (Hotel Hotel in lst)
            {
                listaHoteles.Add(Hotel.id.ToString());
            }

            comboBox2.DataSource = listaHoteles;
            */

            HotelServicio servicio = new HotelServicio();
            List<Hotel> lst = servicio.TraerHoteles();

            comboBox2.DataSource = lst;
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "id";



            ClienteServicio serviciocliente = new ClienteServicio();
            List<Cliente> clientes = serviciocliente.TraerClientes();

            comboBox3.DataSource = clientes;
            comboBox3.DisplayMember = "NombreCompleto";
            comboBox3.ValueMember = "id";





        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Refresh();
            this.Owner.Show();
            this.Dispose();
        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            
            textCantidad.Clear();
            //textBox1.Clear();
            comboBox3.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;



        }



               private void btnaceptar_Click(object sender, EventArgs e)
               {
            try
            {
                HabitacionServicio serviciohabitacion = new HabitacionServicio();
                HotelServicio serviciohotel = new HotelServicio();
                ReservaServicio servicioreserva = new ReservaServicio();

                if (dateTimePicker1.Value > DateTime.Today && dateTimePicker2.Value > dateTimePicker1.Value)
                {

                    if (serviciohabitacion.validarDispo(Convert.ToInt32(comboBox1.Text), servicioreserva, serviciohabitacion, serviciohotel))
                    {

                        ReservaServicio servicio = new ReservaServicio();

                        servicio.Agregar_Reserva(Convert.ToInt32(comboBox1.Text.ToString()), Convert.ToInt32(comboBox3.SelectedValue.ToString()), Convert.ToInt32(textCantidad.Text), Convert.ToDateTime(dateTimePicker1.Value), Convert.ToDateTime(dateTimePicker2.Value));
                        MessageBox.Show("La reserva ha sido creada con exito.");



                        this.Owner.Refresh();
                    }

                    else
                    {
                        MessageBox.Show("La habitacion seleccionada no se encuentra disponible.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una fecha futura.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
               }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            HabitacionServicio serviciohabitacion = new HabitacionServicio();

            Hotel hotelseleccionado = (Hotel)comboBox2.SelectedItem;
            List<Habitacion> lsthab = serviciohabitacion.TraerHabitaciones(hotelseleccionado.id);

            comboBox1.DataSource = lsthab;
            comboBox1.DisplayMember = "id";

        }
    }
}
