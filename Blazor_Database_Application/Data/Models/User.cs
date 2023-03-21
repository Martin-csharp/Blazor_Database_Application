using System.ComponentModel.DataAnnotations;

namespace Blazor_Database_Application.Data.Models
{
    public class User
    {
        [Required]
        [EmailAddress]
        public string LoginName { get; set; } = String.Empty;

        [Required]
        public string UserRole { get; set; } = String.Empty;
    }
}
