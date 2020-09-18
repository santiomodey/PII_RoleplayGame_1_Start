using System;

namespace Library
{
    public class BlueGem
    {
        public string Name {get;set;}
        public int Defense {get;set;}
        public int Attack {get;set;}
        

        public BlueGem(string name)
        {
            this.Name = name;
            this.Defense=0;
            this.Attack=30;
        }
        
    }
}