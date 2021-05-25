using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriApp
{
    public abstract class FloriDeGhiveci : IFlori
    {
        public void GetTip()
        {
            Console.WriteLine("Flori de ghiveci.");
        }

        public abstract void TipGhiveci();
        public abstract void GetCuloare();
        public abstract void GetInaltime();
        public abstract void PerioadaDeUdare();
        public abstract void Inmultire();
    }
}
