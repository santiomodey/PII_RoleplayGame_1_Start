using System;

namespace Library
{
    public class LibroDeHechizos
    {
        public LibroDeHechizos(string name)
        {
            this.Name = name;
        }
        public string Name;

        /// <summary>
        /// Por esta funcion decidimos que fuera necesario hacer el setter de la magia del mago como pública, ya que de otra forma
        /// esta función devolvería un int que sería responsabilidad de la clase mago el sumarlo a su magia.
        /// Creemos que es más eficiente sacrificar un poco de la encapsulación de la magia a cambio de mantener el SRP.
        /// En una situación ideal preferiríamos que solamente esta clase sepa la magia del mago, así la encapsulación no se perdería tanto,
        /// pero es algo que no sabemos hacer en este momento.
        /// </summary>
        /// <param name="Mago"></param>
        /// <returns></returns>
        public int AdquirirConocimiento(Wizard Mago)
        {
           return Mago.Magic += 40;
        }



        
    }
}
