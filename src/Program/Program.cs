using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dwarf Dwarf1 = new Dwarf("Dwarf1");
            Dwarf Dwarf2 = new Dwarf("Dwarf2");
            Console.WriteLine(Dwarf2.Health);
            Console.WriteLine(Dwarf1.Health);
            Guante Guante1= new Guante ("Guante1");
            Dwarf2.ObtainGuante(Guante1);
            Console.WriteLine(Dwarf2.Health);
            Dwarf1.AttackOther(Dwarf2);
            Console.WriteLine(Dwarf1.AttackOther(Dwarf2));
        }
    }
}
