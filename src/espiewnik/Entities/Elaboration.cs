using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace espiewnik.Entities
{
    [Table("Elaboration")]
    public class Elaboration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int SongId { get; set; }

        [MaxLength(20)]
        public string Language { get; set; }

        public string Text { get; set; }

        [MaxLength(4)]
        public string Year { get; set; }


        [ForeignKey("SongId")]
        ICollection<Song> Song { get; set; }
        ICollection<ElaborationComposer> ElaborationComposers { get; set; }
        ICollection<Scope> Scops { get; set; }
        ICollection<File> Files { get; set; }
    }
}
