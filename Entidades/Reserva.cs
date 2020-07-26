using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Reserva
    {
        private int _id;
        private int _idHabitacion;
        private int _idCliente;
        private int _cantidadhuespedes;
        private DateTime _fechaingreso;
        private DateTime _fechaegreso;

        public Reserva (int idHabitacion, int idCliente, int cantidadhuespedes, DateTime fechaingreso, DateTime fechaegreso)
        {
            this._idHabitacion = idHabitacion;
            this._idCliente = idCliente;
            this._cantidadhuespedes = cantidadhuespedes;
            this._fechaingreso = fechaingreso;
            this._fechaegreso = fechaegreso;

        }

        [DataMember]
       public int id
        {
            get { return _id; }

            set { this._id = value; }
        }


        [DataMember]
        public int idHabitacion
        {
            get { return _idHabitacion; }

            set { this._idHabitacion = value; }
        }

        [DataMember]
        public int idCliente
        {
            get { return _idCliente; }

            set { this._idCliente = value; }
        }

        [DataMember]
        public int cantidadhuespedes
        {
            get { return _cantidadhuespedes; }

            set { this._cantidadhuespedes = value; }
        }

        [DataMember]
        public DateTime fechaingreso
        {
            get { return _fechaingreso; }

            set { this._fechaingreso = value; }
        }

        [DataMember]
        public DateTime fechaegreso
        {
            get { return _fechaegreso; }

            set { this._fechaegreso = value; }
        }

        public override string ToString()
        {

            return "ID Reserva: "+ this._id + " Habitacion: " + this._idHabitacion + " Cliente: " + this._idCliente + " Huespedes: " + this._cantidadhuespedes ;               

        }


           

    }
}
