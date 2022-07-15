using IRCalculator.Domain;
using IRCalculator.Presentation;
using IRCalculator.Presentation.Interfaces;
using IRCalculator.Services;
using IRCalculator.Services.IncomeTax;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main()
    {
        ServiceCollection services = new();
        ConfigureServices(services);

        var serviceProvider = services.BuildServiceProvider();
        var mainFlow = serviceProvider.GetService<IMainFlow>();

        mainFlow.BeginApp();
    }

    public static void ConfigureServices(IServiceCollection services)
    {
        services
            .AddScoped<IMainFlow, MainFlow>()
            .AddScoped<IIncomeTaxCalculator, IncomeTax>()
            .AddScoped<ITaxesFlow, TaxesFlow>()
            .AddScoped<IIncomeTaxFlow, IncomeTaxFlow>()
            .AddScoped<IConsoleUI, ConsoleUI>();

    }
}
