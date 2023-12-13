namespace TestingTecniques;
public class ValueSamples
{
    public string FullName = "Taner Saydam";
    public int Age = 33;
    public DateOnly Date = new(2023, 12, 13);
    public User AppUser = new()
    {
        FullName = "Taner Saydam",
        Age = 33
    };

    public IEnumerable<User> Users = new[]
    {
        new User()
        {
            FullName = "Taner Saydam",
            Age = 33
        },
        new User()
        {
            FullName = "Toprak Saydam",
            Age = 4
        },
        new User()
        {
            FullName = "Tahir Saydam",
            Age = 7
        },
    };

    public IEnumerable<int> Numbers = new[] { 1, 5, 10, 25, 30 };

    public float Divide(int firstNumber, int secondNumber)
    {
        EnsureThatDivisorIsNotZero(firstNumber);
        EnsureThatDivisorIsNotZero(secondNumber);

        return firstNumber / secondNumber;
    }

    private void EnsureThatDivisorIsNotZero(int divisor)
    {
        if(divisor == 0)
        {
            throw new DivideByZeroException();
        }
    }

    internal int InternalSecretNumber = 42;

    public event EventHandler ExampleEvent;

    public virtual void RaiseExampleEvent()
    {
        ExampleEvent(this, EventArgs.Empty);
    }
}

public class User
{
    public string FullName { get; set;}
    public int Age { get; set;}
}
