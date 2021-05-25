using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriApp
{
    public class FloriFactory
    {
        public static readonly string Trandafiri = "trandafir";
        public static readonly string Lalele = "lalea";
        public static readonly string Muscate = "muscata";
        public static readonly string FloareDeHartie = "floaredehartie";

        public IFlori CreazaFloare(string tipFloare)
        {
             IFlori floare ;
             if (Trandafiri.Equals(tipFloare))
             {
                 floare = new Trandafiri();
             }
             else if (Lalele.Equals(tipFloare))
             {
                 floare = new Lalele();
             }
             else if (Muscate.Equals(tipFloare))
             {
                 floare = new Muscate();
             }
             else if (FloareDeHartie.Equals(tipFloare))
            {
                floare = new FloareDeHartie();
            }
             else {
                 floare = new Trandafiri();
             }
             return floare;
        }
    }
}
