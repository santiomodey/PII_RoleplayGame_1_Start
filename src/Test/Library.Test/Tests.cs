using NUnit.Framework;
using Library;


namespace Tests
{


    public class Tests
    {
        private Library.Test Dwarf1;
        public void Setup()
        {
   
            Dwarf Dwarf1 = new Dwarf("Dwarf1");

        }


        [Test]
        public void Test1()
        {
            Assert.AreEquals(Dwarf1.Health, 100);
        }

    }

}