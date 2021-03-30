using Newtonsoft.Json;

namespace CRUD_WebApi.Models
{
    [JsonObject]
    public class NoteModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
    }
}