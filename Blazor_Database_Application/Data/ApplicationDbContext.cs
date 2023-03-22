using Blazor_Database_Application.Areas.Apps;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Blazor_Database_Application.Data.Models;

namespace Blazor_Database_Application.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        //Notes auto points to table of the same name
        public DbSet<NoteModel> Notes { get; set; }
    }
}