using SinavOlusturma.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SinavOlusturma.Services.Interfaces
{
    public interface IQuizService
    {
        Task<Guid> CreateQuiz(Quiz quiz);
        Task DeleteQuiz(Guid id);
        Task<IEnumerable<Quiz>> AllQuizzes();
        Task<IEnumerable<Quiz>> GetAllQuizzes();
        Task<Quiz> GetQuizById(Guid id);
        Task<List<Quiz>> GetSearchingResults(string searchTerm);
        Task<string> DescriptionQuiz(string url);
    }
}
