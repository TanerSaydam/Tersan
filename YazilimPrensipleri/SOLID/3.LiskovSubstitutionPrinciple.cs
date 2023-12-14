namespace SOLID;

// Bad Example
public class Kus
{
    public virtual void Uc()
    {
        Console.WriteLine("Kuç uçuyor");
    }
}

public class Kartal : Kus
{
    public override void Uc()
    {
        Console.WriteLine("Kartal yüksek uçuyor");
    }
}

public class Penguen: Kus
{
    public override void Uc()
    {
        throw new NotImplementedException("Penguenler uçamaz");
    }
}

// Good Example
public abstract class Kus_2
{    
    // Kuşların ortak özellikleri ve davranışlarını
}

public abstract class Ucabilirlik : Kus_2
{
    public abstract void Uc();
}

public abstract class Ucamama : Kus_2
{
    // Uçamayan kuşlar için özel özellik ve davranışlar
}

public class Kartal_2 : Ucabilirlik
{
    public override void Uc()
    {
        Console.WriteLine("Kartal yüksek uçar");
    }
}

public class Penguen_2 : Ucamama
{
    // Penguen'e özel davranışlar
}

/*
 LSP'nin Faydaları: LSP'ye göre uygun kod yazmak, kodun anlaşılırlığını ve bakımını iyileştirir. Bu prensip alt sınıfların üst sınıfların yerine geçebileceğinden emin olmanızı sağlar, böylece kodun daha esnek ve genişletilebilir olmasına katkıda bulunur. Ayrıca yan etkileri azaltır ve yazılımın genel kalitesini artırır
 */