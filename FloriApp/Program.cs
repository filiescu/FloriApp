using System;
using static FloriApp.FloriFactory;

namespace FloriApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  IFlori lalele = new Lalele();
                FloriDeGradina lalele2 = new Lalele();
                Lalele lalele3 = new Lalele();
            */

            DetaliiFlore(FloareEnum.Trandafiri);
            DetaliiFlore(FloareEnum.Lalele);
            DetaliiFlore(FloareEnum.Lalele_galbene);
            DetaliiFlore(FloareEnum.Lalele_rosii);
            DetaliiFlore(FloareEnum.Muscate);
            DetaliiFlore(FloareEnum.FloareDeHartie);
        }

        static void DetaliiFlore(FloareEnum floare) {
            FloriFactory floriFactory = new FloriFactory();
            IFlori Ifloare = floriFactory.CreazaFloare(floare);
            Afisare2(Ifloare);
        }

        static void Afisare1(IFlori flori) {
            flori.GetTip();
            flori.GetCuloare();
            flori.GetInaltime();
            flori.PerioadaDeUdare();
            flori.Inmultire();
            try
            {
                FloriDeGhiveci ghiveci = (FloriDeGhiveci)flori;
                ghiveci.TipGhiveci();
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Nu au ghiveci");
            }

            Console.WriteLine();
        }

        static void Afisare2(IFlori flori)
        {
            flori.GetTip();
            flori.GetCuloare();
            flori.GetInaltime();
            flori.PerioadaDeUdare();
            flori.Inmultire();
            if (flori is FloriDeGhiveci)
            {
                FloriDeGhiveci ghiveci = (FloriDeGhiveci)flori;
                ghiveci.TipGhiveci();
            }
            else
            {
                Console.WriteLine("Nu au ghiveci");
            }        

            Console.WriteLine();
        }
    }
}
