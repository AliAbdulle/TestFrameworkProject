using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkProject
{
    [TestFixture]
    [Parallelizable]
    public class Simpletest
    {
        [Test]
        public void testMethod()
        {
           Console.WriteLine("Test Method");
        }
        [Test]
        public void testLogin()
        {
            Console.WriteLine("Test log in");
        }
    }
}
