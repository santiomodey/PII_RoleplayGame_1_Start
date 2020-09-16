using NUnit.Framework;
using Library;
namespace Test.Library
{
    public class WizardTest{

        private Wizard W1;
        private Wizard W2;
        [SetUp]
        public void SetUp()
        {
            W1 = new Wizard("W1");
            W2 = new Wizard("W2");
        }

        [Test]
        public void ReceiveAttackTest()
        {
            W1.ReceiveAttack(W2.Attack);
            Assert.AreEqual(W1.Health, 80);
        }
        [Test]
        public void NameTest()
        {
            Assert.AreEqual("W1", W1.Name);
        }
        [Test]
        public void HealTest()
        {
            W1.ReceiveAttack(W2.Attack);
            W1.Heal();
            Assert.AreEqual(W1.Health, 200);
        }
        [Test]
        public void DeadTest()
        {
            W1.ReceiveAttack(W2.Attack);
            W1.ReceiveAttack(W2.Attack);
            W1.Dead();
            Assert.AreEqual(W1.Health, 0);
        }

    }


}
