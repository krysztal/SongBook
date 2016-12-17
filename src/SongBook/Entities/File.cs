using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongBook.Entities
{
    [Table("File")]
    public class File : IEntity
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



        public void CopyData(object obj)
        {
            File fromFile = (File)obj;
            Name = fromFile.Name;
            ElaborationId = fromFile.ElaborationId;
            TypeId = fromFile.TypeId;
            ScopeId = fromFile.ScopeId;
        }
    }
}
