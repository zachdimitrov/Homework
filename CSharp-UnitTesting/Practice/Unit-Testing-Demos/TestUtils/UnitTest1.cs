using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace TestUtils
{
    [TestClass]
    public class TestingUtils
    {
        [TestMethod]
        public void MathUtils_SumTwoNumebers()
        {
            var utils = new MathUtils();
            int a = 1;
            int b = 1;
            var res = 2;
            var result = utils.Sum(a, b);
            Assert.AreEqual(res, result);
        }
        /*
        private TestContext context;

        public TestContext Context
        {
            get { return context; }
            set { context = value; }
        }

        [DeploymentItem(".\\Data.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", ".\\Data.xml", "row", DataAccessMethod.Sequential)]
        public void MathUtils_SumTwoNumebers()
        {
            var utils = new MathUtils();
            int a = int.Parse((string)Context.DataRow["A"]);
            int b = int.Parse((string)Context.DataRow["B"]);
            var res = int.Parse((string)Context.DataRow["expected"]);
            var result = utils.Sum(a, b);
            Assert.AreEqual(res, result); 
        }*/
    }
}
