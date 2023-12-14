namespace TDD;

public class UnitTest1
{
    private readonly StringCalculator calculator = new StringCalculator();

    [Fact]
    public void Add_EmptyString_ReturnsZero()
    {
        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void Add_SingleNumber_ReturnsTheNumber()
    {
        var result = calculator.Add("5");

        Assert.Equal(5, result);
    }

    [Fact]
    public void Add_TwoNumbers_ReturnsTheirSum()
    {
        var result = calculator.Add("1,2");

        Assert.Equal(3, result);
    }
}

//15:00 devam edelim

public class StringCalculator
{
    public int Add(string value)
    {
        if(string.IsNullOrEmpty(value)) return 0;

        var nums = value.Split(',');
        int sum = 0;
        foreach (var num in nums)
        {
            sum += int.Parse(num);
        }

        return sum;
    }
}