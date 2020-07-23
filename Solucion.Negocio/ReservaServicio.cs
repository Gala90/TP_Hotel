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

        public Reserva TraerReserva(int id)
        {
            Reserva reserva = null;

            foreach (Reserva r in mapper.TraerTodos())
            {
                if (r.id == id)
                {
                    reserva = r;
                    return reserva;
                }
            }
            return reserva;
        }



        public int Modificar_Reserva(int idReserva, int idHabitacion, int idCliente, int cantidadhuespedes, DateTime fecha_ingreso, DateTime fecha_egreso)
        {
            Reserva reserva = TraerReserva(idReserva);
             
            if (reserva != null)
            {
                reserva.idHabitacion = idHabitacion;
                reserva.idCliente = idCliente;
                reserva.cantidadhuespedes = cantidadhuespedes;
                reserva.fecha_ingreso = fecha_ingreso;
                reserva.fecha_egreso = fecha_egreso;
            }

            ResultadoTransaccion resultante = mapper.Update(reserva);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);

        }
    }
}
