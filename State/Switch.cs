using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Switch
    {
        State state;

        public Switch()
        {
            this.state = new On();
        }

        public void DefineState(State state)
        {
            this.state = state;
        }

        public void Press()
        {
            state.UpdateState(this);
            Console.WriteLine(state.Describe());
        }
    }
}
