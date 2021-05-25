using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriApp
{
    public class Trandafiri : FloriDeGradina
    {
        public override void GetCuloare()
        {
            Console.WriteLine("Trandafiri rosii, galbeni, albi, roz, etc");
        }

        public override void GetInaltime()
        {
            Console.WriteLine("Trandafirii au o inaltime medie de 1 metru .");
        }

        public override void PerioadaDeUdare()
        {
            Console.WriteLine("Udarea trandafirilor se face de obicei seara sau dimineata.");
        }

        public override void Inmultire()
        {
            Console.WriteLine("Trandafirii se inmultesc prin butasi.");
        }
    }
}
