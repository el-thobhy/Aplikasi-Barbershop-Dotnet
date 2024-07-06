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

    public class GetServiceViewModel: ServiceViewModel
    {
        public int? CustomerId { get; set; } = default!;
        public CustomerViewModel? Customer { get; set; } = default!;
    }
}
