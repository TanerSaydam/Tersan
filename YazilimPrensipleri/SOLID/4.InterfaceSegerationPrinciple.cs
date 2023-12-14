namespace SOLID;

// Bad Example
public interface IMultiFuncitionYazici
{
    void Yazdir();
    void Tarama();
    void FaksGonder();
    void FotokobiCekme();
}

public class ModernYazici : IMultiFuncitionYazici
{
    public void FaksGonder()
    {
        //FaksGonder
    }

    public void FotokobiCekme()
    {
        //FotokobiCekme
    }

    public void Tarama()
    {
        //Tarama
    }

    public void Yazdir()
    {
        //Yazdir
    }
}

public class BasitYazici : IMultiFuncitionYazici
{
    public void Yazdir()
    {
        //Yazdır
    }
    public void FaksGonder()
    {
        throw new NotImplementedException("Bu yazıcı faks çekemez");
    }

    public void FotokobiCekme()
    {
        throw new NotImplementedException("Bu yazıcı fotokobi çekemez");
    }

    public void Tarama()
    {
        throw new NotImplementedException("Bu yazıcı tarama yapamaz");
    }    
}

// Good Example
public interface IYazici
{
    void Yazdir();
}

public interface ITarama
{
    void Tarama();
}

public interface IFotokobi
{
    void FotokobiCekme();
}

public interface IFaks
{
    void FaksGonder();
}

public class BasitYazici_2 : IYazici
{
    public void Yazdir()
    {
        // Yazdır
    }
}

public class ModernYazici_2 : IYazici, ITarama, IFotokobi, IFaks
{
    public void FaksGonder()
    {
        //FaksGonder
    }

    public void FotokobiCekme()
    {
        //FotokobiCekme
    }

    public void Tarama()
    {
        //Tarama
    }

    public void Yazdir()
    {
        //Yazdir
    }
}

//14:00 görüşelim

/* 
 ISP'ye uygun kod yazmak, sınıfların yanlızca gerekli metodları uygulamasını sağlar, böylece gereksiz bağımlılıklardan kaçınılır. Bu, kodun anlaşılabilirliğini ve esnekliğini artırır, ayrıca bakım ve genişletme işlemlerini kolaylaştırır. Her sınıfın yanlızca gerekli arayüzleri uygulamnasını, yazılımın genel tasarımının daha yemiz ve modüler olmasını sağlar.
 
 */