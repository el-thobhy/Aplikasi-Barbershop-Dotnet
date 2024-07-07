using AplikasiBarbershop.DataModel;

namespace AplikasiBarbershop.ViewModel
{
    public class UserViewModel: BaseEntities
    {
        public int? Id { get; set; } = default!;
        public string? UserName { get; set; }
        public string? Name { get; set; } = default!;
        public string? Phone { get; set; } = default!;
        public string? Email { get; set; } = default!;
        public string? Address { get; set; } = default!;

    }

    public class GetUserViewModel: UserViewModel
    {
        public TeamViewModel? Team { get; set; }
        public List<ServiceViewModel>? Services { get; set; }
    }
}
