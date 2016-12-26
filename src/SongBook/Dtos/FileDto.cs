namespace SongBook.Dtos
{
    public class FileDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ElaborationId { get; set; }
        public int TypeId { get; set; }
        public int? ScopeId { get; set; }

        public ElaborationDto Elaboration { get; set; }
        public FileTypeDto Type { get; set; }
        public ScopeDto Scope { get; set; }
    }
}
