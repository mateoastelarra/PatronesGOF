using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class CareTaker
    {
        public List<Memento> mementos = new List<Memento>();

        public void Add(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return mementos[index];
        }
    }
}
