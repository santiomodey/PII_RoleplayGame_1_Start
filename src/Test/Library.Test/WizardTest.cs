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
        //Este test sirve para comprobar que el ataque se sume correctamente y se tenga en cuenta una defensa dada.
        [Test]
        public void ReceiveAttackTest()
        {
            W1.ReceiveAttack(W2.Attack);
            Assert.AreEqual(W1.Health, 40);
        }
        [Test]
        public void NameTest()
        {
            Assert.AreEqual("W1", W1.Name);
        }
        //Confirma que al recibir un ataque y volver a curarse esto funcione y vuelva a su vida inicial.
        [Test]
        public void HealTest()
        {
            W1.ReceiveAttack(W2.Attack);
            W1.Heal();
            Assert.AreEqual(W1.Health, 60);
        }
        //Confirma que la vida nunca pase a ser negativa.
        [Test]
        public void DeadTest()
        {
            W1.ReceiveAttack(W2.Attack);
            W1.ReceiveAttack(W2.Attack);
            W1.ReceiveAttack(W2.Attack);
            Assert.AreEqual(W1.Health, 0);
        }
        //Confirma que el hechizo del libro funciona aumentando la magia.
        [Test]
        public void SpellTest()
        {
            int MagiaAntes = W1.Magic;
            W1.Spellbook.AdquirirConocimiento(W1);
            Assert.Greater(W1.Magic, MagiaAntes);
        }

    }


}
