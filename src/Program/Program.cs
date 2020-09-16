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
            Console.WriteLine(Elf.Health);
            BlueGem BlueGem1= new BlueGem ("BlueGem");
            Elf.ObtainBlueGem(BlueGem1);
            Console.WriteLine(Elf.Health);
            Elf.ReceiveOther(Elf);
            Console.WriteLine(Elf.Health);
        }
    }
}
