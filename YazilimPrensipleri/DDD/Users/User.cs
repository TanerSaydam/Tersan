namespace DDD.Users;
public sealed class User
{
    private User(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
    private User(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }
    public Guid Id { get; private set; }
    public string Name { get; private set; }

    public static User Create(string name)
    {
        if(string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

        return new User(name);
    }

    public static User Change(Guid id, string name)
    {
        return new(id,name);
    }
}
