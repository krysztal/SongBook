using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongBook.Dtos
{
    public class ElaborationDto
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public string Language { get; set; }
        public string Text { get; set; }
        public string Year { get; set; }

        ICollection<SongDto> Song { get; set; }
        ICollection<CategoryDto> Composers { get; set; }
        ICollection<ScopeDto> Scops { get; set; }
        ICollection<FileDto> Files { get; set; }
    }
}
