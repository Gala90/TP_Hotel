using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Hotel
    {
        private int _id;
        private string _nombre;
        private string _direccion;
        private int _estrellas;
        private bool _amenities;

        public Hotel (string nombre, string direccion, int estrellas, bool amenities)
        {
            this._nombre = nombre;
            this._direccion = direccion;
            this._estrellas = estrellas;
            this._amenities = amenities;

        }

        [DataMember]
        public int id
        {
            get { return this._id; }

            set { this._id = value; }
        }

        [DataMember]
        public string nombre
        {
            get { return this._nombre; }

            set { this._nombre = value; }
        }

        [DataMember]
        public string direccion
        {
            get { return this._direccion; }

            set { this._direccion = value; }
        }

        [DataMember]
        public int estrellas
        {
            get { return this._estrellas; }

            set { this._estrellas = value; }
        }

        [DataMember]
        public bool amenities
        {
            get { return this._amenities; }

            set { this._amenities = value; }
        }

        public override string ToString()
        {
            if (this._amenities == true)
            {
                return "Id: " + id +  " Hotel " + this._nombre + "  Direccion: " + this.direccion + " " + this._estrellas + " estrellas Con amenities";
            }
            else
            {
                return "Id: " + id + " Hotel " + this._nombre + " Direccion: " + this.direccion + " " + this._estrellas + " estrellas Sin amenities";
            }
        }
    }
}
