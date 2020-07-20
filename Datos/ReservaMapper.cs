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
            n.Add("FechaIngreso", p.fecha_ingreso.ToString());
            n.Add("FechaEgreso", p.fecha_egreso.ToString());

            return n;
        }

        public ResultadoTransaccion Insert(Reserva reservanueva)
        {
            NameValueCollection obj = ReverseMap(reservanueva);
            string resultadoPost = WebHelper.Post("/api/v1/hotel/Ventas/", obj);
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
