namespace MIS.API.Contracts.Responses
{
    public class RegisterUserResponse
    {
        public string? Message { get; set; } = null;
        public string Email { get; set; } = null!;
    }
}
