namespace KodOkunabilirligiVeSurdurulebilirligi.BasitOrnek.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CiftSayileriTopla(10));
    }

    /// <summary>
    /// Verilen sınır değerine kadar olan çift sayıların toplamını hesaplar
    /// </summary>
    /// <param name="limit">Çift sayıların toplanacağı üst sınır</param>
    /// <returns>Çift sayıların toplamı</returns>

    private static int CiftSayileriTopla(int limit)
    {
        int toplam = 0;
        for (int i = 0; i < limit; i++)
        {
            if (i % 2 == 0) toplam += i;
        }

        return toplam;
    }
}
