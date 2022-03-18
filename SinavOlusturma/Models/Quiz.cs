﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SinavOlusturma.Models
{
    public class Quiz
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string QuizUrl { get; set; }
        public string date { get; set; }
        public List<Question> QuizQuestions { get; set; }

    }
}
