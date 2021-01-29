using System;

namespace ControlVee.Port.Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class Goodbye
    {
        public string Name { get; set; }

        public void SayGoodbye()
        {
            Console.WriteLine($"Goodbye {Name}");
        }

        public int ScreamGoodBye(int count)
        {
            int rv = 0;

            return rv;
        }
    }

    public class Ouch
    {
        public string Perp { get; set; }
        public string Victim { get; set; }
        
        public void SayOuch()
        {
            Console.WriteLine($"{Perp} looks at {Victim}");
        }
        
        public int ScreamOuch(int count)
        {
            int rv = 0;
            return rv;
        }
    }

    public class Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello.");
        }

        public int ScreamHello(int times)
        {
            int rv = 0;

            Console.WriteLine($"HELLO! x {times}");

            return rv;
        }
    }
}
