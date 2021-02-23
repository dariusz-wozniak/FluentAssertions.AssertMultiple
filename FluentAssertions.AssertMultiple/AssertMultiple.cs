using System;
using System.Threading.Tasks;
using FluentAssertions.Execution;

namespace FluentAssertions.AssertMultiple
{
    public class AssertMultiple
    {
        public static void Multiple(Action act)
        {
            using (new AssertionScope()) act();
        }

        public static async Task MultipleAsync(Func<Task> act)
        {
            using (new AssertionScope()) await act();
        }
    }
}
