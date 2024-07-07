using AplikasiBarbershop.DataModel;

namespace AplikasiBarbershop.ViewModel
{
    public class ServiceViewModel: BaseEntities
    {
        public int? Id { get; set; } = default!;
        public string? ServicesName { get; set; } = default!;
        public string? Description { get; set; } = default!;
        public double? Price { get; set; } = default!;
        public string? ImageUrl { get; set; } = default!;
    }

    public class CreateServiceViewModel
    {
        public string? ServicesName { get; set; } = default!;
        public string? Description { get; set; } = default!;
        public double? Price { get; set; } = default!;
        public string? ImageUrl { get; set; } = default!;
    }

    public class UpdateServiceViewModel: CreateServiceViewModel
    {
        public int? Id { get; set; }
    }

    public class GetServiceViewModel: ServiceViewModel
    {
        public int? UserId { get; set; } = default!;
        public UserViewModel? User { get; set; } = default!;
    }
}
