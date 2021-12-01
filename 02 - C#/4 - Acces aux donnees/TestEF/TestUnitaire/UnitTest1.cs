using NUnit.Framework;
using TestEF.Data.Models;

namespace TestUnitaire
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Personne newPersonne = new Personne();
            Assert.Pass();
        }
    }
}