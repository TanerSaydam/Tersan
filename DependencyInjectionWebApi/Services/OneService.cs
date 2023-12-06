namespace DependencyInjectionWebApi.Services;

public interface IProductService
{
    void Add(string name = "");
}

public class ProductServiceWithEFCOre : IProductService
{
    public ProductServiceWithEFCOre()
    {
        
    }
    public void Add(string name = "")
    {
        //EF Core Ekleme işlemi
    }
}

public class ProductServiceWithMongoDb : IProductService
{
    public ProductServiceWithMongoDb()
    {
        
    }
    public void Add(string name = "")
    {
        //MongoDb Ekleme İşlemi
    }
}

public class OneService(ApplicationDbContext context)
{
    public void SmsGonder()
    {
        context.Connection("Taner");
        string name = context.Name;
    }
}

public class TwoService(ApplicationDbContext context)
{
    public void MailGonder()
    {
        context.Connection();
        string name = context.Name;
    }
}

public class ApplicationDbContext
{
    public string Name { get; set; }
    public ApplicationDbContext()
    {
        
    }

    public void Connection(string name = "")
    {
        if(!string.IsNullOrEmpty(name))
        {
            Name = name;
        }
        
        Console.WriteLine("Connection başarılı...: " + name);
    }
}