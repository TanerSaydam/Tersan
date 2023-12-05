using Benchmark.ConsoleApp.Context;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.EntityFrameworkCore;

namespace Benchmark.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<BenchMarkService>();
        Console.ReadLine();
    }
}

public class BenchMarkService
{
    ApplicationDbContext context = new();

    [Benchmark(Baseline = true)]
    public void ToList()
    {
        var users = context.Users.ToList();
    }
    [Benchmark]
    public async Task ToListAsync(CancellationToken cancellationToken)
    {
        var users = await context.Users.ToListAsync(cancellationToken);
    }
}
