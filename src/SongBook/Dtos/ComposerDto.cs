using System.Collections.Generic;

namespace SongBook.Dtos
{
    public class ComposerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Surname { get; set; }
        public string ShortSurname { get; set; }

        public ICollection<ElaborationDto> Elaborations { get; set; }

    }
}
