using System.Collections.Generic;

namespace SongBook.Dtos
{

    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PerentId { get; set; }

        public CategoryDto Parent { get; set; }
        public ICollection<CategoryDto> SubCategories { get; set; }
        public ICollection<SongDto> Songs { get; set; }
    }
}
