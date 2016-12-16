using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace espiewnik.Entities
{
    [Table("CategorySong")]
    public class CategorySong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SongId { get; set; }


        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ForeignKey("SongId")]
        public Song Song { get; set; }
    }
}
