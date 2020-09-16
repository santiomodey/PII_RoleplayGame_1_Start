using System;

namespace Library
{
    public class Elf
    {
    
        public string Name {get;private set;}
        public int Health {get;set;}
        public int Attack {get;set;}
        

        public Elf(string name)
        {
            this.Name=name;
            this.Health=100;
            this.Attack=30;
        }

        public void ObtainPalo(Palo Arma)
        {
            if (Arma.Attack > 0 )
            {
                this.Attack+=Arma.Attack;
            }
            if (Arma.Defense > 0 )
            {
                this.Health+=Arma.Defense;
            }
        }
        public void ObtainBlueGem(BlueGem Arma)
        {
            if (Arma.Attack > 0 )
            {
                this.Attack+=Arma.Attack;
            }
            if (Arma.Defense > 0 )
            {
                this.Health+=Arma.Defense;
            }
        }
        public string ReceiveOther(Elf enemigo)
        {
            this.Health-=enemigo.Attack;
            if (enemigo.Health <0)
            {
                return $"{enemigo.Name} is dead";
            }
            else 
            {
                return $"{enemigo.Name}'s Health is: {enemigo.Health}";
            }
        }
        
    }
}