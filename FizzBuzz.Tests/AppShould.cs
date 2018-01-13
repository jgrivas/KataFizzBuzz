using Moq;
using Xunit;

namespace FizzBuzz.Tests
{
    public class AppShould
    {
        [Fact]
        public void CallFizzBuzzerForFirst100NaturalNumbers_WhenItIsRun()
        {
            var mockFizzBuzzer = new Mock<IFizzBuzzer>();
            mockFizzBuzzer.Setup(x => x.GetNumberFizzBuzzed(It.IsAny<int>())).Returns(string.Empty);
            var stubOutputWriter = new Mock<IOutputWriter>();
            var app = new App(fizzBuzzer: mockFizzBuzzer.Object, outputWriter: stubOutputWriter.Object);

            app.Run();

            mockFizzBuzzer.Verify(x => x.GetNumberFizzBuzzed(1), Times.Once);
            mockFizzBuzzer.Verify(x => x.GetNumberFizzBuzzed(2), Times.Once);
            mockFizzBuzzer.Verify(x => x.GetNumberFizzBuzzed(100), Times.Once);
            mockFizzBuzzer.Verify(x => x.GetNumberFizzBuzzed(It.IsAny<int>()), Times.Exactly(100));
        }
    }
}
