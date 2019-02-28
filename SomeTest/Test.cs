using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTest
{
    [TestClass]
    public class Test
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            List<int> expected = new List<int>{ 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 };
            Fibonachi.Fibonachi20 item = new Fibonachi.Fibonachi20();
            List<int> actual = (List<int>)item.FirstTwenty();
            int count = 0;
            for (int i = 0; i < 21; i++)
            {
                if (expected.ToArray()[i] == actual.ToArray()[i]) count++;
            }
            Assert.AreEqual(21, count);
        }
    }
}
