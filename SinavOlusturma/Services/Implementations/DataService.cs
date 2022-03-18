using SinavOlusturma.Data;
namespace SinavOlusturma.Services.Implementations
{
    public abstract class DataService
    {
        protected readonly QuizDbContext context;
        public DataService(QuizDbContext context)
        {
            this.context = context;
        }
    }
}
