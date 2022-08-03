using Entidades;
using Entidades.Enumerados;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Serializable;
using System.IO;

namespace UnitTestTPFinal
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void FinalizarProcesoValido()
        {
            //ARRAGE
            Nacional nacional = new Nacional(3, "Bordadora", "Nacional", "Lucas", 1000, "Excelente");
            bool respuesta = false;
            //ACT
            respuesta = Tela.Finalizar(nacional);
            //ASSERT
            Assert.IsTrue(respuesta);
        }
        [TestMethod]
        public void FinalizarProcesoInvalido()
        {
            //ARRAGE
            Nacional nacional = new Nacional(3, "Distribucion", "Nacional", "Kevin", 1000, "Excelente");
            bool respuesta = false;
            //ACT
            respuesta = Tela.Finalizar(nacional);
            //ASSERT
            Assert.IsFalse(respuesta);
        }
        [TestMethod]
        public void GuardarTxtPruebaFalse()
        {
            bool respuesta = false;
            List<Mensaje> listaMensajes = new List<Mensaje>();
            foreach (Mensaje item in listaMensajes)
            {
                respuesta = item.GuardarTxt();
            }
            Assert.IsFalse(respuesta);
        }
        [TestMethod]
        public void GuardarTxtPruebaTrue()
        {
            bool respuesta = false;
            List<Mensaje> listaMensajes = new List<Mensaje>();
            Mensaje miMensaje = new Mensaje("Bordadora",
                                            "Nacional",
                                            "Javier",
                                            "100",
                                            "Malo");
            MensajeCargado.Mensaje = miMensaje;
            listaMensajes = listaMensajes + miMensaje;
            foreach (Mensaje item in listaMensajes)
            {
                respuesta = item.GuardarTxt();
            }
            Assert.IsTrue(respuesta);
        }
    }
}
