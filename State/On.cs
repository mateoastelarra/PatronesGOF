using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class On : State
    {
        public override string Describe()
        {
            return "It´s On";
        }

        public override void UpdateState(Switch sw)
        {
            sw.DefineState(new Off());
        }
    }
}
