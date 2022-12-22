using AzureFuncApi.Core.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

[assembly: FunctionsStartup(typeof(MyNamespace.Startup))]

namespace MyNamespace
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IArithmetic>((service) =>
            {
                return new ArithmeticService();
            });
            builder.Services.AddSingleton<IEmployee>((service) =>
            {
                return new EmployeeService();
            });
        }
    }
    }