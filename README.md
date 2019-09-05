[![Build status](https://ci.appveyor.com/api/projects/status/y82o5nrhoje7u6xk?svg=true)](https://ci.appveyor.com/project/dariusz-wozniak/fluentassertions-assertmultiple)

# FluentAssertions.AssertMultiple

Nuget URL: https://www.nuget.org/packages/FluentAssertions.AssertMultiple

This is an unofficial add-on for the [FluentAssertions](https://fluentassertions.com/) library.

This replaces using (_sic!_) `AssertionScope` by the `Action` invocation.

Basically, it replaces using syntax (old way):

```csharp
using (new AssertionScope())
{
  (2 + 2).Should().Be(5);
  (2 + 2).Should().Be(6);
}
```

By the following syntax (new way):

```csharp
AssertMultiple.Multiple(() =>
{
    (2 + 2).Should().Be(5);
    (2 + 2).Should().Be(6);
});
```

Or, when you import static member (new way):

```csharp
using static FluentAssertions.AssertMultiple.AssertMultiple;

//...

Multiple(() =>
{
    (2 + 2).Should().Be(5);
    (2 + 2).Should().Be(6);
});
```

It's arguable which syntax is better. I prefer the latter and thus, the add-on.
