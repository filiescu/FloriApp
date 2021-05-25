using System;

namespace FloriApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* IFlori lalele = new Lalele();
             //FloriDeGradina lalele2 = new Lalele();
             //Lalele lalele3 = new Lalele();

             Afisare(lalele);

             IFlori trandafiri = new Trandafiri();
             Afisare(trandafiri);

             IFlori muscate = new Muscate();
             Afisare(muscate);

             IFlori floareDeHartie = new FloareDeHartie();
             Afisare(floareDeHartie);
       
             FloriFactory floriFactory = new FloriFactory();

             IFlori trandafiri = floriFactory.CreazaFloare(FloriFactory.Trandafiri);
             Afisare(trandafiri);

             IFlori lalele = floriFactory.CreazaFloare(FloriFactory.Lalele);
             Afisare(lalele);

             IFlori muscate = floriFactory.CreazaFloare(FloriFactory.Muscate);
             Afisare(muscate);

             IFlori floareDeHartie = floriFactory.CreazaFloare(FloriFactory.FloareDeHartie);
             Afisare(floareDeHartie);
            */
            DetaliiFlore("trandafir");
            DetaliiFlore("lalea");
            DetaliiFlore("muscata");
            DetaliiFlore("floaredehartie");


        }

        static void DetaliiFlore(string floare) {
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
