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
            ReservaServicio servicio = new ReservaServicio();

            listBox1.DataSource = servicio.TraerReservasAdapter();
        }

        private void BtnAltaReserva_Click(object sender, EventArgs e)
        {
            FrmAltaReserva f2 = new FrmAltaReserva();
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }

        private void btnModifReserva_Click(object sender, EventArgs e)
        {
            FrmModificarReserva f2 = new FrmModificarReserva();
            f2.Owner = this;
            f2.Show();
            this.Hide();

        }

        private void btnBajaReserva_Click(object sender, EventArgs e)
        {
            FrmBajaReserva f2 = new FrmBajaReserva();
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }
    }
}
