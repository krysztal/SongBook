using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongBook.Entities
{
    [Table("Category")]
    public class Category : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        public int? PerentId { get; set; }


        [ForeignKey("PerentId")]
        public Category Parent { get; set; }
        public ICollection<Category> SubCategories { get; set; }
        public ICollection<CategorySong> CategorySongs { get; set; }



        public void CopyData(object obj)
        {
            Category fromCategory = (Category)obj;
            Name = fromCategory.Name;
            PerentId = fromCategory.PerentId;
        }
    }
}
