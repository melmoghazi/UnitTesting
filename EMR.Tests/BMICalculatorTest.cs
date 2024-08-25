namespace EMR.Tests
{
    public class BMICalculatorTest
    {
        [Fact]
        public void CalculateBMI_HeightGraterThanZeroAndWeightGraterThanZero_ShouldCalculateBMICorrectly()
        {
            //Arrange يرتب
            //Prepare any prerequisites like initialize variables
            // sut name the variable of the test class (Subject Under Test)
            var sut = new BMICalculator();

            //Act يفعل
            //execute the method you need to test
            var result = Math.Round(sut.CalculateBMI(1.75, 90), 2);

            //Assert يؤكد
            //test the result and check if it as you expect or not
            Assert.Equal(29.39, result);
        }
        [Fact]
        public void CalculateBMI_HeightIsZeroAndWeightIsZero_ShouldCalculateBMICorrectly()
        {
            //Arrange يرتب
            //Prepare any prerequisites like initialize variables
            // sut name the variable of the test class (Subject Under Test)
            var sut = new BMICalculator();

            //Act يفعل
            //execute the method you need to test
            var result = Math.Round(sut.CalculateBMI(0, 0), 2);

            //Assert يؤكد
            //test the result and check if it as you expect or not
            Assert.Equal(0, result);
        }
        [Fact]
        public void CalculateBMI_HeightIsZeroAndWeightIsNotZero_ShouldCalculateBMICorrectly()
        {
            //Arrange يرتب
            var sut = new BMICalculator();
            //Act يفعل
            var result = Math.Round(sut.CalculateBMI(0, 90), 2);
            //Assert يؤكد
            Assert.Equal(0, result);
        }
        [Fact]
        public void CalculateBMI_HeightIsNotZeroAndWeightIsNotZero_ShouldCalculateBMICorrectly()
        {
            //Arrange يرتب
            var sut = new BMICalculator();
            //Act يفعل
            var result = Math.Round(sut.CalculateBMI(1.75, 0), 2);
            //Assert يؤكد
            Assert.Equal(0, result);
        }
    }
}