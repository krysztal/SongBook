using System.Collections.Generic;

namespace SongBook.Dtos
{
    public class VoiceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ScopeDto> Scops { get; set; }
    }
}
