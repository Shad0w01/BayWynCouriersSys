using BayWyn_Couriers_System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BWCTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1Login()
        {
            frmBWCLogin Log = new frmBWCLogin();

            // Arrange

            bool Expected = true;

        // Act

        Success: var result = Log.LoginStatus("Jones81", "X5fw3Q3!yAt9");

            // Assert

            Assert.AreEqual(Expected, result);
        }
    }
}
