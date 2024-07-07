using AplikasiBarbershop.Validation;
using AplikasiBarbershop.ViewModel;
using FluentValidation;

namespace AplikasiPenghitungGaji.Api.Validation
{
    public static class ServiceValidator
    {
        public static IServiceCollection AddValidator(this IServiceCollection services)
        {
            services.AddScoped<IValidator<RegisterViewModel>, RegisterValidator>()
                .AddScoped<IValidator<LoginViewModel>, LoginValidator>()
                .AddScoped<IValidator<InputTeamViewModel>, TeamValidator>()
                .AddScoped<IValidator<ServiceViewModel>, MasterServiceValidator>();

            return services;

        }
    }
}
