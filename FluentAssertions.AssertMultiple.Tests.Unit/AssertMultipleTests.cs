using NUnit.Framework;

namespace FluentAssertions.AssertMultiple.Tests.Unit
{
    public class AssertMultipleTests
    {
        private const string Newline = "\r\n";

        [Test]
        public void AssertionShouldBeRunMultipleTimes()
        {
            try
            {
                AssertMultiple.Multiple(() =>
                {
                    (2 + 2).Should().Be(5);
                    (2 + 2).Should().Be(6);
                });
            }
            catch (AssertionException exception)
            {
                exception.Message
                    .Should()
                    .Be($"Expected (2 + 2) to be 5, but found 4.{Newline}Expected (2 + 2) to be 6, but found 4.{Newline}");
            }
        }
    }
}
