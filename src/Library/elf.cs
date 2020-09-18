using System;

namespace Library
{
    /// <summary>
    ///Se mantiene la encapsulacion porque los objetos usan su propia información para cumplir con las responsabilidades. 
	//Esto mantiene el acoplamiento bajo, lo que produce programas más robustos y fáciles de mantener. 
	//El comportamiento se distribuye a través de clase que tienen la información requerida, 
	//promoviendo definiciones de clases más cohesivas que son más fáciles de entender y de mantener.
	//En esta clase se cumple el patrón de Expert debido a que la clase Elf tiene la información necesaria para poder crear objetos Elf. 
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