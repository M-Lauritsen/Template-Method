using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Program
    {

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

        //Notice that the MixIngredients() and Bake() methods are abstract, while the Slice() method
        //is virtual. This is intentional: the method by which you slice bread is not likely to change
        //depending on the kind of bread you make.Further, the Make() method is the Template
        //Method that gives this pattern its name.
        //Let's extend this example by implementing several ConcreteClass objects for different types
        //of bread
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

        class Sourdough : Bread
        {
            public override void MixIngredients()
            {
                Console.WriteLine("Gatherin Ingredients for Sourdough Bread");
            }

            public override void Bake()
            {
                Console.WriteLine("Baking the Sourdough Bread. (20 minutes)");
            }
        }

        class WholeWheat : Bread
        {
            public override void MixIngredients()
            {
                Console.WriteLine("Gathering Ingredients for Sourdough Bread.");
            }

            public override void Bake()
            {
                Console.WriteLine("Baking the Whole Wheat Bread. (15 minutes)");
            }
        }

        //Once we've defined a few types of bread, we can simulate making them in our Main()
        //method, like so:
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough();
            sourdough.Make();

            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();

            Console.ReadKey();
        }
    }
}
