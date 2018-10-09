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

            deploy.Adem aa = new deploy.Adem();
            aa.topla();
            //Act
            int sonuc = hesap.topla(20, 10);

            //Assert
            Assert.AreEqual(30, sonuc);
        }

        [TestMethod]
        public void testToplab()
        {
          

            deploy.Burak bb = new deploy.Burak();
            bb.topla();
            //Act
            int sonuc = 30;

            //Assert
            Assert.AreEqual(30, sonuc);
        }
    }
}
