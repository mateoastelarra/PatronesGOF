using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Conexion
    {


        private static Conexion instance;
        // Constructor privado para evitar que se cree más de un objeto de esta clase
        private Conexion() { }

        public static Conexion GetInstance()
        {
            if (instance == null)
            {
                instance = new Conexion();
            }
            return instance;
        }

        public void Conectar()
        {
            Console.WriteLine("Estás conectado a la base de datos");
        }

        public void DesConectar()
        {
            Console.WriteLine("Te desconectaste de la base de datos");
        }


    }
}
