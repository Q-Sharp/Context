using Microsoft.EntityFrameworkCore;

namespace NoProblem;

public class TestContextWith2Ctors : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
             => options
                 .EnableServiceProviderCaching(false)
                 .UseInMemoryDatabase(nameof(TestContextWith2Ctors));

    public TestContextWith2Ctors()
    {
    }

    public TestContextWith2Ctors(DbContextOptions<TestContextWith2Ctors> options) : base(options)
    {
    }
}
