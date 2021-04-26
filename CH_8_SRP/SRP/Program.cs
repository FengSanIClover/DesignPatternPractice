using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( 123 );
            // 單一職責範例
            Console.WriteLine("違反單一職責的類別");
            Violation_Modem vioModem = new Violation_Modem();
            vioModem.Dial();

            Console.WriteLine("");
            Console.WriteLine("遵守單一職責的類別");
            Follow_Modem followModem = new Follow_Modem();
            followModem.Dial();
        }
    }
}
