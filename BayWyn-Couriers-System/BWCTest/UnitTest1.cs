using BayWyn_Couriers_System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
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

            // Success: var result = Log.LoginStatus("C01", "Fa79^3s2AH5T");

            // Assert

            //Assert.AreEqual(Expected, result);
        }
    }
}
