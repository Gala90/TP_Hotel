﻿using Entidades;
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
                    textBox1.Text = Hotel.nombre;
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
            
            textCantidad.Clear();
            textBox1.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;



        }



               private void btnaceptar_Click(object sender, EventArgs e)
               {
                try
               {
                     HabitacionServicio serviciohabitacion = new HabitacionServicio();
                     HotelServicio serviciohotel = new HotelServicio();
                     ReservaServicio servicioreserva = new ReservaServicio();



                if (serviciohabitacion.validarDispo(Convert.ToInt32(comboBox1.Text), servicioreserva, serviciohabitacion, serviciohotel))
                {

                    ReservaServicio servicio = new ReservaServicio();

                    servicio.Agregar_Reserva(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textCantidad.Text), Convert.ToDateTime(dateTimePicker1.Value), Convert.ToDateTime(dateTimePicker2.Value));
                    MessageBox.Show("La reserva ha sido creada con exito.");



                    this.Owner.Refresh();
                }

                else
                {
                    MessageBox.Show("La habitacion seleccionada no se encuentra disponible.");
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
    }
}
