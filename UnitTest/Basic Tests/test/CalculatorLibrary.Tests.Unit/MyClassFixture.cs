namespace CalculatorLibrary.Tests.Unit;
public class MyClassFixture : IDisposable
{
    public Guid _guid { get; }
    public MyClassFixture()
    {
        _guid = Guid.NewGuid();
    }
    public void Dispose()
    {
        
    }
}
