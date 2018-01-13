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

        [Fact]
        public void CallOutputWriterWithFizzBuzzerResultForFirst100NaturalNumbers_WhenItIsRun()
        {
            var stubFizzBuzzer = new Mock<IFizzBuzzer>();
            stubFizzBuzzer.Setup(x => x.GetNumberFizzBuzzed(1)).Returns("1");
            stubFizzBuzzer.Setup(x => x.GetNumberFizzBuzzed(2)).Returns("2");
            stubFizzBuzzer.Setup(x => x.GetNumberFizzBuzzed(100)).Returns("100");
            var mockOutputWriter = new Mock<IOutputWriter>();
            mockOutputWriter.Setup(x => x.WriteLine("1"));
            mockOutputWriter.Setup(x => x.WriteLine("2"));
            mockOutputWriter.Setup(x => x.WriteLine("100"));
            var app = new App(fizzBuzzer: stubFizzBuzzer.Object, outputWriter: mockOutputWriter.Object);

            app.Run();

            mockOutputWriter.Verify(x => x.WriteLine("1"), Times.Once);
            mockOutputWriter.Verify(x => x.WriteLine("2"), Times.Once);
            mockOutputWriter.Verify(x => x.WriteLine("100"), Times.Once);
            mockOutputWriter.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(100));
        }
    }
}
