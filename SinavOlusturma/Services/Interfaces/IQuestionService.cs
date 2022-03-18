

using SinavOlusturma.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SinavOlusturma.Services.Interfaces
{
    public interface IQuestionService
    {
        Task AddQuestion(Quiz quizquestion);
    }
}
