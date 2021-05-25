using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriApp
{
    public class FloareDeHartie : FloriDeGhiveci
    {
        public override void GetCuloare()
        {
            Console.WriteLine("Floare de hartie roz, alba, mov, etc");
        }

        public override void GetInaltime()
        {
            Console.WriteLine("Floarea de hartie poate ajunge la o inaltime de 1-2 metri.");
        }

        public override void PerioadaDeUdare()
        {
            Console.WriteLine("Floarea de hartie necesita udarea cu o cantitate mai mare de apa primavara si vara.");
        }

        public override void Inmultire()
        {
            Console.WriteLine("Floarea de hartie se inmulteste prin butasi.");
        }

        public override void TipGhiveci()
        {
            Console.WriteLine("Tip ghiveci: 40-50 cm diametru.");
        }
    }
}
