using System.Collections.Generic;

namespace SongBook.Dtos
{
    public class FileTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        ICollection<FileDto> Files { get; set; }
    }
}
