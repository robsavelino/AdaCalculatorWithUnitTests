using FluentAssertions;
using Moq;

namespace AdaCalculator.UnitTests
{
    public class CalculatorUnitTests
    {
        private CalculatorMachine sut;
        private Mock<ICalculator> mockCalculator;

        public CalculatorUnitTests()
        { 
            mockCalculator = new Mock<ICalculator>();
            sut = new CalculatorMachine(mockCalculator.Object);
        }

        [Theory]
        [InlineData("sum", 1, 2, 3)]
        public void Calculate_ChecksIfItsDoingSum_ShoudExecuteOnce(string operation, double a, double b, double result)
        {
            mockCalculator.Setup(x => x.Calculate(operation, a, b)).Returns((operation, result));
            sut.Calculate(operation, a, b);
            mockCalculator.Verify(x => x.Calculate(operation, a, b), Times.Once);
        }

        [Theory]
        [InlineData("subtract", 2, 1, 1)]
        public void Calculate_ChecksIfItsDoingSubtraction_ShouldExecuteOnce(string operation, double a, double b, double result)
        {
            mockCalculator.Setup(x => x.Calculate(operation, a, b)).Returns((operation, result));
            sut.Calculate(operation, a, b);
            mockCalculator.Verify(x => x.Calculate(operation, a, b), Times.Once);
        }

        [Theory]
        [InlineData("divide", 4, 2, 2)]

        public void Calculate_ChecksIfItsDoingDivision_ShouldExecuteOnce(string operation, double a, double b, double result)
        {
            mockCalculator.Setup(x => x.Calculate(operation, a, b)).Returns((operation, result));
            sut.Calculate(operation, a, b);
            mockCalculator.Verify(x => x.Calculate(operation, a, b), Times.Once);
        }

        [Theory]
        [InlineData("multiply", 2, 3, 6)]
        public void Calculate_ChecksIfItsDoingMultiplication_ShouldExecuteOnce(string operation, double a, double b, double result)
        {
            mockCalculator.Setup(x => x.Calculate(operation, a, b)).Returns((operation, result));
            sut.Calculate(operation, a, b);
            mockCalculator.Verify(x => x.Calculate(operation, a, b), Times.Once);
        }

    }
}