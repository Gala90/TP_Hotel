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
    public partial class FrmHoteles : Form
    {
        public FrmHoteles()
        {
            InitializeComponent();
        }

        private void btnVolverHotel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FrmHoteles_Load(object sender, EventArgs e)
        {
            List<string> listaHoteles = new List<string>();

            HotelServicio servicio = new HotelServicio();

            List<Hotel> lst = servicio.TraerHoteles();

            foreach (Hotel Hotel in lst)
            {
                listaHoteles.Add(Hotel.ToString());
            }

            listBox1.DataSource = listaHoteles;
        }

        private void btnAltaHotel_Click(object sender, EventArgs e)
        {
            FrmAltaHotel f2 = new FrmAltaHotel();
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }
    }
}
