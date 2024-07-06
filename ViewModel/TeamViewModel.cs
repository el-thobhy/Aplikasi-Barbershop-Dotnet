using AplikasiBarbershop.DataModel;

namespace AplikasiBarbershop.ViewModel
{
    public class GetTeamViewModel: TeamViewModel
    {
        public int? CustomerId { get; set; } = default!;
        public virtual CustomerViewModel? Customer { get; set; } = default!;
    }
    public class TeamViewModel
    {
        public int? Id { get; set; } = default!;
        public string? Name { get; set; } = default!;
        public Role? Role { get; set; } = default!;
        public string? Phone { get; set; } = default!;
        public string? Email { get; set; } = default!;
        public Status? Status { get; set; } = default!;
    }
}
