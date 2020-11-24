using System;
using System.Collections.Generic;
using System.Text;
using R3AL.Dtos;

namespace R3AL.Core.Manager.Interfaces
{
    interface IQuizManager
    {
        IEnumerable<QuizDto> GetQuizzes(int goalId);
    }
}
