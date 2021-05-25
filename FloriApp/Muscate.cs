using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriApp
{
    public class Muscate : FloriDeGhiveci
    {
        public override void GetCuloare()
        {
            Console.WriteLine("Muscate rosii, roz, albe, etc");
        }

        public override void GetInaltime()
        {
            Console.WriteLine("Muscatele au o inaltimea medie de 15 cm.");
        }

        public override void PerioadaDeUdare()
        {
            Console.WriteLine("Vara muscatele se uda zilnic.");
        }

        public override void Inmultire()
        {
            Console.WriteLine("Muscatele se inmultesc prin butasi sau prin seminte.");
        }

        public override void TipGhiveci()
        {
            Console.WriteLine("Tip ghiveci: Jardiniera");
        }
    }
}
