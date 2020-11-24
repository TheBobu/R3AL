using System.Collections.Generic;

namespace R3AL.Dtos
{
    public class QuestionDto
    {
        public int QuestionId { get; set; }
        public List<ResponseDto> Responses { get; set; }
        public string Title { get; set; }
    }
}