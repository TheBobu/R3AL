using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R3AL.Data.Entities
{
    [Table(nameof(Job))]
    public class Job
    {
        public int JobId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
    }
}