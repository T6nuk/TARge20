using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogsOOP
{
    class Pet
    {
        public string name;
        public string color;
        public int LevelOfHapiness;


        public void PrintPetInfo()
        {
            Console.WriteLine($"Name: {name}\nColor: {color}\nLevelofHapiness {LevelOfHapiness}!");
        }

    }
}
