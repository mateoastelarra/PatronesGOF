using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conexion c = Conexion.GetInstance();
            c.Conectar();
            c.DesConectar();

            Console.ReadKey();
        }
    }
}
