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
            Console.WriteLine(Dwarf1.Health);
            Console.WriteLine(Dwarf2.Health);
            Dwarf1.ReceiveAttack(Dwarf2);
            Console.WriteLine(Dwarf1.Health);
            Console.WriteLine(Dwarf1.ReceiveAttack(Dwarf2));
            Elf Elf = new Elf("Elf");
            Elf Elf1 = new Elf("Elf");
            Elf.ReceiveOther(Elf.Attack);
            Console.WriteLine(Elf.Health);
        }
    }
}
