using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class StandBy : State
    {
        public override string Describe()
        {
            return "Standby Mode";
        }

        public override void UpdateState(Switch sw)
        {
            sw.DefineState(new On());
        }
    }
}
