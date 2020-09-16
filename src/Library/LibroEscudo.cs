using System;

namespace Library
{
    public class LibroEscudo
    {
        public LibroEscudo(string name)
        {
            this.Name = name;
            this.Defense=30;
            this.Attack=0;
           
            
        }
        public string Name;
        public int Defense {get;}
        public int Attack {get;}



        
    }
}
