using System;

namespace Library
{
    /// <summary>
    /// Se crear las variables de instancia como privadas por encapsulacion 
    /// </summary>
    public class Elf
    {
    
        public string Name {get;}
        public int Health {get;private set;}
        public int Attack {get;private set;}
        public int Defense{get;private set;}
        
        public BlueGem BlueGem{get;}
        public Palo Palo{get;} 

        public Elf(string name)
        {
            this.Name=name;
            this.Health=100;
            this.BlueGem = new BlueGem("GemaAzul");
            this.Palo = new Palo("Palo");
            this.Attack=60 + BlueGem.Attack;
            this.Defense=10 + Palo.Defense;
            
        }

        public void ReceiveOther(int enemigo)
        {
            this.Health-=enemigo - this.Defense;
            this.Dead();
            if (this.Health == 0)
            {
                Console.WriteLine($"{this.Name} is dead");
            }
            else 
            {
                Console.WriteLine ($"{this.Name}'s Health is: {this.Health}");
            }
        }
        public void Dead()
        {
            if (this.Health < 0)
            {
                this.Health = 0;
            }
        }
        public void Heal()
        {
            this.Health = 100;
        }
    }
}