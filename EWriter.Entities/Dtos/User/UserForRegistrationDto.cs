using System.ComponentModel.DataAnnotations;

namespace EWriter.Entities.Dtos.User
{
    public record UserForRegistrationDto
    {
        [Required(ErrorMessage = "FirstNamme name is required!")]
        public string? FirstName { get; init; }
        [Required(ErrorMessage = "LastName name is required!")]
        public string? LastName { get; init; }
        [Required(ErrorMessage = "User name is required!")]
        public string? UserName { get; init; }
        [Required(ErrorMessage = "Password is required!")]
        public string? Password { get; init; }
        [Required(ErrorMessage = "Email is required!")]
        public string? Email { get; init; }
        //public ICollection<string>? Roles { get; init; } 
    }
}
