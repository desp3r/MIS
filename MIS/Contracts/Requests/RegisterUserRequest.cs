namespace MIS.Contracts.Requests
{
    public class RegisterUserRequest
    {
        public string? Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string? Password { get; set; } = null!;


    }
}
