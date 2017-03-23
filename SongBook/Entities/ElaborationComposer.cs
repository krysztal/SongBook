using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongBook.Entities
{
    [Table("ElaborationComposer")]
    public class ElaborationComposer : IEntity
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



        public void CopyData(object obj)
        {
            ElaborationComposer fromElaborationComposer = (ElaborationComposer)obj;
            ElaborationId = fromElaborationComposer.ElaborationId;
            ComposerId = fromElaborationComposer.ComposerId;
        }
    }
}
