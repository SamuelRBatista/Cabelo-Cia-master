using Microsoft.AspNetCore.Mvc;
using MyApp.Context;

namespace MyApp.Controllers
{
    public class CategoryServiceController : Controller
    {
        private readonly DataContext _context;

        public CategoryServiceController(DataContext context)
        {
            _context = context;
        }
    }
}
