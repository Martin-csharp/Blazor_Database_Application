using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Database_Application.Data.Models
{
    //Point to correct table
    [Table("Notes")]

    public class NoteModel
    {
        public int Id        { get; set; }

        [Required]
        public string Note   { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        

    }
}

//Properties should have the same names as the columns in the database