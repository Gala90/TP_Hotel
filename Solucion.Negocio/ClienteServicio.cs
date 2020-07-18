using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;


namespace Solucion.Negocio
{
    class ClienteServicio
    {
        private ClienteMapper mapper;
        public ClienteServicio()
        {
            mapper = new ClienteMapper();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> result = mapper.TraerTodos();
            return result;
        }

        public int Alta_Cliente(string nombre, string apellido, string direccion, string email, string telefono, DateTime fechaAlta, bool activo)
        {
            Cliente cliente = new Cliente();            
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Direccion = direccion;
            cliente.Email = email;
            cliente.Telefono = telefono;
            cliente.FechaAlta = fechaAlta;
            cliente.Activo = activo;

            ResultadoTransaccion resultante = mapper.Insert(cliente);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);

        }
    }
}
