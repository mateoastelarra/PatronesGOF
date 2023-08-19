using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class MotorElectricoAdapter : Motor
    {
        MotorElectrico motorElectrico = new MotorElectrico();

        public override void Acelerar()
        {
            motorElectrico.Mover();
        }

        public override void Arrancar()
        {
            motorElectrico.Conectar();
            motorElectrico.Activar();
        }

        public override void Parar()
        {
            motorElectrico.Desactivar();
            motorElectrico.Parar();
        }

        public override void CargarCombustible()
        {
            motorElectrico.Cargar();
        }
    }
}