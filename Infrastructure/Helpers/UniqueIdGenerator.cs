using Infrastructure.Interfaces;
namespace Infrastructure.Helpers;

public class UniqueIdGenerator : IdGenerator
{
    public static string Generate()
    {
        return Guid.NewGuid().ToString();
    }
}
