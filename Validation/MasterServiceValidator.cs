using AplikasiBarbershop.DataModel;
using AplikasiBarbershop.ViewModel;
using FluentValidation;

namespace AplikasiBarbershop.Validation
{
    public class MasterServiceValidator: AbstractValidator<ServiceViewModel>
    {
        public MasterServiceValidator(BarberDbContext dbContext)
        {
            RuleFor(x => x.ServicesName)
                .NotNull()
                .WithName("ServiceName")
                .WithMessage("ServiceName is Required");
            RuleFor(x => x.ServicesName)
                .Length(1, 50)
                .WithName("ServiceName")
                .WithMessage("Length 1-50");

            RuleFor(x => x.Description)
                .NotNull()
                .WithName("Description")
                .WithMessage("Description is Required");
            RuleFor(x => x.Description)
                .Length(1, 255)
                .WithName("Description")
                .WithMessage("Length 1-255");

            RuleFor(x => x.Price )
                .NotNull()
                .WithName("Price")
                .WithMessage("Price is Required");

            RuleFor(x => x.ImageUrl)
                .NotNull()
                .WithName("ImageUrl")
                .WithMessage("ImageUrl is Required");
            RuleFor(x => x.ImageUrl)
                .Length(1, 255)
                .WithName("ImageUrl")
                .WithMessage("Length 1-255");


            RuleFor(x => new { x.ServicesName })
                .Must(x =>
                {
                    return !dbContext.MasterServices.Where(o => o.ServicesName == x.ServicesName).Any();
                })
                .WithName("ServicesName")
                .WithMessage("ServicesName sudah ada");


        }
    }
}
