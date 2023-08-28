using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Person
    {
        public string State { get; set; }

        public Memento SaveToMemento()
        {
            Console.WriteLine($"Originator: Saving Memento for {State}");
            return new Memento(State);
        }

        public void RestoreToMemento(Memento memento)
        {
            Console.WriteLine($"Originator: Restoring memento: {memento.State}");
        }
    }
}
