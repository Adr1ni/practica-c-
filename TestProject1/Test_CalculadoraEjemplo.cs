using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica.Test;

namespace TestProject1
{
    [TestClass]
    public class Test_CalculadoraEjemplo
    {
        [TestMethod]
        public void Test_Calcular_Suma()
        {
            //Arrange : Inicializar las variables
            int sumando1 = 2;
            int sumando2 = 3;

            //Act : llamar al metodo a testear
            int resultado = CalculadoraEjemplo.Suma(sumando1, sumando2);

            //Assert: comprobar el valor con el esperado.
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Test_Calcualr_Resta()
        {
            int rest1 = 5;
            int rest2 = 3;

            int resultado = CalculadoraEjemplo.Resta(rest1, rest2);

            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void Test_Calcual_Dividir()
        {
            int rest1 = 15;
            int rest2 = 3;

            double resultado = CalculadoraEjemplo.Division(rest1, rest2);

            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Calcual_Dividir_Por_Cero()
        {
            int rest1 = 15;
            int rest2 = 0;

            double resultado = CalculadoraEjemplo.Division(rest1, rest2);
        }
    }
}
