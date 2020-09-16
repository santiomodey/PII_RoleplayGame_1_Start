using System;

namespace Library
{
    public class Wizard
    {
        public Wizard(string name)
        {
            this.Name = name;
            this.Health = 200;
            this.EscudoEtereo =new LibroEscudo("Escudo Etéreo");
            this.Rayo = new LibroRayo("Rayo");
            this.Attack = 50 + Rayo.Attack;
            this.Defense = 0 + EscudoEtereo.Defense;
            
        }
        public int Attack{get; private set;}
        public string Name{get;}
        public int Defense{get; private set;}
        public LibroEscudo EscudoEtereo{get; private set;}
        public LibroRayo Rayo{get; private set;}
    
        public int Health{get; private set;}

        public void ReceiveAttack(int AtaqueEnemigo)
        {
            this.Health -= AtaqueEnemigo - this.Defense;
            this.Dead();
            if (this.Health == 0)
            {
                Console.WriteLine($"{this.Name} ha sido atacado, ahora tiene {this.Health} de vida, ha muerto");
            }
            else
            {
                Console.WriteLine($"{this.Name} ha sido atacado, ahora tiene {this.Health} de vida");
            }
        }
        public void Heal()
        {
            this.Health = 200;
        }
        public void Dead()
        {
            if (this.Health < 0)
                this.Health = 0;
        }
}

}