using System;
using Library;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Pedro = new Wizard("Pedro");
            Wizard Pepe = new Wizard("Pepe");
            Console.WriteLine(Pepe.Health);
            Pepe.ReceiveAttack(Pedro.Attack);
            Pepe.ReceiveAttack(Pedro.Attack);
            Console.WriteLine(Pepe.Magic);
            Pepe.Spellbook.AdquirirConocimiento(Pepe);
            Console.WriteLine(Pepe.Magic);
        }
    }
}
