using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sistema_Asistencia.Data_Access.Conection
{
    public class Conexion
    {
        public static string cn = Convert.ToString(Complemento.Desencriptacion.checkServer());
        
    }
}
