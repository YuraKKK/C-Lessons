using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Girl
    {
        private string _name;
        private int _age;
        private int _weight;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set 
            {
                if(value > 0)
                    _age = value;
                else
                {
                    _age = 0;
                    throw new Exception("Вік не можу бути меншим 0");
                    //Console.WriteLine("Вік не можу бути меншим 0");
                }
            }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

    }
}
