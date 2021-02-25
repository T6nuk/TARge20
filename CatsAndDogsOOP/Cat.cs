using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogsOOP
{
    class Cat : Pet
    {


        public Cat(string _name, string _color)
        {
            name = _name;
            color = _color;
            LevelOfHapiness = 10;
        }

        public void HearTheDog()
        {
            LevelOfHapiness = 0;
        }

        public void Hiss()
        {
            Console.WriteLine("Hsssss");
        }
    }
}
