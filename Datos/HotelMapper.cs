using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class HotelMapper
    {
        public List<Hotel> TraerTodos()
        {
            string json = WebHelper.Get("api/v1/hotel/hoteles/");
            List<Hotel> resultadoMapeo = MapList(json);
            return resultadoMapeo;
        }

        private List<Hotel> MapList(string jsonDeserializar)
        {
            List<Hotel> listDeserealizada = JsonConvert.DeserializeObject<List<Hotel>>(jsonDeserializar);
            return listDeserealizada;
        }


        private NameValueCollection ReverseMap(Hotel p)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("nombre", p.nombre.ToString());
            n.Add("direccion", p.direccion.ToString());
            n.Add("estrellas", p.estrellas.ToString());
            n.Add("amenities", p.amenities.ToString());

            return n;
        }

        public ResultadoTransaccion Insert(Hotel hotelnuevo)
        {
            NameValueCollection obj = ReverseMap(hotelnuevo);
            string resultadoPost = WebHelper.Post("api/v1/hotel/hoteles/", obj);
            ResultadoTransaccion resultado = MapResultado(resultadoPost);
            return resultado;
        }

        private ResultadoTransaccion MapResultado(string resultado)
        {
            ResultadoTransaccion mapresult = JsonConvert.DeserializeObject<ResultadoTransaccion>(resultado);
            return mapresult;
        }
    }
}
