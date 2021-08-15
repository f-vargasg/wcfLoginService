using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfLoginService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IloginService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IloginService
    {
        [OperationContract]
        bool ValidateLogin(string user, string pass);
    }
}
