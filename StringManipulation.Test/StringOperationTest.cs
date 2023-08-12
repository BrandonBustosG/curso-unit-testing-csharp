namespace StringManipulation.Test
{
	public class StringOperationTest
	{
		// Que_Vamos_A_Probar
		// El_Escenario
		// Lo_que_debe_arrojar

		[Fact]
		public void ConcatenateStrings()
		{
			// Arange
			// Se configura los parametros de entrada de nuestra prueba unitaria
			var strOperations = new StringOperations();

			// Act
			// Se ejecuta el metodo a probar de nuestra prueba unitaria
			var result = strOperations.ConcatenateStrings("Hello","Brandon");

			// Assert
			// Se verifica los datos de retorno de nuestro metodo probado en la prueba unitaria
			Assert.NotNull(result);
			Assert.NotEmpty(result);
			Assert.Equal("Hello Brandon", result);
		}

		[Fact]
		public void IsPalindromeTrue()
		{
			// Arrange
			var strOperations = new StringOperations();

			// Act
			var result = strOperations.IsPalindrome("ama");

			// Assert
			Assert.True(result);
		}

		[Fact]
		public void IsPalindromeFalse()
		{
			// Arrange
			var strOperations = new StringOperations();

			// Act
			var result = strOperations.IsPalindrome("Hello");

			// Assert
			Assert.False(result);
		}

		[Fact]
		public void RemoveWhitespace()
		{
			// Arrange
			var strOperations = new StringOperations();

			// Act
			var result = strOperations.RemoveWhitespace("H e l l o");

			// Assert
			Assert.Equal("Hello", result);
		}

	}
}
