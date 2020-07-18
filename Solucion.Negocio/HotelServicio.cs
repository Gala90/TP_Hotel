using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Negocio
{
    public class HotelServicio
    {
        private HotelMapper mapper;
        public HotelServicio()
        {
            mapper = new HotelMapper();
        }

        public List<Hotel> TraerHoteles()
        {
            List<Hotel> result = mapper.TraerTodos();
            return result;
        }

        public int Alta_Hotel(string nombre, string direccion, int estrellas, bool amenities)
        {
            Hotel hotel = new Hotel(nombre, direccion, estrellas, amenities);

            ResultadoTransaccion resultante = mapper.Insert(hotel);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);

        }
    }
}
