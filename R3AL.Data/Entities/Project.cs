using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R3AL.Data.Entities
{
    [Table(nameof(Project))]
    public class Project
    {
        [Required]
        public string Descritption { get; set; }

        [Required]
        [MaxLength(200)]
        public string Link { get; set; }

        public int ProjectId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
    }
}