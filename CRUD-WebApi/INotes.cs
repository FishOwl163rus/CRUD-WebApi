using System;
using System.Collections.Generic;
using CRUD_WebApi.Models;

namespace CRUD_WebApi
{
    public interface INotes
    {
        void Insert(NoteModel newNote);
        void Update(NoteModel updateNote);
        void Remove(int id);
        void RemoveAll();
        NoteModel Get(int id);
        IEnumerable<NoteModel> GetAll();
    }
}