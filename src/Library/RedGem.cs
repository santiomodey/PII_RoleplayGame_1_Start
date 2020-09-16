using System;

namespace Library
{
    public class RedGem
    {
        
        public string Name {get;private set;}
        public int Defense {get;set;}
        public int Attack {get;set;}
        public int Health {get;set;}


        public RedGem(string name)
        {
            this.Name = name;
            this.Defense=0;
            this.Attack=0;
            this.Health=70;

        }
        
    }
}