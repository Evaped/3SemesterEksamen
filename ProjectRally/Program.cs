using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;

namespace Rally;
public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        // Configure HttpClient for the server API
        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        // Add MudBlazor services
        builder.Services.AddMudServices(c =>
        {
            c.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
        });

        // OIDC Authentication (Adjust as needed)
        builder.Services.AddOidcAuthentication(options =>
        {
            builder.Configuration.Bind("Local", options.ProviderOptions);
        });

        await builder.Build().RunAsync();
    }
}
