using System;
using FluentAssertions.Execution;

namespace FluentAssertions.AssertMultiple
{
    public class AssertMultiple
    {
        public static void Multiple(Action act)
        {
            using (new AssertionScope()) act();
        }
    }
}
