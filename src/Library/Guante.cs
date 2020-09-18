using System;

namespace Library
{
    public class Guante
    {
        /// <summary>
        /// Se crean las propiedades para que se pueda obtener los datos del elemento pero que no puedan ser 
        /// cambiados desde afuera de la clase
        /// </summary>
        /// <value></value>
        public string Name {get;private set;}
        public int Defense {get;set;}
        public int Attack {get;set;}
        public int Health {get;set;}


        public Guante(string name)
        {
            this.Name = name;
            this.Defense=0;
            this.Attack=40;
            this.Health=0;

        }
        
    }
}