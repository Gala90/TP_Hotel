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
using Entidades;

namespace Solucion.Formulario
{
    public partial class FrmModificarReserva : Form
    {
        public FrmModificarReserva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Refresh();
            this.Owner.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
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

                    servicio.Modificar_Reserva(Convert.ToInt32(comboRes.Text), Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text), Convert.ToInt32(textCantidad.Text), Convert.ToDateTime(dateTimePicker1.Value), Convert.ToDateTime(dateTimePicker2.Value));
                    MessageBox.Show("La reserva ha sido modificada con exito.");



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

        private void button2_Click(object sender, EventArgs e)
        {
            textCantidad.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboRes.SelectedIndex = -1;
            comboID.SelectedIndex = -1;
        }

        private void FrmModificarReserva_Load(object sender, EventArgs e)
        {

            
            HotelServicio servicio = new HotelServicio();
            List<Hotel> lst = servicio.TraerHoteles();

            comboID.DataSource = lst;
            comboID.DisplayMember = "Nombre";
            comboID.ValueMember = "id";




            List<string> listaReservas = new List<string>();

            ReservaServicio servicio2 = new ReservaServicio();

            List<Reserva> lst2 = servicio2.TraerReservas();

            foreach (Reserva res in lst2)
            {
                listaReservas.Add(res.id.ToString());

            }

            comboRes.DataSource = listaReservas;


            ClienteServicio serviciocliente = new ClienteServicio();
            List<Cliente> clientes = serviciocliente.TraerClientes();

            comboBox2.DataSource = clientes;
            comboBox2.DisplayMember = "NombreCompleto";
            comboBox2.ValueMember = "id";






        }

        private void ComboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //List<string> listaHabitaciones = new List<string>();

            HabitacionServicio serviciohabitacion = new HabitacionServicio();

            List<Habitacion> lsthab = serviciohabitacion.TraerHabitaciones(Convert.ToInt32(comboID.ValueMember));

            /*
            foreach (Habitacion h in lsthab)
            {
                listaHabitaciones.Add(h.id.ToString());
            }

            */
            

            comboBox1.DataSource = lsthab;
            comboBox1.DisplayMember = "id";
            comboBox1.ValueMember = "id";

            

        }

        /*
        private void comboBox1_Load(object sender, EventArgs e)
        {
      myservice.Service test = new myservice.Service();
    DataSet dd = new DataSet();
    dd = test.Cmb_BranchMaster();
    comboBox1.DataSource = dd.Tables[0];
    comboBox1.DisplayMember = "BranchName";
    comboBox1.ValueMember = "BranchID";
        }
        */

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabitacionServicio serviciohabitacion = new HabitacionServicio();

            Hotel hotelseleccionado = (Hotel)comboID.SelectedItem;
            List<Habitacion> lsthab = serviciohabitacion.TraerHabitaciones(hotelseleccionado.id);

            comboBox1.DataSource = lsthab;
            comboBox1.DisplayMember = "id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
