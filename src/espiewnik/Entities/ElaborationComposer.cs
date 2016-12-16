using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace espiewnik.Entities
{
    [Table("ElaborationComposer")]
    public class ElaborationComposer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ElaborationId { get; set; }
        public int ComposerId { get; set; }


        [ForeignKey("ElaborationId")]
        public Elaboration Elaboration { get; set; }

        [ForeignKey("ComposerId")]
        public Composer Composer { get; set; }
    }
}
