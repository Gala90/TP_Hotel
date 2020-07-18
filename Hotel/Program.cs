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
                
                ClienteServicio servicio = new ClienteServicio();

                List<Cliente> lst = servicio.TraerClientes();

                foreach (Cliente c in lst)
                {
                    Console.WriteLine(c);
                }




            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
