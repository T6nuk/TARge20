using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogsOOP
{
    class Dog : Pet
    {


        public Dog(string _name, string _color)
        {
            name = _name;
            color = _color;
            LevelOfHapiness = 0;
        }

        public void WaveTail()
        {
            if (LevelOfHapiness > 100)
            {
                color = "red";
            }
            LevelOfHapiness += 1;
        }

        public bool Bark()
        {
            Console.WriteLine("Woof-Woof");
            return true;
        }
        

    }
}
