using Microsoft.AspNetCore.Mvc;
using TestDependencyInjection.Models;
using TestDependencyInjection.Services;

namespace TestDependencyInjection.Controllers
{
    [Route("di")]
    public class DiController : Controller
    {
        public ISingletonService _singletonService;
        public IScopedService _scopedService;
        public ITransientService _transientService;
        public DiController(IServiceProvider serviceProvider  ) 
        {
            _singletonService = serviceProvider.GetRequiredService<ISingletonService>();
            _scopedService = serviceProvider.GetRequiredService<IScopedService>(); ; 
            _transientService = serviceProvider.GetRequiredService<ITransientService>(); ;   

        }
        public IActionResult Index()
        {
            var model = new DIModel();
            model.SingletonTime = _singletonService.Time;
            model.ScopedTime = _scopedService.Time;
            model.TransientTime = _transientService.Time;

            return View(model);
        }
    }
}
