
using System;
using System.Collections.Generic;

namespace SinavOlusturma.Common.ViewModels
{
    public class QuizViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string QuizUrl { get; set; }
        public DateTime date { get; set; }
        public ICollection<QuestionViewModel> QuizQuestions { get; set; }
        public List<AnswersBindingModel> Answers { get; set; }
    }
}
