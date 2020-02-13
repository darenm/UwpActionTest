
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UwpActionTest.Lib.Models;

namespace UwpActionTest.Lib.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Person_Initialize()
        {
            var p = new Person();

            Assert.IsNotNull(p);
        }

        public void Person_Firstname()
        {
            var p = new Person();
            p.Age = 23;

            Assert.AreEqual(23, p.Age);
        }
    }
}
