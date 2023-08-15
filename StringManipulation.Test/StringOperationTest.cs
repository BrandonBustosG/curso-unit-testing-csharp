namespace StringManipulation.Test
{
	public class StringOperationTest
	{
		// Que_Vamos_A_Probar
		// El_Escenario
		// Lo_que_debe_arrojar

		[Fact(Skip = "Esta prueba no es valida en este momento, Ticket-001")]
		public void ConcatenateStrings()
		{
			// Arange
			// Se configura los parametros de entrada de nuestra prueba unitaria
			var strOperations = new StringOperations();

			// Act
			// Se ejecuta el metodo a probar de nuestra prueba unitaria
			var result = strOperations.ConcatenateStrings("Hello", "Brandon");

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

		[Theory]
		[InlineData("He ll o", "Hello")]
		[InlineData("c a r", "car")]
		public void RemoveWhitespace(string word, string expected)
		{
			// Arrange
			var strOperations = new StringOperations();

			// Act
			var result = strOperations.RemoveWhitespace(word);

			// Assert
			Assert.Equal(expected,result);
		}

		[Fact(Skip = "Esta prueba no es valida en este momento ya que esta en español, Ticket-002")]
		public void QuantintyInWords()
		{
			// Arrange
			var strOperations = new StringOperations();

			// Act
			var result = strOperations.QuantintyInWords("cat", 10);

			// Assert
			Assert.StartsWith("ten", result);
			Assert.Contains("cat", result);
		}

		[Fact]
		public void TruncateStringException()
		{
			// Arrange
			var strOperations = new StringOperations();

			// Assert
			Assert.ThrowsAny<ArgumentNullException>(() => strOperations.GetStringLength(null));
		}

		[Fact]
		public void TruncateString()
		{
			// Arrange
			var strOperations = new StringOperations();

			// Act
			var result = strOperations.TruncateString("hello".ToUpper(), 2);

			// Assert
			Assert.Equal("he".ToUpper(), result);
		}

		[Theory]
		[InlineData("V",5)]
		[InlineData("III", 3)]
		[InlineData("X", 10)]
		public void FromRomanToNumber(string romanNumber, int expected)
		{
			// Arrange
			var strOperations = new StringOperations();

			// Act
			var result = strOperations.FromRomanToNumber(romanNumber);

			// Assert
			Assert.Equal(expected, result);
		}

	}
}
