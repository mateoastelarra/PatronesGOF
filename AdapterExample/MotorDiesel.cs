using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterExample
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

        public override void CargarCombustible()
        {
            Console.WriteLine("Cargando combustible en el motor diesel...");
        }
    }
}