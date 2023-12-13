namespace UnderstandingDependecies.WebApi.Models;

public sealed class User
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
}
