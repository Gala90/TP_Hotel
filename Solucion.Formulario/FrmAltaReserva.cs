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
            List<string> listaHoteles = new List<string>();

            HotelServicio servicio = new HotelServicio();

            List<Hotel> lst = servicio.TraerHoteles();

            foreach (Hotel Hotel in lst)
            {
                listaHoteles.Add(Hotel.id.ToString());
            }

            comboID.DataSource = listaHoteles;


            List<string> listaclientes = new List<string>();

            ClienteServicio serviciocliente = new ClienteServicio();

            List<Cliente> lstcliente = serviciocliente.TraerClientes();

            foreach (Cliente cliente in lstcliente)
            {
                listaclientes.Add(cliente.Codigo.ToString());
            }

            comboBox2.DataSource = listaclientes;



        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboID_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Text = "";

            List<string> listaHoteles = new List<string>();

            HotelServicio servicio = new HotelServicio();

            List<Hotel> lst = servicio.TraerHoteles();

            foreach (Hotel Hotel in lst)
            {
                if (Hotel.id.ToString() == comboID.Text)
                    textBox1.Text = Hotel.ToString();
            }



            List<string> listaHabitaciones = new List<string>();

            HabitacionServicio serviciohabitacion = new HabitacionServicio();

            List<Habitacion> lsthab = serviciohabitacion.TraerHabitaciones(Convert.ToInt32(comboID.Text));

            foreach (Habitacion h in lsthab)
            {
                listaHabitaciones.Add(h.id.ToString());
            }

            comboBox1.DataSource = listaHabitaciones;
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
            comboID.SelectedIndex = -1;
            textCantidad.Clear();
            comboBox1.SelectedIndex = -1;



        }



               private void btnaceptar_Click(object sender, EventArgs e)
               {
                try
                   {
                       ReservaServicio servicio = new ReservaServicio();

                       servicio.Agregar_Reserva(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text), Convert.ToInt32(textCantidad.Text), Convert.ToDateTime(dateTimePicker1.Value), Convert.ToDateTime(dateTimePicker2.Value));
                       MessageBox.Show("La reserva ha sigo agregada con exito.");



                       this.Owner.Refresh();

                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message);
                   }
        
               }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox2.Text = "";

            List<string> listaclientes = new List<string>();

            ClienteServicio serviciocliente = new ClienteServicio();

            List<Cliente> lstcliente = serviciocliente.TraerClientes();

            foreach (Cliente cliente in lstcliente)
            {
                  if (cliente.Codigo.ToString() == comboBox2.Text)
                    textBox2.Text = cliente.ToString();
            }

 
        }

    }
}
