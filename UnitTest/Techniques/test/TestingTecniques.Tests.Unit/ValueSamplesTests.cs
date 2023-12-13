using FluentAssertions;
using Xunit;

namespace TestingTecniques.Tests.Unit;
public class ValueSamplesTests
{
    private readonly ValueSamples _sut = new();

    [Fact]
    public void StringAssertionExample()
    {
        var fullName = _sut.FullName;

        fullName.Should().Be("Taner Saydam");
        fullName.Should().NotBeEmpty();
        fullName.Should().StartWith("Ta");
        fullName.Should().EndWith("Saydam");        
    }

    [Fact]
    public void NumberAssertionExample()
    {
        var age = _sut.Age;

        age.Should().Be(33);
        age.Should().BePositive();
        age.Should().BeGreaterThan(20);
        age.Should().BeLessThanOrEqualTo(33);
        age.Should().BeInRange(20, 50);
    }

    [Fact]
    public void DateAssertionExample()
    {
        var date = _sut.Date;

        date.Should().Be(new(2023, 12, 13));
        date.Should().BeAfter(new(2000, 01, 01));
        date.Should().BeBefore(new(2050, 01, 01));
    }

    [Fact]
    public void ObjectAssertionExample()
    {
        var expected = new User()
        {
            FullName = "Taner Saydam",
            Age = 33
        };

        var user = _sut.AppUser;

        user.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void EnumrableObjectAssertionExample()
    {
        var expected = new User()
        {
            FullName = "Taner Saydam",
            Age = 33
        };

        var users = _sut.Users;

        users.Should().ContainEquivalentOf(expected);
        users.Should().HaveCount(3);
        users.Should().Contain(x => x.FullName.StartsWith("Taner"));
    }

    [Fact]
    public void EnumrableNumberAssertionExample()
    {
        var numbers = _sut.Numbers.As<int[]>();

        numbers.Should().Contain(5);
    }

    [Fact]
    public void Divide_ShouldExceptionThrown_WhenOneOfParametersZero()
    {
        Action result = () => _sut.Divide(0, 1);                               

        result.Should().Throw<DivideByZeroException>().WithMessage("Attempted to divide by zero.");
    }

    [Fact]
    public void InternalAssertionExample()
    {
        var secretNumber = _sut.InternalSecretNumber;

        secretNumber.Should().Be(42);
    }

    [Fact]
    public void EventRaisedAssertionExample()
    {
        var monitorSubject = _sut.Monitor();

        _sut.RaiseExampleEvent();

        monitorSubject.Should().Raise("ExampleEvent");
    }
}
