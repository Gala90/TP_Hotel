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
        private DateTime _fecha_ingreso;
        private DateTime _fecha_egreso;

        public Reserva (int idHabitacion, int idCliente, int cantidadhuespedes, DateTime fecha_ingreso, DateTime fecha_egreso)
        {
            this._idHabitacion = idHabitacion;
            this._idCliente = idCliente;
            this._cantidadhuespedes = cantidadhuespedes;
            this._fecha_ingreso = fecha_ingreso;
            this._fecha_egreso = fecha_egreso;

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
        public DateTime fecha_ingreso
        {
            get { return _fecha_ingreso; }

            set { this._fecha_ingreso = value; }
        }

        [DataMember]
        public DateTime fecha_egreso
        {
            get { return _fecha_egreso; }

            set { this._fecha_egreso = value; }
        }

        public override string ToString()
        {

            return "ID Reserva: "+ this._id + " Habitacion: " + this._idHabitacion + " Cliente: " + this._idCliente + " Huespedes: " + this._cantidadhuespedes ;               

        }


           

    }
}
