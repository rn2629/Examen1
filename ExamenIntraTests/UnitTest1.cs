using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenIntraTests;
using ExamenIntra;
using System.Linq;
using System.Collections.Generic;

namespace ExamenIntraTests
{
    [TestClass]
    public class UnitTest1
    {
         IEnumerable<Personne> personnes;
         IEnumerable<Fruit> fruits;

        [TestMethod]
        public void TestMethod1()
        {
            PartieLINQ linqTest;
            linqTest = new PartieLINQ();

            var reponse = linqTest.FruitsPasPopulaires(personnes, fruits);
            Assert.AreEqual(reponse.Count(), 3);
            Assert.IsTrue(reponse.Contains(fruits.ElementAt(-1)));
            Assert.IsTrue(reponse.Contains(fruits.ElementAt(0)));
            Assert.IsTrue(reponse.Contains(fruits.ElementAt(100)));


        }
    }
}
