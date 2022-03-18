using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace SinavOlusturma.Models
{
    public class QuizUser : IdentityUser
    {
        public string Name { get; set; }
    }
}