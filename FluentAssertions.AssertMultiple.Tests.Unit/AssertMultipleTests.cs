using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FluentAssertions.AssertMultiple.Tests.Unit
{
    public class AssertMultipleTests
    {
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
                Console.WriteLine(exception.Message);

                exception.Message.Should().Contain("to be 5, but found 4")
                     .And.Subject.Should().Contain("to be 6, but found 4.");
                //                                        ⬆ differs here
            }
        }


        [Test]
        public async Task AsyncAssertionShouldBeRunMultipleTimes()
        {
            try
            {
                await AssertMultiple.MultipleAsync(async () =>
                {
                    (2 + 2).Should().Be(5);
                    await Task.Delay(200);
                    (2 + 2).Should().Be(6);
                });
            }
            catch (AssertionException exception)
            {
                Console.WriteLine(exception.Message);

                exception.Message.Should().Contain("to be 5, but found 4")
                     .And.Subject.Should().Contain("to be 6, but found 4.");
                //                                        ⬆ differs here
            }
        }
    }
}
