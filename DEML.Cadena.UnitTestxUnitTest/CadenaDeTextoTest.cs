using DEML.CadenaDeTexto;

namespace DEML.Cadena.UnitTestxUnitTest
{
    public class CadenaDeTextoTest
    {
        private readonly ManipuladorDeCadenas _manipuladorDeCadenas;

        public CadenaDeTextoTest()
        {
            _manipuladorDeCadenas = new ManipuladorDeCadenas();
        }

        [Fact]
        public void ReverseString_DeberiaInvertirCadena()
        {
            // Arrange
            string entrada = "hola";

            // Act
            string resultado = _manipuladorDeCadenas.ReverseString(entrada);

            // Assert
            Assert.Equal("aloh", resultado);
        }

        [Fact]
        public void RemoveSpaces_DeberiaEliminarEspaciosEnBlanco()
        {
            // Arrange
            string entrada = "h o l a";

            // Act
            string resultado = _manipuladorDeCadenas.RemoveSpaces(entrada);

            // Assert
            Assert.Equal("hola", resultado);
        }
    }
}
