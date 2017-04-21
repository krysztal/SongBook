using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongBook.Entities
{
    [Table("Instrument")]
    public class Instrument : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        public ICollection<Scope> Scops { get; set; }



        public void CopyData(object obj)
        {
            Instrument fromInstrument = (Instrument)obj;
            Name = fromInstrument.Name;
        }
    }
}
