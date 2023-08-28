using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Memento
{ 
    public class Program
    {
        static CareTaker careTaker = new CareTaker();

        static void Main(string[] args)
        {
            var person = new Person();
            
            person.State = "Frodo living in the Shire";
            careTaker.Add(person.SaveToMemento());

            person.State = "Frodo in Elrond´s Council";
            careTaker.Add(person.SaveToMemento());

            person.State = "Frodo in Mordor";
            careTaker.Add(person.SaveToMemento());

            Console.WriteLine("++++++++++++++++++++++++++++");

            for (int i = 0; i < careTaker.mementos.Count; i++)
            {
                Console.WriteLine($"Memento {i + 1}: ");
                Console.WriteLine(careTaker.GetMemento(i).State);
                Console.WriteLine("++++++++++++++++++++++++++++");
            }

            person.RestoreToMemento(careTaker.GetMemento(0));






        }
    }
}
