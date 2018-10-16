using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        abstract class Bread
        {
            public abstract void MixIngredients();

            public abstract void Bake();

            public virtual void Slice()
            {
                Console.WriteLine("Slicing the " + GetType().Name + " bread!");
            }

            public void Make()
            {
                MixIngredients();
                Bake();
                Slice();
            }
        }

        class TwelveGrain : Bread
        {
            public override void MixIngredients()
            {
                Console.WriteLine("Gathering ingredients for 12-Grain Bread.");
            }

            public override void Bake()
            {
                Console.WriteLine("Baking the 12-Grain Bread. (25 minutes)");
            }
        }
    }
}
