using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _email;
        private string _telefono;
        private int _id;
        private DateTime _fechaAlta;
        private bool _activo;



        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember]
        public string Apellido { get => _apellido; set => _apellido = value; }

        [DataMember]
        public string Direccion { get => _direccion; set => _direccion = value; }

        [DataMember]
        public string Email { get => _email; set => _email = value; }

        [DataMember]
        public string Telefono { get => _telefono; set => _telefono = value; }

        [DataMember]
        public int Id { get => _id; set => _id = value; }

        [DataMember]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        [DataMember]
        public bool Activo { get => _activo; set => _activo = value; }

        public override string ToString()
        {
            return string.Format("Cliente {0}, {1}", this._apellido, this._nombre);
        }

        public string NombreCompleto
        {
            get
            {
                return string.Format(this._apellido +", " + this._nombre);
            }
        }
    }
}
