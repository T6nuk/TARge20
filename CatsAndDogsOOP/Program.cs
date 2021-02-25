using System;

namespace CatsAndDogsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog koer1 = new Dog("pontu", "blue");
            koer1.WaveTail();
            koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail(); koer1.WaveTail();
            koer1.PrintPetInfo();

            Cat Kent = new Cat("Kent", "green");
            Kent.PrintPetInfo();

            for (int i = 0; i < 10; i++)
            {
                koer1.WaveTail();
            }
            koer1.PrintPetInfo();

            bool dogBarked = koer1.Bark();

            if (dogBarked)
            {
                Kent.HearTheDog();
            }
            if (Kent.LevelOfHapiness == 0)
            {
                Kent.Hiss();
            }
        }
    }
}
