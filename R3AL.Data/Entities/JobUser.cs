using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R3AL.Data.Entities
{
    [Table(nameof(JobUser))]
    public class JobUser
    {
        public int JobUserId { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        [Required]
        public int JobId { get; set; }

        public Job Job { get; set; }
    }
}