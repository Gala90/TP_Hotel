using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Solucion.Negocio
{
    public class HabitacionServicio
    {
        private HabitacionMapper mapper;
        public HabitacionServicio()
        {
            mapper = new HabitacionMapper();
        }

        public List<Habitacion> TraerHabitaciones()
        {
            List<Habitacion> result = mapper.TraerTodos();
            return result;
        }

        public int Alta_Habitacion(int codigohotel, string categoria, int cantidadplazas, bool cancelacion, double precio)
        {
            Habitacion habitacion = new Habitacion(codigohotel, categoria, cantidadplazas, cancelacion, precio);

            ResultadoTransaccion resultante = mapper.Insert(habitacion);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);

        }
    }
}
