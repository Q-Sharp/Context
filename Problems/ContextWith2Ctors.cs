using Microsoft.EntityFrameworkCore;

namespace Problem;

public class TestContextWith2Ctors : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
             => options
                 .EnableServiceProviderCaching(false)
                 .UseInMemoryDatabase(nameof(TestContextWith2Ctors));

    public TestContextWith2Ctors(DbContextOptions<TestContextWith2Ctors> options) : base(options)
    {
    }

    public TestContextWith2Ctors()
    {
    }
}
