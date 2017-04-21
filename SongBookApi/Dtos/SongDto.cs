using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace SongBook.Dtos
{
    public class SongDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
 
        public ICollection<IFormFile> Files { get; set; }
        public ICollection<CategoryDto> Categories { get; set; }
        public ICollection<ElaborationDto> Elaborations { get; set; }
    }
}
