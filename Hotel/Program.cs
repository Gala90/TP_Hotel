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
                
                
                HabitacionServicio servicio = new HabitacionServicio();

                /*
                List<Habitacion> lst = servicio.TraerHoteles();

                foreach (Hotel c in lst)
                {
                    Console.WriteLine(c);
                }

                
                
                int id = servicio.Alta_Cliente("Claudio", "Rodriguez", "Ayacucho 123", "456@gmail.com", "44444444", DateTime.Today , true);
                Console.WriteLine("Cliente: " + id);

                
                int id = servicio.Alta_Hotel("Faena", "Esmeralda 950", 5, true);
                Console.WriteLine("Hotel: " + id);

                

                int id = servicio.Agregar_Reserva(1, 0, 1, DateTime.Today, DateTime.Today);
                Console.WriteLine("Reserva: " + id);


                 
                */

                int id = servicio.Alta_Habitacion(1,"Deluxe", 5, true, 200);
                Console.WriteLine("Habitacion: " + id);


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
