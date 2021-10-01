using DependencyInjectionBlazorWasm.Abstractions;
using DependencyInjectionBlazorWasm.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace DependencyInjectionBlazorWasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton<SimpleService>();
            builder.Services.AddSingleton<NestedService>();
            builder.Services.AddSingleton<CustomizedConstructorService>(sp => new("/wwwroot/resources", sp.GetRequiredService<SimpleService>()));
            builder.Services.AddSingleton<IFirstConstructor, MutipleConstructorsService>(sp => new(sp.GetRequiredService<SimpleService>()));
            builder.Services.AddSingleton<ISecondConstructor, MutipleConstructorsService>(sp => new(sp.GetRequiredService<NestedService>()));
            builder.Services.AddTransient<IGuidProviderTransientService, GuidProviderService>();
            builder.Services.AddScoped<IGuidProviderScopedService, GuidProviderService>();
            builder.Services.AddSingleton<IGuidProviderSingletonService, GuidProviderService>();

            await builder.Build().RunAsync();
        }
    }
}
