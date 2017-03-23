using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongBook.Entities
{
    [Table("FileType")]
    public class FileType : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        ICollection<File> Files { get; set; }



        public void CopyData(object obj)
        {
            FileType fromFileType = (FileType)obj;
            Name = fromFileType.Name;
        }
    }
}
