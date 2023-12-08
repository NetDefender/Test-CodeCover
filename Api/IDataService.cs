
namespace Api;

public interface IDataService
{
    Task<bool> IsComputableAsync();

    Task<bool> IsCacheableAsync();
}