namespace SOLID;

// Bad Example
public class EmailGonderici
{
    public void EmailGonder(string mesaj)
    {
        // Email gönderme işlemi
    }
}

public class SmsGonderici
{
    public void SmsGonder(string mesaj)
    {
        // Sms gönderme işlemi
    }

}

public class HaberServisi
{
    //public EmailGonderici emailGonderici = new();
    public SmsGonderici smsGonderici = new();

    public void HaberGonder(string haber)
    {
        //emailGonderici.EmailGonder(haber);
        smsGonderici.SmsGonder(haber);
    }
}

// Good Example

public interface IHaberGonderici
{
    void Gonder(string message);
}

public class EmailGonder : IHaberGonderici
{
    public void Gonder(string message)
    {
        // Email Gönderme İşlemi
    }
}

public class SmsGonder : IHaberGonderici
{
    public void Gonder(string message)
    {
        // Sms Gönderme İşlemi Yapıyor
    }
}

public class HaberServisi_2
{
    public IHaberGonderici _haberGonderici;

    public HaberServisi_2()
    {
        _haberGonderici = new EmailGonder();
    }

    public void HaberGonder(string haber)
    {
        _haberGonderici.Gonder(haber);  
    }
}

/*
 DIP'ye uygun kod yazmak, modüller arasındaki bağımlılığı azaltır ve sistemlerin esnekliğini artırır. Bu prensip, yazılımın bakımını ve genişletilmesini kolaylaştırır, ayrıca kodun test edilebilriğini ve yeniden kullanılabilirliği artırır. DIP, yüksek seviye iş mantığının düşük seviye detaylardan soyutlanmasını sağlayarak, yazılımın modülerliğini ve kalitesini iyileştirir
 */
