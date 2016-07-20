namespace GildedRose.Console.UnitTest
{
    public class TestAssemblyTests
    {
        [Fact]
        public void TestTheTruth()
        {
            bool actual = true;
            actual.Should().Be(true);
        }
    }
}