using AplikasiBarbershop.DataModel;

namespace AplikasiBarbershop.ViewModel
{
    public class CustomerViewModel: BaseEntities
    {
        public int? Id { get; set; } = default!;
        public string? Name { get; set; } = default!;
        public string? Phone { get; set; } = default!;
        public string? Email { get; set; } = default!;
        public string? Address { get; set; } = default!;

    }

    public class GetCustomerViewModel: CustomerViewModel
    {
        public TeamViewModel? Team { get; set; }
        public List<ServiceViewModel>? Services { get; set; }
    }
}
