using System.Runtime.CompilerServices;

namespace OneBottle.DTOs.User
{
    public class CreateUserDTO
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}
