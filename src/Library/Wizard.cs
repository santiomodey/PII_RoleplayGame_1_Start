using System;
/// <summary>
/// Se crean las variables de instancia privadas, de esta forma se mantiene la encapsulación para que cosas como el ataque o 
/// la defensa no la pueda cambiar otra clase ya que no lo vemos necesario, en el caso de un ataque lo planteamos como que recibe
/// una cantidad de daño y se baja la vida a sí mismo en lugar de bajarle la vida a otro, de esta forma se mantiene la encapsulación.
/// </summary>
/// Tenemos esta clase como experta de información ya que es la que sabe tanto el daño como la defensa que les brinda los otros Items.
/// Creemos que a pesar de que esta clase tenga varias funciones, se cumple el SRP ya que se crea un clase para cada Item de forma que la modificación de una de estas no afecte a las demás.

namespace Library
{
    public class Wizard
    {
        //Interpreté la magia como algo que aumenta tanto el ataque como la defensa, a cambio hice que tuviera una cantidad base tanto de vida como de defensa y ataque bajos. 
        public Wizard(string name)
        {
            this.Name = name;
            this.Health = 60;
            this.Staff = new Staff("Escudo Etéreo");
            this.Spellbook = new LibroDeHechizos("SpellBook");
            this.Magic = 50 + Staff.Magic;
            this.Attack = 20 + this.Magic;
            this.Defense = 0 + this.Magic;
            
            
        }
        public int Attack{get; private set;}
        public int Defense{get; private set;}
        public int Magic{get; set;}
        public string Name{get;}
        public Staff Staff{get;}
        public LibroDeHechizos Spellbook{get;}
    
        public int Health{get; private set;}

        public void ReceiveAttack(int AtaqueEnemigo)
        {
            if(AtaqueEnemigo <= this.Defense)
            {
                Console.WriteLine($"El Ataque {AtaqueEnemigo} es menor o igual que la defensa {this.Defense}, por lo tanto el ataque no surte efecto");
            }
            else
            {
                this.Health -= AtaqueEnemigo - this.Defense;
            }
            this.Dead();
            if (this.Health == 0)
            {
                Console.WriteLine($"{this.Name} ha sido atacado, ahora tiene {this.Health} de vida, ha muerto");
            }
            else
            {
                Console.WriteLine($"{this.Name} ha sido atacado, ahora tiene {this.Health} de vida");
            }
        }
        public void Heal()
        {
            if (this.Health < 60)
            {
                this.Health = 60;
            }
        }
        public void Dead()
        {
            if (this.Health < 0)
                this.Health = 0;
        }
}

}