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
            Pepe.ReceiveAttack(Pedro.Attack);
            Pepe.ReceiveAttack(Pedro.Attack);
        }
    }
}
