﻿using SinavOlusturma.Models;
using System;
using System.Collections.Generic;
namespace SinavOlusturma.Common.ViewModels
{
    public class AllQuizzesViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }     
        public string QuizUrl { get; set; }
        public string date { get; set; }
        public List<Question> QuizQuestions { get; set; }
    }
}
