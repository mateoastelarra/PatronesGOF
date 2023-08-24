using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Vegetable
    {
        protected string description;

        public string Description { get { return description; } }
    }

    public class TomatoAndLettuce : Vegetable
    {
        public TomatoAndLettuce()
        {
            description = "Tomato and Lettuce";
        }
    }

    public class GrilledOnions : Vegetable
    {
        public GrilledOnions()
        {
            description = "Grilled Onions";
        }
    }

    public class BoiledCarrots : Vegetable
    {
        public BoiledCarrots()
        {
            description = "Boiled Carrots";
        }
    }
}
