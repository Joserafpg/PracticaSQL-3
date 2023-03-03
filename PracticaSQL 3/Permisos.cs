using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSQL_3
{
    public class Permisos
    {
        public Permisos() 
        {
        }

        public static bool Consultar { set; get; }
        public static bool Registrar { set; get; }
        public static bool Su { set; get; }
    }
}
