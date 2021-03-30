using System.Collections.Generic;
using CRUD_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class NotesController : ControllerBase
    {
        private readonly INotes _notes;
        
        public NotesController(INotes notes)
        {
            _notes = notes;
        }
        
        public IEnumerable<NoteModel> GetAllNotes() => _notes.GetAll();
        
        public NoteModel GetNote(int id) => _notes.Get(id);
        
        public void RemoveAllNotes() => _notes.RemoveAll();
        
        public void RemoveNote(int id) => _notes.Remove(id);

        public void InsertNote(NoteModel newNote) => _notes.Insert(newNote);
        
        public void UpdateNote(NoteModel updateNote) => _notes.Update(updateNote);
        
    }
}