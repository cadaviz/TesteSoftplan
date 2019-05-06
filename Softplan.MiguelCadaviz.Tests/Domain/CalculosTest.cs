using Microsoft.VisualStudio.TestTools.UnitTesting;
using Softplan.MiguelCadaviz.WebApi.Domain;
using System;

namespace Softplan.MiguelCadaviz.Tests.Domain
{
    [TestClass]
    public class CalculosTest
    {
        [TestMethod]
        public void CalcularJurosCompostos_ValidarValor()
        {
            // arrange
            decimal valorInicial = 100;
            int quantidadeMeses = 5;
            decimal resultadoEsperado = 105.1010050100m;

            // act
            var resultadoAtual = Calculos.CalcularJurosCompostos(valorInicial, quantidadeMeses);

            // assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void Truncar_ValidarValor()
        {
            // arrange
            decimal valor = 10.9999m;
            int casasDecimais = 2;
            decimal resultadoEsperado = 10.99m;

            // act
            var resultadoAtual = Calculos.Truncar(valor, casasDecimais);

            // assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void Truncar_ValorNegativo()
        {
            // arrange
            decimal valor = -15.6789m;
            int casasDecimais = 1;
            decimal resultadoEsperado = -15.6m;

            // act
            var resultadoAtual = Calculos.Truncar(valor, casasDecimais);

            // assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Truncar_LimiteCasasDecimais()
        {
            // arrange
            decimal valor = 0.123456789012m;
            int casasDecimais = 11;
            
            // act
            var resultadoAtual = Calculos.Truncar(valor, casasDecimais);
        }
    }
}
