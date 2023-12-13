using CalculatorLibrary;
using CalculatorLibrary.Tests.Unit;
using FluentAssertions;
using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace TestProject1;
public class CalculatorTests : IClassFixture<MyClassFixture>
{
    //15:05 görüşelim
    private readonly Calculator _sut; //system under test
    private readonly ITestOutputHelper _outputHelper;
    private readonly MyClassFixture _fixture;
    public CalculatorTests(ITestOutputHelper outputHelper, MyClassFixture myClassFixture)
    {
        _sut = new Calculator();
        _fixture = myClassFixture;
        _outputHelper = outputHelper;
    }

    [Theory]
    [InlineData(1,2,3)]
    //[InlineData(5,4,9)]
    //[InlineData(10,1,11)]
    public async Task Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers(int firstNumber, int secondNumber, int expected)
    {
        // Act
        //var stopWatch = Stopwatch.StartNew();
        var result = _sut.Add(firstNumber, secondNumber);
        await Task.Delay(1);
        //stopWatch.Stop();

        // Assert
        //Assert.Equal(expected, result);
        result.Should().Be(expected);
        result.Should().BeGreaterThanOrEqualTo(expected);
        //stopWatch.ElapsedMilliseconds.Should().BeLessThanOrEqualTo(500);        
    }


    [Theory]
    [InlineData(-1, 2, -3)]
    //[InlineData(5, -4, 9)]
    //[InlineData(10, -1, 11)]
    public async Task Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers(int firstNumber, int secondNumber, int expected)
    {
        // Act
        var result = _sut.Subtract(firstNumber, secondNumber);

        // Assert
        //Assert.Equal(expected, result);
        result.Should().Be(expected);

        await Task.Delay(3000);
    }


    [Theory]
    [InlineData(-1, 2, -2)]
    [InlineData(5, -4, -20)]
    [InlineData(10, 1, 10)]
    public void Muliply_ShouldMuliplyTwoNumbers_WhenTwoNumbersAreIntegers(int firstNumber, int secondNumber, int expected)
    {
        // Act
        var result = _sut.Multiply(firstNumber, secondNumber);

        // Assert
        //Assert.Equal(expected, result);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(10, 2, 5)]
    [InlineData(6, 3, 2)]
    [InlineData(0, 0, 0, Skip = "0 0'a bölünemez!")]
    public void Divide_ShouldDivideTwoNumbers_WhenTwoNumbersAreIntegers(int firstNumber, int secondNumber, int expected)
    {
        // Act
        var result = _sut.Divide(firstNumber, secondNumber);

        // Assert
        //Assert.Equal(expected, result);
        result.Should().Be(expected);
    }

    [Fact]
    public void GuidTest1()
    {
        _outputHelper.WriteLine(_fixture._guid.ToString());
    }

    [Fact]
    public void GuidTest2()
    {
        _outputHelper.WriteLine(_fixture._guid.ToString());
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public async Task DisposeAsync()
    {
        //await Task.Delay(3000);
    }
}
