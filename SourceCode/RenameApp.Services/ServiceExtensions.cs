using Microsoft.Extensions.DependencyInjection;
using RenameApp.Contracts;
using RenameApp.Services;

namespace RenameApp.Services
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRenameAppServices(this IServiceCollection services)
        {
            services.AddScoped<ISehirService, SehirService>();
            services.AddScoped<IIlceService, IlceService>();
            services.AddScoped<IHizmetlerService, HizmetlerService>();
            services.AddScoped<IServiceProviderService, ServiceProviderService>();
            services.AddScoped<IServiceReceiversService, ServiceReceiversService>();
            services.AddScoped<IOrderSuccessTypeService, OrderSuccessTypeService>();
            services.AddScoped<IOrderStaticsService, OrderStaticsService>();
            services.AddScoped<IOrdersService, OrdersService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ISocialAdresService, SocialAdresService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<ICorporateService, CorporateService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();

            services.AddScoped<IWeatherCitiesService, WeatherCitiesService>();
            services.AddScoped<ITemperatureStaticsService, TemperatureStaticsService>();
            services.AddScoped<ICityTemperatureStaticsService, CityTemperatureStaticsService>();

            return services;
        }
    }
}
