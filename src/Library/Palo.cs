using System;

namespace Library
{
    public class Palo
    {
        
        public string Name {get;set;}
        public int Defense {get;set;}
        public int Attack {get;set;}


        public Palo(string name)
        {
            this.Name = name;
            this.Defense=40;
            this.Attack=0;
        }
        
    }
}