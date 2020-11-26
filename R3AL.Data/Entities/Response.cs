using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R3AL.Data.Entities
{
    [Table(nameof(Response))]
    public class Response
    {
        public int ResponseId { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public Question Question { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public bool Correct { get; set; }
    }
}