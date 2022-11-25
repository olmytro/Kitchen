using System;
using System.Collections.Generic;
using System.Text;

namespace Kitchen
{
    class Refrigerator : KitchenAppliance
    {
        public int NumberOfCameras;

        public Refrigerator(string name, int NumberOfCameras) : base(name)
        {
            this.NumberOfCameras = NumberOfCameras;
        }
        public override void Working()
        {
            //working = true;
            Console.WriteLine("The Refrigerator is working");
        }
    }
}
