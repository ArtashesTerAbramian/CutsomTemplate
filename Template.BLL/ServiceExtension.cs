using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Template.BLL.Services.ErrorService;

namespace Template.BLL;
public static class ServiceExtension 
{
    public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IErrorService, ErrorService>();

        return services;
    }
}
