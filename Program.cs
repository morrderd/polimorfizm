using System;

namespace Dziedziczenie
{
    class Program
    {
        static void Main()
        {
            Prostokat pr = new Prostokat();
            pr.UstawSzerokosc(4);
            pr.UstawWysokosc(5);
            Console.WriteLine(pr.WyswietWysokosc(pr.wysokosc));
            Console.WriteLine(pr.WyswietSzerokosc(pr.szerokosc));
            Console.WriteLine("Powierzchnia prostokąta: {0}", pr.ObliczPowierzchnie());
            Console.ReadKey();
        }
    }

    class Ksztalt
    {
        public int szerokosc;
        public int wysokosc;

        public void UstawWysokosc(int w)
        {
            wysokosc = w;
        }
        public void UstawSzerokosc(int s)
        {
            szerokosc = s;
        }

        
    }

    public interface WyswietlInformacje 
    {
        string WyswietWysokosc(int wysokosc);

        string WyswietSzerokosc(int szerokosc);
    }


    class Prostokat : Ksztalt, WyswietlInformacje
    {
        public int ObliczPowierzchnie()
        {
            return wysokosc * szerokosc;
        }

        public string WyswietWysokosc(int wysokosc)
        {
            string info = String.Format("Długość to: {0}", wysokosc);
            return info;
        }

        public string WyswietSzerokosc(int szerokosc)
        {
            string info = String.Format("Szerokość to: {0}", szerokosc);
            return info;
        }
    }
}