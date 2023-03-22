using Blazor_Database_Application.Data.Models;
using Blazor_Database_Application.Data;

namespace Blazor_Database_Application.Services
{
    public class NoteService
    {
        private readonly ApplicationDbContext _dbContext;

        public NoteService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddNoteAsync(string userId, string description)
        {
            var note = new NoteModel
            {
                UserId = userId,
                Note   = description
            };

            _dbContext.Notes.Add(note);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<NoteModel>> GetAllNotes()
        {            
            return _dbContext.Notes.ToList();
        }
    }
}
