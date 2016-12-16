using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace espiewnik.Entities
{
    [Table("Composer")]
    public class Composer
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
    }
}
