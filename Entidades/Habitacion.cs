using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Habitacion
    {
        private int _codigo;
        private int _codigohotel;
        private string _categoria;
        private int _cantidadplazas;
        private bool _cancelacion;
        private double _precio;


        public Habitacion(int codigohotel, string categoria, int cantidadplazas, bool cancelacion, double precio)
        {
            this._codigohotel = codigohotel;
            this._categoria = categoria;
            this._cantidadplazas = cantidadplazas;
            this._cancelacion = cancelacion;
            this._precio = precio;
        }

       [DataMember]
        public int codigo
        {
            get {return _codigo; }

            set { this._codigo = value; }
        }

        [DataMember]
        public int codigohotel
        {
            get { return _codigohotel; }

            set { this._codigohotel = value; }
        }

        [DataMember]
        public string categoria
        {
            get { return _categoria; }

            set { this._categoria = value; }
        }

        [DataMember]
        public int cantidadplazas
        {
            get { return _cantidadplazas; }

            set { this._cantidadplazas = value; }
        }

        [DataMember]
        public bool cancelacion
        {
            get { return _cancelacion; }

            set { this._cancelacion = value; }
        }

        [DataMember]
        public double precio
        {
            get { return _precio; }

            set { this._precio = value; }
        }
    }
}
