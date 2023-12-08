namespace Api;

public sealed class BadDataService : IDataService
{
    public Task<bool> IsComputableAsync()
    {
        return Task.FromResult(true);
    }
}
