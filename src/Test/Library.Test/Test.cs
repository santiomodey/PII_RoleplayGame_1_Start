using NUnit.Framework;
using Library;

namespace Test.Library
{
   
    public class Test
    {
         private Elf elf;
         private Elf elf1;

        [SetUp]
        public void SetUp()
        {
            elf = new Elf("Elf");
            elf1 = new Elf("Elf1");
        }
        //Ataque a elf1 y comprueba que la vida sea correcta
        [Test]
        public void Test1()
        {
             elf.ReceiveOther(elf1.Attack);
             Assert.AreEqual(elf.Health,60);

        }
        //Comprueba el nombre si es correcto
        [Test]
        public void Test2()
        {
             Assert.AreEqual(elf.Name,"Elf");

        }
        //Comprueba que la vida no baja de 0
        [Test]
        public void Test3()
        {
             elf.ReceiveOther(elf1.Attack);
             elf.ReceiveOther(elf1.Attack);
             elf.ReceiveOther(elf1.Attack);
             Assert.AreEqual(elf.Health,0);

        }
        //Lo atacan y lo recupera la vida
         [Test]
        public void Test4()
        {
            elf.ReceiveOther(elf1.Attack);
            elf.Heal();
            Assert.AreEqual(elf.Health, 100);

        }
        
        

        
    }


}