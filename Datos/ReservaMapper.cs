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
    public class ReservaMapper
    {

        public List<Reserva> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/hotel/Reservas/");
            List<Reserva> resultadoMapeo = MapList(json);
            return resultadoMapeo;
        }

        private List<Reserva> MapList(string jsonDeserializar)
        {
            List<Reserva> listDeserealizada = JsonConvert.DeserializeObject<List<Reserva>>(jsonDeserializar);
            return listDeserealizada;
        }

        private NameValueCollection ReverseMap(Reserva p)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idHabitacion", p.idHabitacion.ToString());
            n.Add("idCliente", p.idCliente.ToString());
            n.Add("CantidadHuespedes", p.cantidadhuespedes.ToString());
            n.Add("FechaIngreso", p.fechaingreso.ToString());
            n.Add("FechaEgreso", p.fechaegreso.ToString());
            n.Add("id", p.id.ToString());

            return n;
        }

        public ResultadoTransaccion Insert(Reserva reservanueva)
        {
            NameValueCollection obj = ReverseMap(reservanueva);
            string resultadoPost = WebHelper.Post("/api/v1/hotel/Reservas/", obj);
            ResultadoTransaccion resultado = MapResultado(resultadoPost);
            return resultado;
        }

        private ResultadoTransaccion MapResultado(string resultado)
        {
            ResultadoTransaccion mapresult = JsonConvert.DeserializeObject<ResultadoTransaccion>(resultado);
            return mapresult;
        }

        public ResultadoTransaccion Update(Reserva reserva)
        {
            NameValueCollection obj = ReverseMap(reserva);
            string resultadoPut = WebHelper.Put("/api/v1/Hotel/Reservas", obj);

            ResultadoTransaccion resultado = MapResultado(resultadoPut);

            return resultado;
        }

        public ResultadoTransaccion Delete(Reserva reserva)
        {
            NameValueCollection obj = new NameValueCollection();
            obj.Add("id", reserva.id.ToString());
            string result = WebHelper.Delete("/api/v1/Hotel/Reservas", obj);

            ResultadoTransaccion resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }



    }
}
