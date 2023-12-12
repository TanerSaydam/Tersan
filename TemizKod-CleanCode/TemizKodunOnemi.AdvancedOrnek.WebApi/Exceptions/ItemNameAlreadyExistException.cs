namespace TemizKodunOnemi.AdvancedOrnek.WebApi.Exceptions;

public class ItemNameAlreadyExistException : Exception
{
    public ItemNameAlreadyExistException() : base("Item name already exist")
    {
        
    }
}
