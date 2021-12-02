using Primeiro;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Tests
{
    [TestClass()]
    public class ContaTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 10;
            var contas = new Conta();
            var result = contas.Soma(a, b);
            Assert.AreEqual(esperado,result);
        }

        [TestMethod()]
        public void SubtrairTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 0;
            var contas = new Conta();
            var result = contas.Subtrair(a, b);
            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void DividirTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 1;
            var contas = new Conta();
            var result = contas.Dividir(a, b);
            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void MultiplicarTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 25;
            var contas = new Conta();
            var result = contas.Multiplicar(a, b);
            Assert.AreEqual(esperado, result);
        }
    }
}