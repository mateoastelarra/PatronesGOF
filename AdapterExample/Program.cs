using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Motor motor1 = new MotorNafta();
            motor1.Arrancar();
            motor1.Acelerar();
            motor1.Parar();
            motor1.CargarCombustible();

            Motor motor2 = new MotorDiesel();
            motor2.Arrancar();
            motor2.Acelerar();
            motor2.Parar();
            motor2.CargarCombustible();

            Motor motor3 = new MotorElectricoAdapter();
            motor3.Arrancar();
            motor3.Acelerar();
            motor3.Parar();
            motor3.CargarCombustible();
        }
    }
}