using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace deployTest
{
    [TestClass]
    public class TestHesapla
    {
        [TestMethod]
        public void testTopla()
        {
            //Arrange
            deploy.Hesapla hesap = new deploy.Hesapla();

            //Act
            int sonuc = hesap.topla(20, 10);

            //Assert
            Assert.AreEqual(30, sonuc);
        }

    }
}
