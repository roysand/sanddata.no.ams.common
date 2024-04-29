using sanddata.no.ams.common.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConsoleTest1;

public class App(IApplicationDbContext applicationDbContext)
{
    private readonly IApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task Run(string[] args)
    {
        Console.WriteLine($"Hello from App {DateTime.Now}");

        var count = await _applicationDbContext.HourSet.CountAsync();
        Console.WriteLine($"Number of rows in table Hour is {count}");
    }
}