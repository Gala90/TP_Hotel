using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReservaAdapter
    {
        private int _idReserva;
        private string _apellido;
        private string _nombreHotel;
        private string _categoriaHabitacion;
        private int _cantidadHuespedes;
        private bool _cancelacion;
        private DateTime _fechaIngreso;
        private DateTime _fechaEgreso;


        public int idReserva { get => _idReserva; set => _idReserva = value; }

        public string Apellido { get => _apellido; set => _apellido = value; }

        public string NombreHotel { get => _nombreHotel; set => _nombreHotel = value; }

        public string CategoriaHabitacion { get => _categoriaHabitacion; set => _categoriaHabitacion = value; }

        public int CantidadHuespedes { get => _cantidadHuespedes; set => _cantidadHuespedes = value; }

        public bool Cancelacion { get => _cancelacion; set => _cancelacion = value; }

        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }

        public DateTime FechaEgreso { get => _fechaEgreso; set => _fechaEgreso = value; }


        public override string ToString()
        {

            return "ID Reserva: " + this._idReserva + " Cliente: " + this._apellido + " Hotel: " + this._nombreHotel + " Habitacion: " + this._categoriaHabitacion + " Huespedes: " + _cantidadHuespedes + " Check In: " + this._fechaIngreso.Day + "/" + this._fechaIngreso.Month + "/" + this._fechaIngreso.Year + " Check Out: " + this._fechaEgreso.Day + "/" + this._fechaEgreso.Month + "/" + this._fechaEgreso.Year;


        }


    }
}
