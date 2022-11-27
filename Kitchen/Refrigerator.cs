using System;
using System.Collections.Generic;
using System.Text;

namespace Kitchen
{
    class Refrigerator : KitchenAppliance
    {
        public string type;
        public string model;
        public string power;
        public string tension;
        public string raw;

        public Refrigerator(string type, string model, string power, string tension, string raw)
        {
            name = "Refrigerator";

            this.type = type;
            this.model = model;
            this.power = power;
            this.tension = tension;
            this.raw = raw;
        }
       
        public override string PushButton()
        {
            if (workingBool == false)
            {
                Console.WriteLine($"You pushed the button. the {name} turned on");
                Turn();
                return status = "working";
            }
            else
            {
                Console.WriteLine($"You pushed the button. the {name} turned of");
                Turn();
                return status = "not working";
            }   
        }      
        public override void GiveInfo()
        {
            base.GiveInfo();
            Console.WriteLine($"name: {name}, \nmodel: {type}, \nstatus: {status}, \npower: {power}, \ntension: {tension}, \nraw: {raw}");
        }

        /*private bool Turn()
        {
            
            workingBool = false ? true : false;
            return workingBool;
            
            //return workingBool = !workingBool;
            
            if (workingBool == false)
                return workingBool = true;
            else
                return workingBool = false;
        }*/
    }
}
