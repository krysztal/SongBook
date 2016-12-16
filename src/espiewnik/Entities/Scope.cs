using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace espiewnik.Entities
{
    [Table("Scope")]
    public class Scope
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }
        public int ElaborationId { get; set; }
        public int? VoiceId { get; set; }
        public int? InstrumentId { get; set; }


        [ForeignKey("VoiceId")]
        public Elaboration Elaboration { get; set; }

        [ForeignKey("VoiceId")]
        public Voice Voice { get; set; }

        [ForeignKey("InstrumentId")]
        public Instrument Instriment { get; set; }

        public ICollection<File> Files { get; set; }
    }
}
