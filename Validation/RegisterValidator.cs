using DataModel;
using FluentValidation;
using AplikasiBarbershop.ViewModel;
using AplikasiBarbershop.DataModel;

namespace AplikasiPenghitungGaji.Api.Validation
{
    public class RegisterValidator: AbstractValidator<RegisterViewModel>
    {
        public RegisterValidator(BarberDbContext dbContext)
        {
            RuleFor(x => x.UserName)
                .NotNull()
                .WithName("Username")
                .WithMessage("Username is Required");

            RuleFor(x => x.UserName)
                .Length(1, 50)
                .WithName("Username")
                .WithMessage("Length 1-50");

            RuleFor(x => new { x.UserName })
                .Must(x =>
                {
                    return !dbContext.MasterUsers.Where(o => o.UserName == x.UserName).Any();
                })
                .WithName("Username")
                .WithMessage("Username Already Exists");


            RuleFor(x => x.Password)
                .NotNull()
                .WithName("Password")
                .WithMessage("Password is Required");

            RuleFor(x => x.Password)
                .Length(1, 100)
                .WithName("Password")
                .WithMessage("Password Length 1 - 100 ");

            RuleFor(x => x.Name)
                .Length(1, 50)
                .WithName("FirstName")
                .WithMessage("FirstName Length 1-50");

            RuleFor(x => x.Email)
                .NotNull()
                .WithName("Email")
                .WithMessage("Email is Required");

            RuleFor(x => x.Email)
                .Length(1, 100)
                .WithName("Email")
                .WithMessage("Email Length 1-50");

            RuleFor(x => new { x.Email })
                .Must(x =>
                {
                    return !dbContext.MasterUsers.Where(o => o.Biodata.Email == x.Email).Any();
                })
                .WithName("Email")
                .WithMessage("Email Already Exists");

            RuleFor(x => x.Role)
                .NotNull()
                .WithName("Type")
                .WithMessage("Type is Required");
        }
    }
}
