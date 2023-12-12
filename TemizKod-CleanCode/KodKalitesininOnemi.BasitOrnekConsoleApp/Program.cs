using ExampleNuGetPackage;
using Newtonsoft.Json;

namespace KodKalitesininOnemi.BasitOrnekConsoleApp;

internal class Program
{
    static async void Main(string[] args)
    {

        //Kullanici kullanici = new("Taner","Saydam","taner@saydam.com");
        //kullanici.BilgileriYazdir();

        var dovizKuruServisi = new DovizKuruServisi();
        var dovizKuru = await dovizKuruServisi.DovizKuruGetirAsync("USD");
        if(dovizKuru is not null)
        {
            Console.WriteLine($"1 USD = {dovizKuru.Deger} ₺");
        }
        
        Console.ReadLine();
    }
}


public sealed class Kullanici
{
    public Kullanici(string ad, string soyad, string email)
    {
        if(string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad))
        {
            throw new ArgumentException("Ad ve soyad bilgisi boş olamaz");
        }

        if (!EmailGecerliMi(email))
        {
            throw new ArgumentException("Geçerli bir mail adresi girin");
        }

        Ad = ad.Trim();
        Soyad = soyad.Trim();
        Email = email.Trim();
    }

    private bool EmailGecerliMi(string email)
    {
        return email.Contains("@") && email.Contains("."); //taner@saydam.com
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Adı: {Ad}, Soyad: {Soyad}, Email: {Email}");
    }

    public string Ad { get; private set; }
    public string Soyad { get; private set; }
    public string Email { get; private set; }
}
