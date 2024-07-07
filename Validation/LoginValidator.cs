using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.ViewModel;
using FluentValidation;

namespace AplikasiPenghitungGaji.Api.Validation
{
    public class LoginValidator: AbstractValidator<LoginViewModel>
    {
        public LoginValidator(BarberDbContext dbContext)
        {
            RuleFor(x => x.UserName)
               .NotNull()
               .WithName("Username")
               .WithMessage("Username is Required");

            RuleFor(x => x.UserName)
                .Length(1, 50)
                .WithName("Username")
                .WithMessage("Length 1-50");
            RuleFor(x => x.Password)
                .NotNull()
                .WithName("Password")
                .WithMessage("Password is Required");

            RuleFor(x => x.Password)
                .Length(1, 100)
                .WithName("Password")
                .WithMessage("Password Length 1 - 100 ");


            RuleFor(x => new { x.UserName })
                .Must(x =>
                {
                    return dbContext.MasterUsers.Where(o => o.UserName == x.UserName).Any();
                })
                .WithName("Username")
                .WithMessage("Username Tidak Ditemukan");

        }
    }
}
