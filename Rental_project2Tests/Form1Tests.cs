using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rental_project2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rental_project2;
namespace Rental_project2.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            sqlDatabaseConnection connection = new sqlDatabaseConnection();
            connection.addMovie("tiger","4.5","2019","5","5","fight","gud");
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void Form2Test()
        {
            sqlDatabaseConnection connection = new sqlDatabaseConnection();
            connection.deleteMovie(1);
            Assert.IsTrue(true);
        }

    }
}