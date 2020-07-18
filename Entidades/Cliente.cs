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
        private int _codigo;
        private DateTime _fechaAlta;
        private bool _activo;

        public Cliente(string nombre, string apellido, string direccion, string email, string telefono, int codigo, DateTime fechaAlta, bool activo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._direccion = direccion;
            this._email = email;
            this._telefono = telefono;
            this._codigo = codigo;
            this._fechaAlta = fechaAlta;
            this._activo = activo;

        }

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
        public int Codigo { get => _codigo; set => _codigo = value; }

        [DataMember]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        [DataMember]
        public bool Activo { get => _activo; set => _activo = value; }

        public override string ToString()
        {
            return string.Format("Cliente {0}, {1}", this._apellido, this._nombre);
        }
    }
}
