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
        private int _nroreserva;
        private int _codigocliente;
        private int _codigohabitacion;
        private int _cantidadhuespedes;
        private DateTime _fecha_ingreso;
        private DateTime _fecha_egreso;

        public Reserva (int codigocliente, int codigohabitacion, int cantidadhuespedes, DateTime fecha_ingreso, DateTime fecha_egreso)
        {
            this._codigocliente = codigocliente;
            this._codigohabitacion = codigohabitacion;
            this._cantidadhuespedes = cantidadhuespedes;
            this._fecha_ingreso = fecha_ingreso;
            this._fecha_egreso = fecha_egreso;

        }

        [DataMember]
        public int nroreserva
        {
            get { return _nroreserva; }

            set { this._nroreserva = value; }
        }

        [DataMember]
        public int codigocliente
        {
            get { return _codigocliente; }

            set { this._codigocliente = value; }
        }

        [DataMember]
        public int codigohabitacion
        {
            get { return _codigohabitacion; }

            set { this._codigohabitacion = value; }
        }

        public int cantidadhuespedes
        {
            get { return _cantidadhuespedes; }

            set { this._cantidadhuespedes = value; }
        }

        public DateTime fecha_ingreso
        {
            get { return _fecha_ingreso; }

            set { this._fecha_ingreso = value; }
        }

        public DateTime fecha_egreso
        {
            get { return _fecha_egreso; }

            set { this._fecha_egreso = value; }
        }


    }
}
