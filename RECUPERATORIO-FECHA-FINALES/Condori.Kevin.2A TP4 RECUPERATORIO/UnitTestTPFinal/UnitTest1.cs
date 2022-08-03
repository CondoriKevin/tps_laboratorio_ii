using Entidades;
using Entidades.Enumerados;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestTPFinal
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void FinalizarProcesoValido()
        {
            //ARRAGE
            Stock stock = new Stock("lista");
            Nacional arrabio = new Nacional(EMaquina.Bordadora, "Nacional", "Javier", 1000, ECalidadTela.Excelente);
            bool respuesta = false;
            //ACT
            respuesta = stock.Finalizar(arrabio);
            //ASSERT
            Assert.IsTrue(respuesta);
        }
        [TestMethod]
        public void FinalizarProcesoInvalido()
        {
            //ARRAGE
            Stock stock = new Stock("lista");
            Nacional arrabio = new Nacional(EMaquina.AMano, "Nacional", "Lucas", 1000, ECalidadTela.Excelente);
            bool respuesta = false;
            //ACT
            respuesta = stock.Finalizar(arrabio);
            //ASSERT
            Assert.IsFalse(respuesta);
        }
    }
}