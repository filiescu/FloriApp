using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriApp
{
    public class Lalele : FloriDeGradina
    {
        public override  void GetCuloare()
        {
            Console.WriteLine("Lalale rosii, galbene, albe, etc");
        }

        public override void GetInaltime()
        {
            Console.WriteLine("Lalele au o inaltime intre 10 si 70 cm.");
        }

        public override void PerioadaDeUdare()
        {
            Console.WriteLine("Lalele se uda de 2 ori in 10 zile pana in momentul incetarii infloririi.");
        }

        public override void Inmultire()
        {
            Console.WriteLine("Lalele se inmultesc prin bulbi.");
        }
    }
}
