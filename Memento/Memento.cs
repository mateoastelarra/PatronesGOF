﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {
        private string state;

        public Memento()
        {

        }

        public Memento(string state)
        {
            this.state = state;
        }

        public string State { get { return state; } }
    }
}
