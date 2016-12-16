using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace espiewnik.Entities
{
    [Table("File")]
    public class File
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        public int ElaborationId { get; set; }

        public int TypeId { get; set; }

        public int? ScopeId { get; set; }


        [ForeignKey("ElaborationId")]
        public Elaboration Elaboration { get; set; }

        [ForeignKey("TypeId")]
        public FileType Type { get; set; }

        [ForeignKey("ScopeId")]
        public Scope Scope { get; set; }

    }
}
