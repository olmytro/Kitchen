using System;

namespace Kitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator Atlant = new Refrigerator("Atlant", "BMN-5563", "5 kW", "220 V", "electricyty");
            //Atlant.GiveInfo();
            Console.WriteLine(Atlant.workingBool);
            Console.WriteLine(Atlant.status);
            Atlant.PushButton();
            Console.WriteLine(Atlant.workingBool);
            Console.WriteLine(Atlant.status);
            Atlant.PushButton();
            Console.WriteLine(Atlant.workingBool);
            Console.WriteLine(Atlant.status);
            Atlant.PushButton();
            Console.WriteLine(Atlant.workingBool);
            Console.WriteLine(Atlant.status);
            Console.ReadKey();
        }
    }
}
