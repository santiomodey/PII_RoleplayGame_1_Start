using NUnit.Framework;
using Library;


namespace Test.Library
{


    public class DwarfTests
    {
        
        private Dwarf Dwarf20;
        private Dwarf Dwarf30;
        
        [SetUp]
        public void Setup()
        {
            
            Dwarf20 = new Dwarf("Dwarf1");
            Dwarf30 = new Dwarf("Dwarf2");

        }

        /// <summary>
        /// Este test verifica que el nombre del objeto creado sea acorde a lo que se pretende
        /// </summary>
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Dwarf20.Name, "Dwarf1");
        }

        /// <summary>
        /// Este test verifica que el metodo ReceiveAttack funcione correctamente
        /// </summary>
        [Test]
        public void Test2()
        {
            Dwarf20.ReceiveAttack(Dwarf30);
            Assert.AreEqual(Dwarf20.Health, 80);
        }


        /// <summary>
        /// Este metodo verifica que cuando la vida sea negativa la vida se setee a 0
        /// </summary>
        [Test]
        public void Test3()
        {
            Dwarf20.ReceiveAttack(Dwarf30);
            Dwarf20.ReceiveAttack(Dwarf30);
            Assert.AreEqual(Dwarf20.Health, 0);
        } 
        

        /// <summary>
        /// Este test verifica que el valor del Attack sea sumado con el valor del elemento
        /// agregado en el constructor del objeto (se crea con el objeto Guante)
        /// </summary>
        [Test]
        public void Test4()
        {
            Assert.AreEqual(Dwarf20.Attack, 90);
        }

        /// <summary>
        /// Este test verifica que se pueda obtener el nombre del elemento que tiene
        /// el objeto Dwarf20 con el que fue creado
        /// </summary>
        [Test]
        public void Test5()
        {
            Assert.AreEqual(Dwarf20.Guante1.Name, "Guante1");
        }
        
        /// <summary>
        /// Este test verifica que al aplicarse el metodo curar 
        /// la vida del objeto sea seteada a 100
        /// </summary>
        [Test]
        public void Test6()
        {
            Dwarf20.ReceiveAttack(Dwarf30);
            Dwarf20.Curar();
            Assert.AreEqual(Dwarf20.Health, 100 );
        }
        /// <summary>
        /// Este test verifica que al aplicarse el metodo curar 
        /// cuando la vida del objeto no sea menor a 100 quede con la vida que está
        /// </summary>
        [Test]
        public void Test7()
        {
            Dwarf20.Curar();
            Assert.AreEqual(Dwarf20.Health, 170);
        }
    }
}