using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SinavOlusturma.Models;

namespace SinavOlusturma.Data
{
    public class QuizDbContext : IdentityDbContext<QuizUser>
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {          
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }  
    }
}
