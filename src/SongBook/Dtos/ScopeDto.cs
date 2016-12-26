using System.Collections.Generic;

namespace SongBook.Dtos
{
    public class ScopeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ElaborationId { get; set; }
        public int? VoiceId { get; set; }
        public int? InstrumentId { get; set; }

        public ElaborationDto Elaboration { get; set; }
        public VoiceDto Voice { get; set; }
        public InstrumentDto Instriment { get; set; }
        public ICollection<FileDto> Files { get; set; }
    }
}
