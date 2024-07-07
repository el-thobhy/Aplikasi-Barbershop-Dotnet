using DataModel;

namespace AplikasiBarbershop.ViewModel
{

    public class RegisterViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string? Phone { get; set; } = default!;
        public string? Address { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public UserTypeEnum Role { get; set; } = UserTypeEnum.CUSTOMER;
    }
    public class ReturnLoginViewModel
    {
        public int Id { get; set; }

        public string UserName { get; set; } = default!;
        public string Name { get; set; } = default!;
        public List<string> Roles { get; set; } = new List<string>();
        public string Token { get; set; } = default!;
        public DateTime Expiration { get; set; }
    }
    public class LoginViewModel
    {
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
