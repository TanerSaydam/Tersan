namespace TemizKodunOnemi.BasitOrnekConsoleApp;

internal class Calculator
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(args[0]);
        int secondNumber = int.Parse(args[1]);        
        Console.WriteLine(Add(firstNumber, secondNumber));
        Console.ReadLine();
    }

    static int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
}
