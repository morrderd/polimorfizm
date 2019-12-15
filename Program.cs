using System;
using System.Collections.Generic;

namespace Dziedziczenie
{
    class Ksztalt
    {
        public double dlugosc;
        public double szerokosc;
        public double wysokosc;
        
        public virtual void ObliczPole()
        {
            
        }
    }

    class Kwadrat : Ksztalt
    {
        public override void ObliczPole()
        {
            base.ObliczPole();
        }
    }
    class Trojkat : Ksztalt
    {
        public override void ObliczPole()
        {
            base.ObliczPole();
        }
    }
    class Kolo : Ksztalt
    {
        public override void ObliczPole()
        {
            base.ObliczPole();
        }
    }

    class Program
    {
        static void Main()
        {
            var figury = new List<Ksztalt>
            {
                new Kwadrat(),
                new Trojkat(),
                new Kolo()
            };

            foreach (var ksztalt in figury)
            {
                ksztalt.ObliczPole();
            }
        }
    }
}
