﻿using Entidades;
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
    public class HabitacionMapper
    {
        public List<Habitacion> TraerTodos(int id)
        {
            string json = WebHelper.Get("/api/v1/Hotel/Habitaciones/" + id);
            List<Habitacion> resultadoMapeo = MapList(json);
            return resultadoMapeo;
        }

        private List<Habitacion> MapList(string jsonDeserializar)
        {
            List<Habitacion> listDeserealizada = JsonConvert.DeserializeObject<List<Habitacion>>(jsonDeserializar);
            return listDeserealizada;
        }


        private NameValueCollection ReverseMap(Habitacion p)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idHotel", p.idhotel.ToString());
            n.Add("categoria", p.categoria.ToString());
            n.Add("cantidadplazas", p.cantidadplazas.ToString());
            n.Add("Cancelable", p.cancelable.ToString());
            n.Add("precio", p.precio.ToString());
            n.Add("id", p.id.ToString());

            return n;
        }

        public ResultadoTransaccion Insert(Habitacion habitacionnueva)
        {
            NameValueCollection obj = ReverseMap(habitacionnueva);
            string resultadoPost = WebHelper.Post("/api/v1/hotel/habitaciones/", obj);
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

