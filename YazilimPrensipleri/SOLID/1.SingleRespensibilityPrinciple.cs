namespace SOLID.BadExmaple;

public class KullaniciYonetimi
{
    public void KullaniciEkle(string kullaniciAdi, string email)
    {
        // Kullanıcıyı sisteme ekleme kodları...
    }

    public void KullaniciSil(int kullaniciId)
    {
        // Kullanıcıyı sistemden silen kodlar...
    }

    public void KullaniciDosyaVerisiniKaydet(string dosyaYolu)
    {
        // Kullanıcı dosya verilerini kaydeden kodlar....
    }
}

// SOLID.GoodExmaple;

public class KullaniciYonetimi_2
{
    public void KullaniciEkle(string kullaniciAdi, string email)
    {
        // Kullanıcıyı sisteme ekleme kodları...
    }

    public void KullaniciSil(int kullaniciId)
    {
        // Kullanıcıyı sistemden silen kodlar...
    }    
}

public class KullaniciVerisiKaydedici
{
    public void KullaniciDosyaVerisiniKaydet(string dosyaYolu)
    {
        // Kullanıcı dosya verilerini kaydeden kodlar....
    }
}

/*
 Faydaları: Bu iki örnek SRP'nin uygulamasının ve ihlalinin etkilerini göstermektedir. SRP'ye uygun kod yazmak, kodun bakımını, anlaşabilirliğini ve genişletebilirliğini iyileştirir. Ayrıca test edilebilirlik ve hata bulma süreçlerini koaylaştırır. Her sınıfın tek bir sorumluluğa odaklanması, yazılım geliştime sürecinde daha sağlam ve sürdürülebilir uygulamalar oluşturulmasına yardımcı olur 
 */
