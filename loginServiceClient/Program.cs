using loginServiceClient.ServiceReferenceLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = string.Empty;
            string pass = string.Empty;

            IloginServiceClient objCliente = new IloginServiceClient();

            Console.WriteLine("Ingresar usuario: ");
            user = Console.ReadLine();

            Console.WriteLine("Ingresar password: ");
            pass = Console.ReadLine();

            if (objCliente.ValidateLogin (user, pass) )
            {
                Console.WriteLine("Conexión exitosa");
            }
            else
            {
                Console.WriteLine("Conexión Fallida");
            }
            Console.ReadKey();
        }
    }
}
