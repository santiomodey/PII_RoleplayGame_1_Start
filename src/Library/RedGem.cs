using System;

namespace Library
{
    public class RedGem
    {
        /// <summary>
        /// Se crean las propiedades para que se pueda obtener los datos del elemento pero que no puedan ser 
        /// cambiados desde afuera de la clase
        /// </summary>
        /// <value></value>
        public string Name {get;private set;}
        public int Defense {get;private set;}
        public int Attack {get;private set;}
        public int Health {get;private set;}

        public RedGem(string name)
        {
            this.Name = name;
            this.Defense=0;
            this.Attack=0;
            this.Health=70;

        }
        
    }
}