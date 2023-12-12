using TemizKodunOnemi.AdvancedOrnek.WebApi.Models;

namespace TemizKodunOnemi.AdvancedOrnek.WebApi.Context;

public class ApplicationDbContext
{
    public void Add(Item item)
    {
        //Memory üzerinden Kayıt işlemi
    }

    public void SaveChanges()
    {
        //Transaction Yöntemi ile DB'ye Aktarımı
    }

    public List<Item> Items()
    {
        return new List<Item> { new Item() };
    }

    public bool Any(string name)
    {
        return false;
    }
}
