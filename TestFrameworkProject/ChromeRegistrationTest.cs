using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkProject
{
    [TestFixture]
    public class ChromeRegistrationTest
    {
        [Test, TestCaseSource("registerData")]
        public void TestRegister(string userName, string password, string email, string city)
        {
            //Selenium code
            //UserName
            //Password
            //email
            //City
            Console.WriteLine(userName + "--" + password + "--" + email + "--" + city + "--");
        }
       
        //data source
        public static object[] registerData()
        {
            // row - number of times test has to excuted
            //colums -number of paramsters

            object[][] data = new object[3][];
            //first row
            data[0] = new object[4];
            data[0][0] = "user1";
            data[0][1] = "password1";
            data[0][2] = "email1";
            data[0][3] = "city1";

            //second row
            data[1] = new object[4];
            data[1][0] = "user2";
            data[1][1] = "password2";
            data[1][2] = "email2";
            data[1][3] = "city2";

            //third row
            data[2] = new object[4];
            data[2][0] = "user3";
            data[2][1] = "password3";
            data[2][2] = "email3";
            data[2][3] = "city3";

            return data;
        }

    }
}
