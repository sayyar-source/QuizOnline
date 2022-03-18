using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReflectionIT.Mvc.Paging;
using SinavOlusturma.Common.ViewModels;
using SinavOlusturma.Services.Interfaces;

namespace SinavOlusturma.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper mapper;
        private readonly IQuizService quizService;
        public HomeController(ILogger<HomeController> logger, IMapper mapper, IQuizService quizService)
        {
            this.mapper = mapper;
            this.quizService = quizService;
            _logger = logger;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var quizzes = (await this.quizService.GetAllQuizzes())
                .Select(mapper.Map<AllQuizzesViewModel>);
            var pagedQuizzes = PagingList.Create(quizzes, 8, page);
            return this.View(pagedQuizzes);
        }
        public IActionResult Privacy()
        {
            return View();
        }      
    }
}
