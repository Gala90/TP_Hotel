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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            List<string> listaclientes = new List<string>();
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            List<string> listaclientes = new List<string>();

            ClienteServicio servicio = new ClienteServicio();

            List<Cliente> lst = servicio.TraerClientes();

            foreach (Cliente cliente in lst)
            {
                listaclientes.Add(cliente.ToString());
            }

            listBox1.DataSource = listaclientes;
        }

        private void BtnVolverCliente_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void BtnAltaCliente_Click(object sender, EventArgs e)
        {
            FrmAltaCliente f2 = new FrmAltaCliente();
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }
    }
}
