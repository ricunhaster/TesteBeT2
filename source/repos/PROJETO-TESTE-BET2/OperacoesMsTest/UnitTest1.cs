using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROJETO_TESTE_BET2;

namespace OperacoesMsTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void SomarDoisNumeros_RetornarResultado()
        {
            //Arrange
            double primeiroNumero = 1;
            double segundNumero = 2;
            double resultadoEsperado = 3;
            
            //Act
            var resultado = Operacoes.Somar(primeiroNumero, segundNumero) ;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 3, 5)]
        [DataRow(3, 4, 6)]
        public void SomarDoisNumeros_RetornarResultado_Multiplos(double pNum, double sNum, double tNum )
        {
            //Act
            var resultado = (Operacoes.Somar(pNum, sNum));

            //Assert
            Assert.AreEqual(tNum, resultado);
        }
    }
} 