using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongBook.Entities
{
    [Table("CategorySong")]
    public class CategorySong : IEntity
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



        public void CopyData(object obj)
        {
            CategorySong fromCategorySong = (CategorySong)obj;
            CategoryId = fromCategorySong.CategoryId;
            SongId = fromCategorySong.SongId;
        }
    }
}
