using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Template.BLL.Services.ContextModificatorService;
using Template.BLL.Services.ErrorService;
using Template.DAL;

namespace Template.BLL;
public static class ServiceExtension 
{
    public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IContextModificatorService, ContextModificatorService>();
        services.AddScoped<IErrorService, ErrorService>();

        return services;
    }
}
