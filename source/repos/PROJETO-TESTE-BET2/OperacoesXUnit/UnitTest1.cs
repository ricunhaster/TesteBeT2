using PROJETO_TESTE_BET2;
using Xunit;

namespace OperacoesXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros_RetornarResultado()
        {
            //Arrange
            double primeiroNumero = 1;
            double segundNumero = 2;
            double resultadoEsperado = 3;

            //Act
            var resultado = Operacoes.Somar(primeiroNumero, segundNumero);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);

        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 4, 6)]

        public void SomarDoisNumeros_RetornarResultado_Multiplos(double pNum, double sNum, double tNum)
        {
            //Act
            var resultado = (Operacoes.Somar(pNum, sNum));

            //Assert
            Assert.Equal(tNum, resultado);
        }
    }
}