using AutoMapper;
using SinavOlusturma.Common.ServiceModels;
using SinavOlusturma.Common.ViewModels;
using SinavOlusturma.Models;

namespace SinavOlusturma.Common.Mapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            this.CreateMap<Quiz, QuizViewModel>().ReverseMap();
            this.CreateMap<Quiz, AllQuizzesViewModel>().ReverseMap();
            this.CreateMap<Question, QuestionViewModel>().ReverseMap();
            this.CreateMap<Quiz, AddQuestionBindingModel>().ReverseMap();
            this.CreateMap<QuizServiceModel, QuizViewModel>().ReverseMap();
            this.CreateMap<AnswersServiceModel, AnswersBindingModel>().ReverseMap();            
        }
    }
}