using System;
using System.ComponentModel.DataAnnotations;

namespace SinavOlusturma.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string QuestionName { get; set; }
        public string FirstOption { get; set; }
        public string SecondOption { get; set; }
        public string ThirdOption { get; set; }
        public string FourthOption { get; set; }
        public string CorrectAnswer { get; set; }
        public Guid QuizId { get; set; }
        public Quiz Quiz { get; set; }

    }
}
