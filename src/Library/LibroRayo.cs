using System;

namespace Library
{
    public class LibroRayo
    {
        public LibroRayo(string name)
        {
            this.Name = name;
            this.Defense=0;
            this.Attack=100;
           
            
        }
        public string Name;
        public int Defense {get;}
        public int Attack {get;}



        
    }
}
