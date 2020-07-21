﻿using System;
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



               List<Habitacion> lst = servicio.TraerHabitaciones(1);

               foreach (Habitacion c in lst)
               {
                   Console.WriteLine(c);
               }
                               /*
                

                int id = servicio.Alta_Cliente("Claudio", "Rodriguez", "Ayacucho 123", "456@gmail.com", "44444444", DateTime.Today , true);
                Console.WriteLine("Cliente: " + id);


                int id = servicio.Alta_Hotel("Faena", "Esmeralda 950", 5, true);
                Console.WriteLine("Hotel: " + id);

                int id = servicio.Alta_Habitacion(2,"Deluxe", 8, false, 500);
                Console.WriteLine("Habitacion: " + id);

               
                                             


                int id = servicio.Agregar_Reserva(1, 84, 3, DateTime.Today, DateTime.Today.AddDays(3));
                Console.WriteLine("Reserva: " + id);

               
                */
  




            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
