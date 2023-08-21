using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarPrototype fiatPrototype = new FiatPrototype();
            CarPrototype renaulPrototype = new RenaultPrototype();

            CarPrototype fiatPalio = fiatPrototype.Clone();
            fiatPalio.Model = "Palio Fire";
            fiatPalio.Color = "Blue";
            Console.WriteLine(fiatPalio.ShowCar());

            CarPrototype fiatCronos = fiatPrototype.Clone();
            fiatCronos.Model = "Cronos";
            fiatCronos.Color = "Red";
            Console.WriteLine(fiatCronos.ShowCar());

            CarPrototype renaultSandero = renaulPrototype.Clone();
            renaultSandero.Model = "Sandero Stepway";
            renaultSandero.Color = "Grey";
            Console.WriteLine (renaultSandero.ShowCar());

            CarPrototype renaultDuster = renaulPrototype.Clone();
            renaultDuster.Model = "Duster 4x4";
            renaultDuster.Color = "Green";
            Console.WriteLine(renaultDuster.ShowCar());

            Console.ReadKey();  
        }
    }
}
