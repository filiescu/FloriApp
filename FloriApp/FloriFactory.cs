using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriApp
{
    public partial class FloriFactory
    {
        public IFlori CreazaFloare(FloareEnum tipFloare)
        {
            IFlori floare;
            switch (tipFloare)
            {
                case FloareEnum.Trandafiri:
                    floare = new Trandafiri();
                break;
                case FloareEnum.Lalele:
                    floare = new Lalele();
                break;
                case FloareEnum.Lalele_galbene:
                    floare = new LaleleGalbene();
                break;
                case FloareEnum.Lalele_rosii:
                    floare = new LaleleRosii();
                break;
                case FloareEnum.Muscate:
                    floare = new Muscate();
                break;
                case FloareEnum.FloareDeHartie:
                    floare = new FloareDeHartie();
                break;
                default:
                    floare = new Trandafiri();
                break;   
            }

            return floare;
        }
    }
}
