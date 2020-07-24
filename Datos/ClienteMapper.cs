using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/cliente/" + ConfigurationManager.AppSettings["Legajo"]);
            List<Cliente> resultado = MapList(json);
            return resultado;
        }
        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }

        public ResultadoTransaccion Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string result = WebHelper.Post("/api/v1/cliente", obj);
            ResultadoTransaccion resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }


        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);        
            n.Add("Email", cliente.Email);
            n.Add("Telefono", cliente.Telefono);
            n.Add("FechaAlta", cliente.FechaAlta.ToString());           
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("id", cliente.Id.ToString());
            return n;
        }

        private ResultadoTransaccion MapResultado(string json)
        {
            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            return lst;
        }
    }
}
