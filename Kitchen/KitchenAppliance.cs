using System;
using System.Collections.Generic;
using System.Text;

namespace Kitchen
{
    abstract class KitchenAppliance 
    {
        public string name;
        public string status = "not working";
        public bool workingBool = false;

        //abstract PushButton() потому что не все устройства начинают работу при нажатии кнопки.
        //для других устройств нужна будет проверка может ли устройства заработать.
        public abstract string PushButton();

        //virtual потому что у разных устройств может добавляться какое-то поле.
        public virtual void GiveInfo(){}

        //нужен метод, который просто меняет true на false.
        //Этот метод возвращает bool abstract class`a или в классе наследнике?
        public bool Turn()
        {
            if (workingBool == false)
                return workingBool = true;
            else
                return workingBool = false;
        }
    }
}
