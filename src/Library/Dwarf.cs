using System;

namespace Library
{
    public class Dwarf
    {
        public string Name {get;private set;}
        public int Health {get;private set;}
        public int Attack {get;private set;}
        public int Defense {get;private set;}


        public Dwarf(string name)
        {
            this.Name=name;
            this.Health=100;
            this.Attack=50;
            this.Defense=30;
        }

        public void ObtainGuante(Guante Arma)
        {
            if (Arma.Attack > 0 )
            {
                this.Attack+=Arma.Attack;
            }
            if (Arma.Defense > 0 )
            {
                this.Defense+=Arma.Defense;
            }
            if (Arma.Health > 0 )
            {
                this.Health+=Arma.Health;
            }
        }
        public void ObtainRedGem(RedGem Arma)
        {
            if (Arma.Attack > 0 )
            {
                this.Attack+=Arma.Attack;
            }
            if (Arma.Defense > 0 )
            {
                this.Defense+=Arma.Defense;
            }
            if (Arma.Health > 0 )
            {
                this.Health+=Arma.Health;
            }
        }
        
        public string ReceiveAttack(Dwarf Cualquiera)
        {
            if (Cualquiera.Attack<=this.Defense)
            {
                this.Defense-=Cualquiera.Attack;
            }
            if (Cualquiera.Attack>this.Defense)
            {
                this.Defense=0;
                this.Health-=(Cualquiera.Attack-this.Defense);
            }
            if (this.Health<0)
            {
                this.Health=0;
                return $"{this.Name} is dead";
            }
            else 
            {
                return $"{this.Name}'s Health is: {this.Health}";
            }

        }
        public string AttackOther(Dwarf Cualquiera)
        {
            return Cualquiera.ReceiveAttack(this);
            
        }
    }
}