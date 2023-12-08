using Api;

namespace Test;

public class BadDataServiceTests
{
    [Fact]
    public async Task IsComputable_Is_Allways_True()
    {
        IDataService service = new BadDataService();
        bool isComputable = await service.IsComputableAsync();
        Assert.True(isComputable);
    }
}