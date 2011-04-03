using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonRut.Ws.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el nombre de una ruta");
            string name = Console.ReadLine();
            MonRutWs.MonRutWsSoapClient webservice = new MonRutWs.MonRutWsSoapClient("MonRutWsSoap");


            try
            {
                webservice.AddRoute(name);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}
