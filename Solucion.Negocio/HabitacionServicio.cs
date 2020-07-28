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

        public List<Habitacion> TraerHabitaciones(int id)
        {
            List<Habitacion> result = mapper.TraerTodos(id);
            return result;
        }

        public int Alta_Habitacion(int idhotel, string categoria, int cantidadplazas, bool cancelable, double precio)
        {
            Habitacion habitacion = new Habitacion(idhotel, categoria, cantidadplazas, cancelable, precio);

            ResultadoTransaccion resultante = mapper.Insert(habitacion);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);

        }

        public bool validarDispo(int id, ReservaServicio rs, HabitacionServicio hs, HotelServicio hts)
        {
            bool dispo = true;

            foreach (Hotel ht in hts.TraerHoteles())
            {
                foreach (Habitacion h in hs.TraerHabitaciones(ht.id))
                {
                    if (id == h.id)
                    {
                        int cant = h.cantidadplazas;

                        foreach (Reserva r in rs.TraerReservas())
                        {

                            if (r.idHabitacion == id)
                            {
                                cant--;
                                if (cant == 0)
                                {
                                    dispo = false;
                                }
                            }
                        }
                    }
                }
            }
            return dispo;
        }
    }
}
