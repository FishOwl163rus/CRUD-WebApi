using CRUD_WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_WebApi.DataBase
{
    public sealed class NotesContext : DbContext
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public DbSet<NoteModel> Notes { get; set; }

        public NotesContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Notes.db;");
        }
    }
}