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
        private int _id;
        private int _idhotel;
        private string _categoria;
        private int _cantidadplazas;
        private bool _cancelable;
        private double _precio;


        public Habitacion(int idhotel, string categoria, int cantidadplazas, bool cancelable, double precio)
        {
            this._idhotel = idhotel;
            this._categoria = categoria;
            this._cantidadplazas = cantidadplazas;
            this._cancelable = cancelable;
            this._precio = precio;
        }

        [DataMember]
        public int id
        {
            get { return _id; }

            set { this._id = value; }
        }

        [DataMember]
        public int idhotel
        {
            get { return _idhotel; }

            set { this._idhotel = value; }
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
        public bool cancelable
        {
            get { return _cancelable; }

            set { this._cancelable = value; }
        }

        [DataMember]
        public double precio
        {
            get { return _precio; }

            set { this._precio = value; }
        }


        public override string ToString()
        {
            if (this._cancelable == true)
            {
                return "Id: " + this.id + " Hotel: " + this.idhotel + "  Categoria: " + this.categoria + " Cantidad: " + this.cantidadplazas + " reembolsable Precio: " + this.precio;
            }
            else
            {
                return "Id: " + this.id + " Hotel: " + this.idhotel + "  Categoria: " + this.categoria + " Cantidad: " + this.cantidadplazas + " no reembolsable Precio: " + this.precio;
            }
        }
    }
}
