using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriApp
{
    public class LaleleGalbene : Lalele
    {
        public override void GetCuloare()
        {
            Console.WriteLine("Lalele galbene.");
        }

        public void GetLaleaInfo1()
        {
            Console.WriteLine("Info 1 lalele galbene");
        }

        public override void GetLaleaInfo2() 
        {
            Console.WriteLine("Info 2 lalele galbene");
        }

        public override void GetLaleaInfo3()
        {
            Console.WriteLine("Info 3 lalele galbene");
        }

        public virtual void GetLaleaInfo4()
        {
            Console.WriteLine("Info 4 lalele galbene");
        }
    }
}
