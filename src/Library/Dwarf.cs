using System;

namespace Library
{
    /// <summary>
    /// Se utiliza SRP creando una clase para cada objeto de forma que la 
    /// modificación de una de estas no afecte a las demás
    /// </summary>
    public class Dwarf
    {
        /// <summary>
        /// Se utiliza el concepto de encapsulación
        /// al crearse las variables de instancia de forma privada
        /// con métodos publicos que permitan obtener los datos del 
        /// elemento pero que no puedan ser 
        /// cambiados desde afuera de la clase
        /// </summary>
        /// <value></value>
        public string Name {get;private set;}
        public int Health {get;private set;}
        public int Attack {get;private set;}
        public int Defense {get;private set;}
        public Guante Guante1 {get;}
        public RedGem RedGem1 {get;}

        /// <summary>
        /// Cada vez que se crea un objeto Dwarf se crea con un elemento Guante y un elemento RedGem
        /// y con los parametros de health, attack y defense ya predeterminados, siendo modificado 
        /// por los elementos con los que se crea
        /// </summary>
        /// <param name="name"></param>
        public Dwarf(string name)
        {
            this.Name=name;
            this.Guante1= new Guante("Guante1");
            this.RedGem1= new RedGem("RedGem1");
            this.Health=100 + RedGem1.Health;
            this.Attack=50 + Guante1.Attack;
            this.Defense=30;
            
        }

        /// <summary>
        /// El método ReceiveAttack disminuye la vida del objeto en caso de que el valor de ataque del enemigo 
        /// sea mayor al de defensa del que recibe el ataque, siendo la diferencia entre estos parametros 
        /// lo que disminuye el health
        /// 
        /// Se utiliza EXPERT ya que el metodo ReceiveAttack le pide la información al otro objeto (experto en la información)
        /// para poder compararla con la Defensa propia y hacer los cálculos para disminuit el Health
        /// </summary>
        /// <param name="Enemigo"></param>
        /// <returns></returns>
        public string ReceiveAttack(Dwarf Enemigo)
        {
            if (Enemigo.Attack<=this.Defense)
            {
                this.Defense-=Enemigo.Attack;
            }
            if (Enemigo.Attack>this.Defense)
            {
                this.Defense=0;
                this.Health-=(Enemigo.Attack-this.Defense);
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

        public void Curar()
        {
            if (this.Health<100)
            {
                this.Health=100;
            }
        }

        
    }
}