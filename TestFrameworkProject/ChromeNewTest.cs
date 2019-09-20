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
    [Ignore("Skip test")]
    class ChromeNewTest
    {
        [Test]
        public void testNews()
        {
            Console.WriteLine("Test News");
        }
    }
}
