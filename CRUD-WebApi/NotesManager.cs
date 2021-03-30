using System;
using System.Collections.Generic;
using System.Linq;
using CRUD_WebApi.DataBase;
using CRUD_WebApi.Models;

namespace CRUD_WebApi
{
    public class NotesManager : INotes
    {
        private readonly NotesContext _notesContext;
        
        public NotesManager(NotesContext notesContext)
        {
            _notesContext = notesContext;
        }
        
        public void Insert(NoteModel newNote)
        {
            if (newNote == null) throw new ArgumentNullException(nameof(newNote));
            _notesContext.Notes.Add(newNote);
            
            _notesContext.SaveChanges();
        }

        public void Update(NoteModel updateNote)
        {
           if(updateNote == null) throw new ArgumentNullException(nameof(updateNote));
           
           var note = _notesContext.Notes.Find(updateNote.Id);
           
           if(note == null) return;
           
           _notesContext.Notes.Remove(note);
           _notesContext.Notes.Add(updateNote);

           _notesContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var note = Get(id);
            
            if(note == null) return;
            
            _notesContext.Remove(note);
            
            _notesContext.SaveChanges();
        }

        public void RemoveAll()
        {
            _notesContext.Notes.RemoveRange(_notesContext.Notes);
            
            _notesContext.SaveChanges();
        }

        public NoteModel Get(int id)
        {
            return _notesContext.Notes.Find(id);
        }

        public IEnumerable<NoteModel> GetAll()
        {
            return _notesContext.Notes.ToList();
        }
    }
}