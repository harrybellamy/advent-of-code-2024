using Day2;

namespace Day2Tests
{
    public class ReportTests
    {
        [Fact]
        public void IsSafeTest1()
        {
            var report = Report.Create("7 6 4 2 1");

            Assert.True(report.IsSafe);
        }

        [Fact]
        public void IsSafeTest2()
        {
            var report = Report.Create("1 2 7 8 9");

            Assert.False(report.IsSafe);
        }

        [Fact]
        public void IsSafeTest3()
        {
            var report = Report.Create("1 3 2 4 5");

            Assert.False(report.IsSafe);
        }
    }
}