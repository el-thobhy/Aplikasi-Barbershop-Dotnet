using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.ViewModel;
using FluentValidation;

namespace AplikasiBarbershop.Validation
{
    public class TeamValidator: AbstractValidator<InputTeamViewModel>
    {
        public TeamValidator(BarberDbContext dbContext)
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithName("Name")
                .WithMessage("Name is Required");
            RuleFor(x => x.Name)
                .Length(1, 50)
                .WithName("Name")
                .WithMessage("Length 1-50");

            RuleFor(x => x.Phone)
                .NotNull()
                .WithName("Phone")
                .WithMessage("Phone is Required");

            RuleFor(x => x.Email)
                .NotNull()
                .WithName("Email")
                .WithMessage("Email is Required");
            RuleFor(x => x.Email)
                .Length(1, 100)
                .WithName("Email")
                .WithMessage("Email 1-255");


            RuleFor(x => x.Status)
                .NotNull()
                .WithName("Status")
                .WithMessage("Status is Required");


            RuleFor(x => new { x.Name })
                .Must(x =>
                {
                    return !dbContext.MasterTeams.Where(o => o.Name == x.Name).Any();
                })
                .WithName("Name")
                .WithMessage("Name sudah ada");
            
            RuleFor(x => new { x.Email })
                .Must(x =>
                {
                    return !dbContext.MasterTeams.Where(o => o.Email == x.Email).Any();
                })
                .WithName("Email")
                .WithMessage("Email sudah ada");


        }
    }
}
