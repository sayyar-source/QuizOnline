using SinavOlusturma.Data;
using SinavOlusturma.Models;
using SinavOlusturma.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SinavOlusturma.Services.Implementations
{
    public class QuestionService : DataService, IQuestionService
    {
        public QuestionService(QuizDbContext context) : base(context)
        {
        }

        public async Task AddQuestion(Quiz quizquestion)
        {
            List<Question> questions = new List<Question>();
            foreach(var qs in quizquestion.QuizQuestions)
            {
                questions.Add(new Question
                {
                    QuizId=quizquestion.Id,
                    QuestionName=qs.QuestionName,
                    FirstOption=qs.FirstOption,
                    SecondOption=qs.SecondOption,
                    ThirdOption=qs.ThirdOption,
                    FourthOption=qs.FourthOption,
                    CorrectAnswer=qs.CorrectAnswer
                    
                });
            }
            await context.Questions.AddRangeAsync(questions);
            await this.context.SaveChangesAsync();
        }
    }
}
