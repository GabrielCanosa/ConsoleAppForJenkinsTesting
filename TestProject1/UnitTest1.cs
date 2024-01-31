namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int number1 = 5;

            // Acronym for sistem under test
            var sut = new Calculator();

            // Act
            sut.Add(number1);

            // Assert
            Assert.Equal(number1, sut.Value);
        }
    }
}