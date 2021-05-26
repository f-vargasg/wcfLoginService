using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfLoginService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "loginService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione loginService.svc o loginService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class loginService : IloginService
    {
        public bool validateLogin(string user, string pass)
        {
            bool succed = false;
            if (user=="fernando.estrada@tedsoluciones.com" && pass == "12345678")
            {
                succed = true;
            }
            return succed;
        }
    }
}
