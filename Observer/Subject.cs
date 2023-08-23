using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;

        public int GetState()
        {
            return state;
        }

        public void SetState(int state)
        {
            this.state = state;
            NotifyObservers();
        }

        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }


    }
}
