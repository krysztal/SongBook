using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongBook.Entities
{
    [Table("Scope")]
    public class Scope : IEntity
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



        public void CopyData(object obj)
        {
            Scope fromScope = (Scope)obj;
            Name = fromScope.Name;
            ElaborationId = fromScope.ElaborationId;
            VoiceId = fromScope.VoiceId;
            InstrumentId = fromScope.InstrumentId;
        }
    }
}
