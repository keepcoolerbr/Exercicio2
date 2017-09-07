using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stream;

namespace Testes
{
    [TestClass]
    public class TesteStream
    {
        [TestMethod]
        public void TestVogalValid()
        {
            StreamString stream = new StreamString("aAbBABacfe");
            char resultado;

            try
            {
                resultado = stream.firstChar(stream);
            }
            catch (System.Exception)
            {
                resultado = ' ';
            }
            Assert.IsTrue(resultado != ' ');
        }

        [TestMethod]
        public void TestVogalInvalid()
        {
            StreamString stream = new StreamString("aaaaaaaaa");
            char resultado;

            try
            {
                resultado = stream.firstChar(stream);
            }
            catch (System.Exception)
            {
                resultado = ' ';
            }
            Assert.IsTrue(resultado == ' ');
        }
    }
}
