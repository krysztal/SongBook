using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongBook.Entities
{
    [Table("Song")]
    public class Song : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Required, MaxLength(30)]
        public string FileName { get; set; }

        public ICollection<CategorySong> CategoriesSong { get; set; }
        public ICollection<Elaboration> Elaborations { get; set; }

        public void CopyData(object obj)
        {
            Song fromSong = (Song)obj;
            Name = fromSong.Name;
            Name = fromSong.FileName;
        }
    }
}
