namespace SOLID;

// Bad Example
public class RaporOlusturucu
{
    public string RaporOlustur(string tip)
    {
        if(tip == "PDF")
        {
            //PDF raporu oluştur
            return "PDF Raporu";
        }else if(tip == "Excel")
        {
            //Excel raporu oluştur
            return "Excel Reporu";
        }
        //Yeni rapor formatları eklendiğine buraya daha fazla kod gelir.

        return string.Empty;
    }
}

// Good Example
public interface IRaporOlusturucu
{
    string RaporOlustur();
}

public class PdfRaporOlusturucu : IRaporOlusturucu
{
    public string RaporOlustur()
    {
        //PDF raporu oluştur
        return "PDF Raporu";
    }
}

public class ExcelRaporOlusturucu : IRaporOlusturucu
{
    public string RaporOlustur()
    {
        //Excel raporu oluştur
        return "Excel Reporu";
    }
}

public class RaporYazdirici
{
    public string RaporYazcir(IRaporOlusturucu raporOlusturucu)
    {
        return raporOlusturucu.RaporOlustur();
    }
}

/*
 OCP Faydaları: Bu iki örnek OCP'nin uygulamasının ve ihlainin etkilerini gösterir. OCP'ne uygun kod yazmak, mevcut kodun yeniden kullanabilirliğini ve genişletilebilirliğini artırırken, gelecekteki değişiklikler için kodu daha esnes hale getirir. Bu prensip, yazılımın uzun vadeli bakımını kolaylaştırır ve uygulamanın geniştilmesini sırasında potansiyel hataları azaltır.
 */
