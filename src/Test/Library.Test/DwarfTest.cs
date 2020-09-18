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

        [Test]
        public void Test2()
        {
            Dwarf20.ReceiveAttack(Dwarf30);
            Assert.AreEqual(Dwarf20.Health, 80);
        }

        [Test]
        public void Test3()
        {
            Dwarf20.ReceiveAttack(Dwarf30);
            Dwarf20.ReceiveAttack(Dwarf30);
            Assert.AreEqual(Dwarf20.Health, 0);
        } 
        
        [Test]
        public void Test4()
        {
            Assert.AreEqual(Dwarf20.Attack, 90);
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(Dwarf20.Guante1.Name, "Guante1");
        }
    }
}