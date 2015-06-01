using DefiningClassesPart1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMTest_Project
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM gsm;
            Battery battery;
            Display display;

            List<GSM> test1 = new List<GSM>();
            gsm = new GSM("N97", "Nokia");
            battery = new Battery("BL-5", 400, 12);
            display = new Display(160000000);

            gsm.Battery = battery;
            gsm.Display = display;
            test1.Add(gsm);

            Console.WriteLine(gsm.ToString());

            List<GSM> test2 = new List<GSM>();
            gsm = new GSM("Galaxy S3", "Samsung", 850, "Pesho");
            battery = new Battery("A583", 450, 15, BatteryType.Types.LiIon);
            display = new Display(480, 960);

            gsm.Battery = battery;
            gsm.Display = display;
            test2.Add(gsm);

            Console.WriteLine(gsm.ToString());

            List<GSM> test3 = new List<GSM>();
            gsm = new GSM("iPhone 5", "Apple", 1200);
            battery = new Battery("non removable", 300, 15);
            display = new Display(390, 960, 160000000);

            gsm.Battery = battery;
            gsm.Display = display;
            test3.Add(gsm);

            Console.WriteLine(gsm.ToString());
        }
    }
}
