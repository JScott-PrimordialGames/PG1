using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        class Fruit
        {
            public virtual void Show() { Console.Write("Fruit"); }
        }
        class Banana : Fruit
        {
            public override void Show() { base.Show(); Console.Write("Banana"); }
        }

        static void Main(string[] args)
        {
            Dictionary<string, string> minivans = new Dictionary<string, string>()
{
    { "Ford", "Aerostar" },
    { "Honda", "Odyssey"},
    { "Toyota", "Sienna"}
};
            if (minivans.TryGetValue("Nissan", out string model))
            {
                Console.WriteLine($"Nissan Model: {model}");
            }


            Console.ReadKey();
        }
    }
}
