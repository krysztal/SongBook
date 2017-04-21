using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongBook.Entities
{
    [Table("Composer")]
    public class Composer : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, MaxLength(5)]
        public string ShortName { get; set; }

        [Required, MaxLength(20)]
        public string Surname { get; set; }

        [Required, MaxLength(5)]
        public string ShortSurname { get; set; }

        public ICollection<ElaborationComposer> ElaborationsComposer { get; set; }



        public void CopyData(object obj)
        {
            Composer fromComposer = (Composer)obj;
            Name = fromComposer.Name;
            ShortName = fromComposer.ShortName;
            Surname = fromComposer.Surname;
            ShortSurname = fromComposer.ShortSurname;
        }
    }
}
