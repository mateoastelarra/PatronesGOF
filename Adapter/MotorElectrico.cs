using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter
{
    public class MotorElectrico
    {
        bool conectado;
        bool activo;
        bool moviendo;

        public void Conectar()
        {
            if (conectado)
            {
                Console.WriteLine("El motor ya está conectado..");
            }
            else
            {
                conectado = true;
                Console.WriteLine("Motor conectado..")
            }

        }

        public void Activar()
        {
            if (!conectado)
            {
                Console.WriteLine("Imposible activar un motor que no fue conectado...");
            }
            else
            {
                activo = true;
                Console.WriteLine("Motor activado...");
            }
        }

        public void Mover()
        {
            if (conectado && activo)
            {
                moviendo = true;
                Console.WriteLine("Moviendo Vehículo con motor eléctrico..");
            }
            else
            {
                Console.WriteLine("El vehículo debe estar conectado y activo para poder moverse...");
            }
        }

        public void Parar()
        {
            if (moviendo)
            {
                moviendo = false;
                Console.WriteLine("Parando el vehículo con motor eléctrico...");
            }
            else
            {
                Console.Writeline("No se puede parar un auto que no está en movimiento...");
            }
        }

        public void Desconectar()
        {
            if (conectado)
            {
                conectado = false;
                Console.WriteLine("Se desconectó el vehículo con motor eléctrico...");
            }
            else
            {
                Console.Writeline("No se puede desconectar un motor que no está conectado...");
            }
        }

        public void Desactivar()
        {
            if (activo)
            {
                activo = false;
                Console.WriteLines("Desactivando el vehículo con motor eléctrico...");
            }
            else
            {
                Console.WriteLine("No se puede desactivar un motor que no está activo...");
            }
        }

        public void Cargar()
        {
            if (!activo && !conectado)
            {
                Console.WriteLine("Se está cargando el motor eléctrico...");
            }
            else
            {
                Console.Writeline("No se puede cargar el motor eléctrico porqué está activo o conectado...");
            }
        }
    }
}