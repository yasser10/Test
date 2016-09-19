using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p = new Pupil("Yassin", 22);
            Activity act1 = new Activity("Tennis", true);
            Activity act2 = new Activity("dessin", false);
            Activity act3 = new Activity("gym", true);

            p.addActivity(act1);
            p.addActivity(act2);
            p.addActivity(act3);
            p.AddEvaluation("Tennis");

            System.Console.Write(p);
            System.Console.Read();
        }
    }
}
