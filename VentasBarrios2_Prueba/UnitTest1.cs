using System;
using ex03_VentasBarrio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VentasBarrios2_Prueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IdentificaPromedioBarrio()
        {
            //arrange
            float[] promedioBarrios = new float[] { 55.35f, 58.94f, 58.22f, 54.08f, 48f };
            string[] nombresBarrios = new string[] { "Robledo", "Laureles", "Robledo", "Pradocentro", "´Poblado" };

            //act
            float mejorPromedio;
            string nombreMejorBarrio;

            Program.IdentificaPromedioBarrio(promedioBarrios, nombresBarrios, out mejorPromedio, out nombreMejorBarrio);
            float cantidadEsperada = 48f;
            string nombreEsperado = "Pradocentro";

            //assert
            Assert.AreEqual(cantidadEsperada, mejorPromedio);

            Assert.AreEqual(nombreEsperado, nombreMejorBarrio);


        }

        [TestMethod]
        public void TotalizaPedidosBarrios()
        {
            //arrange
            int cantidadGalletas = { 1120, 1001, 1200, 1560, 1000 };
            string[] nombresBarrios = new string[] { "Robledo", "Laureles", "Robledo", "Pradocentro", "´Poblado" };

            //act
            float cantidadPedidos;
            string nombrePedidosBarrio;

            Program.TotalizaPedidosBarrios(cantidadGalletas, nombresBarrios, out cantidadPedidos, out nombrePedidosBarrio);

            float cantidadEsperada = 1120;
            string nombreEsperado = "Pradocentro";

            //assert
            Assert.AreEqual(cantidadEsperada, cantidadPedidos);

            Assert.AreEqual(nombreEsperado, nombrePedidosBarrio);

        }
    }
}
