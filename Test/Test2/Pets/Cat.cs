using System;

namespace Test2.Pets
{
    public interface IPet
    {        
        void MakeSound();
    }

    public abstract class PetBase
    {
        public virtual PetColor Color => PetColor.White;
    }

    public class Cat : PetBase, IPet
    {
        public Cat(PetColor color)
        {
            Color = color;
        }

        public override PetColor Color { get; }

        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}