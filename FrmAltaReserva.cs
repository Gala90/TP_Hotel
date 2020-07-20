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

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
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

        //////////////////////////////////////////////////////////////////////
        ///Esta parte esta comentada porque falta agregar el id habitacion a la reserva

        //////////////////////////////////////////////////////////////////////

        /*       private void btnaceptar_Click(object sender, EventArgs e)
               {
                   try
                   {
                       ReservaServicio servicio = new ReservaServicio();

                       servicio.Agregar_Reserva(Convert.ToInt32(comboID.Text), Convert.ToInt32(textCantidad.Text), Convert.ToDateTime(dateTimePicker1.Value), Convert.ToDateTime(dateTimePicker2.Value);
                       MessageBox.Show("La reserva ha sigo agregada con exito.");

                   comboID.SelectedIndex = -1;
                   textCantidad.Clear();
                   comboBox1.SelectedIndex = -1;

                       this.Owner.Refresh();

                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message);
                   }
               }*/
    }
}
