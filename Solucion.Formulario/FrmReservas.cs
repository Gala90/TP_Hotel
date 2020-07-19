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
    public partial class FrmReservas : Form
    {
        public FrmReservas()
        {
            InitializeComponent();
        }

        private void BtnVolverReserva_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            List<string> listareservas = new List<string>();

            ReservaServicio servicio = new ReservaServicio();

            List<Reserva> lst = servicio.TraerReservas();

            foreach (Reserva reserva in lst)
            {
                listareservas.Add(reserva.ToString());
            }

            listBox1.DataSource = listareservas;
        }
    }
}
