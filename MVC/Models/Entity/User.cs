using System.ComponentModel.DataAnnotations;
namespace MVC.Models.Entity
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Role { get; set; } = "investor";

        public bool Is_active { get; set; } = true;
    }
}
