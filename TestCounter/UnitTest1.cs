using CounterLib;

namespace TestCounter
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdamKimOutput()
        {
            var obj = new PrintNumbersAndNames();

            var text = obj.PrintAdamKim(5);

            var expectedOutput = 
@"1
2
Adam
4
Kim
";
            Assert.Equal(text, expectedOutput);
        }

        [Fact]
        public void TestPrintNamesSometimes()
        {
            var obj = new PrintNumbersAndNames();

            var text = obj.PrintNamesSometimes(5, (3, 5), ("Adam", "Kim"));

            var expectedOutput =
@"1
2
Adam
4
Kim
";
            Assert.Equal(text, expectedOutput);
        }

        [Fact]
        public void TestPrintNamesSometimesWithOtherNamesAndValues()
        {
            var obj = new PrintNumbersAndNames();

            var text = obj.PrintNamesSometimes(20, (4, 6), ("Clear", "Measure"));

            var expectedOutput =
@"1
2
3
Clear
5
Measure
7
Clear
9
10
11
Clear Measure
13
14
15
Clear
17
Measure
19
Clear
";
            Assert.Equal(text, expectedOutput);
        }
    }
}