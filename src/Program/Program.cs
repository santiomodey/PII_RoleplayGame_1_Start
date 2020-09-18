using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Elf Elf = new Elf("Elf");
            Elf Elf1 = new Elf("Elf");
            Elf.ReceiveOther(Elf.Attack);
            Console.WriteLine(Elf.Health);
        }
    }
}
