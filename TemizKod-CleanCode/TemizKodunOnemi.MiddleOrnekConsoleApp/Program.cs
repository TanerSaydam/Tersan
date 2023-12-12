
namespace TemizKodunOnemi.MiddleOrnekConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\1\example.txt";
        FileReader fileReader = new();
        fileReader.DisplayFirstLineOfFile(filePath);

        Console.ReadLine();
    }
}

public class FileReader
{
    public void DisplayFirstLineOfFile(string filePath)
    {
        if(!File.Exists(filePath))
        {
            Console.WriteLine("File doest not exist");
            return;
        }

        try
        {
            string? firstLine = GetFirstLineOfFile(filePath);
            if(string.IsNullOrEmpty(firstLine))
            {
                Console.WriteLine("File is empty");
            }
            else
            {
                Console.WriteLine($"First line: {firstLine}");
            }
        }
        catch (IOException ex)
        {
            Console.Error.WriteLine($"An error occurred while reading file: {ex.Message}");
        }
    }

    private string? GetFirstLineOfFile(string filePath)
    {
        using (StreamReader reader = new(filePath))
        {
            return reader.ReadLine();
        }
    }
}
