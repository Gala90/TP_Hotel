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



                ResultadoTransaccion resultante = mapper.Update(reserva);

                if (resultante.IsOk)
                    return resultante.Id;
                else
                    throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);

            }

            else
            {
                throw new Exception("Reserva Inexistente");
            }

        }

        public int Cancelar_Reserva(int idReserva)
        {
            Reserva reserva = TraerReserva(idReserva);

            ResultadoTransaccion resultante = mapper.Delete(reserva);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);

        }

        public List<ReservaAdapter> TraerReservasAdapter()
        {
            List<Reserva> result = mapper.TraerTodos();
            List<ReservaAdapter> listaAdapter = new List<ReservaAdapter>();

            foreach (Reserva r in result)
            {
                ReservaAdapter ra = new ReservaAdapter();
                ra.idReserva = r.id;
                ra.Apellido = TraerApellido(r.idCliente);
                ra.NombreHotel = TraerHotel(r.idHabitacion);
                ra.CategoriaHabitacion = TraerCategoria(r.idHabitacion);
                ra.CantidadHuespedes = r.cantidadhuespedes;                
                //ra.FechaIngreso = r.fecha_ingreso;
                //ra.FechaEgreso = r.fecha_egreso;

                listaAdapter.Add(ra);
            }



            return listaAdapter;
        }


        public string TraerApellido(int id)
        {
            ClienteServicio clienteServicio = new ClienteServicio();
            string ape = null;

            foreach (Cliente c in clienteServicio.TraerClientes())
            {
                if (c.Id == id)
                {
                    ape = c.Apellido;
                    return ape;
                }
            }
            return ape;
        }

        public string TraerHotel(int id)
        {
            HotelServicio hotelServicio = new HotelServicio();
            HabitacionServicio habitacionServicio = new HabitacionServicio();

            string hotel = null;

            foreach (Hotel h in hotelServicio.TraerHoteles())
            {
                foreach (Habitacion ha in habitacionServicio.TraerHabitaciones(h.id))
                {
                    if (ha.id == id)
                    {
                        hotel = h.nombre;
                        return hotel;
                    }
                }
            }

            return hotel;
        }


        public int TraerHotelId(int id)
        {
            HotelServicio hotelServicio = new HotelServicio();
            HabitacionServicio habitacionServicio = new HabitacionServicio();

            int idhotel = 0;

            foreach (Hotel h in hotelServicio.TraerHoteles())
            {
                foreach (Habitacion ha in habitacionServicio.TraerHabitaciones(h.id))
                {
                    if (ha.id == id)
                    {
                        idhotel = h.id;
                        return idhotel;
                    }
                }
            }

            return idhotel;
        }



        
        public string TraerCategoria(int id)
        {
            HabitacionServicio habitacionServicio = new HabitacionServicio();
            string cat = null;
            int idHotel = TraerHotelId(id);

            foreach (Habitacion ha in habitacionServicio.TraerHabitaciones(idHotel))
            {
                if (ha.id == id)
                {
                    cat = ha.categoria;
                    return cat;
                }
            }
            return cat;
        }


        public bool TraerCancelacion(int id)
        {
            HabitacionServicio habitacionServicio = new HabitacionServicio();
            bool can = true;
            int idHotel = TraerHotelId(id);

            foreach (Habitacion ha in habitacionServicio.TraerHabitaciones(idHotel))
            {
                if (ha.id == id)
                {
                    can = ha.cancelacion;
                    return can;
                }
            }
            return can;
        }


    }
}
