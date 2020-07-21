using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Solucion.Negocio
{
    public class ReservaServicio
    {
        private ReservaMapper mapper;
        public ReservaServicio()
        {
            mapper = new ReservaMapper();
        }

        public List<Reserva> TraerReservas()
        {
            List<Reserva> result = mapper.TraerTodos();
            return result;
        }

        public int Agregar_Reserva(int idHabitacion, int idCliente, int cantidadhuespedes, DateTime fecha_ingreso, DateTime fecha_egreso)
        {
            Reserva reserva = new Reserva(idHabitacion, idCliente, cantidadhuespedes, fecha_ingreso, fecha_egreso);

            ResultadoTransaccion resultante = mapper.Insert(reserva);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);

        }
    }
}
