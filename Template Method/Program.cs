﻿using System;
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
