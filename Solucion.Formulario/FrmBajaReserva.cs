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
    public partial class FrmBajaReserva : Form
    {
        public FrmBajaReserva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void FrmBajaReserva_Load(object sender, EventArgs e)
        {
            List<string> listaReservas = new List<string>();

            ReservaServicio servicio = new ReservaServicio();

            List<Reserva> lst = servicio.TraerReservas();

            foreach (Reserva res in lst)
            {
                listaReservas.Add(res.id.ToString());

            }

            comboID.DataSource = listaReservas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReservaServicio servicio = new ReservaServicio();

            if (servicio.TraerCancelacion(Convert.ToInt32(comboID.Text)))
            {
                servicio.Cancelar_Reserva(Convert.ToInt32(comboID.Text));
                MessageBox.Show("La reserva ha sido eliminada con exito.");
            }
            else
            {
                MessageBox.Show("La reserva no puede cancelarse, es no reembolsable.");
            }

        }

        private void comboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReservaServicio servicio = new ReservaServicio();

            List<Reserva> lst = servicio.TraerReservas();

            foreach (Reserva reserva in lst)
            {
                if (comboID.Text == reserva.id.ToString())
                {
                    textBox1.Text = reserva.ToString();
                }

            }
        }
    }
}
