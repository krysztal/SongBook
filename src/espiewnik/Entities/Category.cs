using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace espiewnik.Entities
{
    [Table("Category")]
    public class Category
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
    }
}
