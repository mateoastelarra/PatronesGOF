using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter
{
    public class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando el motor diesel...");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando el motor diesel...");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando el motor diesel...");
        }

        public override void CargarCOmbustible()
        {
            Console.WriteLine("Cargando combustible en el motor diesel...");
        }
    }
}