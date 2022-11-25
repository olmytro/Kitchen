using System;
using System.Collections.Generic;
using System.Text;

namespace Kitchen
{
    abstract class KitchenAppliance
    {
        private string name;
        private string model;
        private bool working;
        private int power;
        private int tension;
        private string raw;

        public KitchenAppliance(string name, string model, string power, int tension, string raw)
        {
            this.name = name;
            this.model = model;
            this.power = power;
            this.tension = tension;
            this.raw = raw;
        }

        public void SwitchOn()
        {
            working = true;
        }

        public void SwitchOff()
        {
            working = false;
        }
        public abstract void Working();
        
    }
}
