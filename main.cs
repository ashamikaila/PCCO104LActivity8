using System;

namespace HelloKitty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SanrioCharacter helloKitty = new HelloKittyCharacter(25, "Hello Kitty", "Bow");
            SanrioCharacter myMelody = new MyMelodyCharacter(10, "My Melody", "Hood", "Pink");
            SanrioCharacter keroppi = new KeroppiCharacter(15, "Keroppi", "Lily Pad", "Green");
            SanrioCharacter cinnamoroll = new CinnamorollCharacter(7, "Cinnamoroll", "Blue Scarf", "White");
            SanrioCharacter pompompurin = new PompompurinCharacter(10, "Pompompurin", "Beret", "Yellow");
            SanrioCharacter badtzMaru = new BadtzMaruCharacter(13, "Badtz-Maru", "Skateboard", "Black");

            helloKitty.Sanrio();
            helloKitty.SayHello();
            helloKitty.Play();

            myMelody.Sanrio();
            myMelody.SayHello();
            myMelody.Play();

            keroppi.Sanrio();
            keroppi.SayHello();
            keroppi.Play();

            cinnamoroll.Sanrio();
            cinnamoroll.SayHello();
            cinnamoroll.Play();

            pompompurin.Sanrio();
            pompompurin.SayHello();
            pompompurin.Play();

            badtzMaru.Sanrio();
            badtzMaru.SayHello();
            badtzMaru.Play();
        }
    }

    abstract class SanrioCharacter
    {
        public string Name { get; protected set; }
        public string Item { get; protected set; }
        public double Age { get; protected set; }

        protected SanrioCharacter(double age, string name, string item)
        {
            Age = age;
            Name = name;
            Item = item;
        }

        public void Sanrio()
        {
            Console.WriteLine($"{Name} - {Item} - {Age} years old.");
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello! I'm {Name}.");
        }

        public abstract void Play();
    }

    interface IFriendable
    {
        void MakeFriends();
    }

    class HelloKittyCharacter : SanrioCharacter, IFriendable
    {
        public HelloKittyCharacter(double age, string name, string item) : base(age, name, item) { }

        public override void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }

        public void MakeFriends()
        {
            Console.WriteLine($"{Name} is making friends...");
        }
    }

    class MyMelodyCharacter : SanrioCharacter, IFriendable
    {
        private string Color { get; set; }

        public MyMelodyCharacter(double age, string name, string item, string color) : base(age, name, item)
        {
            Color = color;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }

        public void MakeFriends()
        {
            Console.WriteLine($"{Name} is making friends...");
        }
    }

    class KeroppiCharacter : SanrioCharacter, IFriendable
    {
        protected string Color { get; set; }

        public KeroppiCharacter(double age, string name, string item, string color) : base(age, name, item)
        {
            Color = color;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }

        public void MakeFriends()
        {
            Console.WriteLine($"{Name} is making friends...");
        }
    }

    class CinnamorollCharacter : SanrioCharacter, IFriendable
    {
        public string Color { get; set; }

        public CinnamorollCharacter(double age, string name, string item, string color) : base(age, name, item)
        {
            Color = color;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }

        public void MakeFriends()
        {
            Console.WriteLine($"{Name} is making friends...");
        }
    }

    class PompompurinCharacter : SanrioCharacter, IFriendable
    {
        protected string Color { get; set; }

        public PompompurinCharacter(double age, string name, string item, string color) : base(age, name, item)
        {
            Color = color;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }

        public void MakeFriends()
        {
            Console.WriteLine($"{Name} is making friends...");
        }
    }

    class BadtzMaruCharacter : SanrioCharacter, IFriendable
    {
        protected string Color { get; set; }

        public BadtzMaruCharacter(double age, string name, string item, string color) : base(age, name, item)
        {
            Color = color;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }

        public void MakeFriends()
        {
            Console.WriteLine($"{Name} is making friends...");
        }
    }
}
