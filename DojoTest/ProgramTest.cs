using Dojo_20130829;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DojoTest
{

    [TestClass()]
    public class ProgramTest
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        [TestMethod()]
        public void saque10retorna10()
        {
            Program target = new Program(); // TODO: Initialize to an appropriate value
            Dictionary<int,int> retorno = target.saque(10);
            Assert.AreEqual(1, retorno[10]);
        }

        [TestMethod()]
        public void saque30retorna1Nota20E1Nota10()
        {
            Program target = new Program(); // TODO: Initialize to an appropriate value
            Dictionary<int, int> retorno = target.saque(30);
            
            Dictionary<int, int> esperado = new Dictionary<int, int>(){ 
                {10,1},
                {20,1}
            };

            CollectionAssert.AreEquivalent(esperado, retorno);
        }

        [TestMethod()]
        public void saque45retorna2Nota20E1Nota5()
        {
            Program target = new Program(); // TODO: Initialize to an appropriate value
            Dictionary<int, int> retorno = target.saque(45);

            Dictionary<int, int> esperado = new Dictionary<int, int>(){ 
                {5,1},
                {20,2}
            };

            CollectionAssert.AreEquivalent(esperado, retorno);
        }

        [TestMethod()]
        public void saque112()
        {
            Program target = new Program(); // TODO: Initialize to an appropriate value
            Dictionary<int, int> retorno = target.saque(112);

            Dictionary<int, int> esperado = new Dictionary<int, int>(){ 
                {2,1},
                {10,1},
                {100,1}
            };

            CollectionAssert.AreEquivalent(esperado, retorno);
        }

        [TestMethod()]
        public void saque422()
        {
            Program target = new Program(); // TODO: Initialize to an appropriate value
            Dictionary<int, int> retorno = target.saque(422);

            Dictionary<int, int> esperado = new Dictionary<int, int>(){ 
                {2,1},
                {20,1},
                {100,4}
            };

            CollectionAssert.AreEquivalent(esperado, retorno);
        }

        [TestMethod()]
        public void saque13()
        {
            Program target = new Program(); // TODO: Initialize to an appropriate value
                     
            var retorno = new Dictionary<int, int>();
            Dictionary<int, int> esperado = new Dictionary<int, int>(){ 
                {2,1},
                {10,1},
                {1,1}
            };
            try
            {
                retorno = target.saque(13);
                Assert.Fail();
            }
            catch(Exception e) {
                Assert.AreEqual("Não é possível sacar o valor esperado.",e.Message);
            }

            
        }
    }
}
