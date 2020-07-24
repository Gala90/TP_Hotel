using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Solucion.Negocio;



namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                
                ReservaServicio servicio = new ReservaServicio();

                /*

               List<Reserva> lst = servicio.TraerReservas();

               foreach (Reserva c in lst)
               {
                   Console.WriteLine(c);
               }

                


                 int id = servicio.Alta_Cliente("Claudio", "Rodriguez", "Ayacucho 123", "456@gmail.com", "44444444", DateTime.Today , true);
                 Console.WriteLine("Cliente: " + id);


                 int id = servicio.Alta_Hotel("Faena", "Esmeralda 950", 5, true);
                 Console.WriteLine("Hotel: " + id);

                 int id = servicio.Alta_Habitacion(2,"Deluxe", 8, false, 500);
                 Console.WriteLine("Habitacion: " + id);
                




                int id = servicio.Modificar_Reserva(25,7, 84, 2, DateTime.Today.AddDays(1), DateTime.Today.AddDays(3));
                 Console.WriteLine("Reserva: " + id);

                 
                

                int id = servicio.Modificar_Reserva(27,7, 84, 2, DateTime.Today.AddDays(1), DateTime.Today.AddDays(3));
                Console.WriteLine("Reserva: " + id);

                */

                int id = servicio.Cancelar_Reserva(15);
                Console.WriteLine("Reserva eliminada: " + id);






            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
