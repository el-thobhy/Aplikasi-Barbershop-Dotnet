using AplikasiBarbershop.DataModel;

namespace AplikasiBarbershop.ViewModel
{
    public class GetTeamViewModel: TeamViewModel
    {
        public int? UserId { get; set; } = default!;
        public virtual UserViewModel? User { get; set; } = default!;
    }

    public class TeamViewModel: BaseEntities
    {
        public int? Id { get; set; } = default!;
        public string? Name { get; set; } = default!;
        public Role? Role { get; set; } = default!;
        public string? Phone { get; set; } = default!;
        public string? Email { get; set; } = default!;
        public Status? Status { get; set; } = default!;
    }

    public class InputTeamViewModel
    {
        public string? Name { get; set; } = default!;
        public Role? Role { get; set; } = default!;
        public string? Phone { get; set; } = default!;
        public string? Email { get; set; } = default!;
        public Status? Status { get; set; } = default!;
    }
    public class UpdateTeamViewModel: InputTeamViewModel
    {
        public int Id { get; set; }
    }
}
