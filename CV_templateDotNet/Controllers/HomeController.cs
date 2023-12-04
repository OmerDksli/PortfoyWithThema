using CV_templateDotNet.Data;
using CV_templateDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace CV_templateDotNet.Controllers
{
    public class HomeController : Controller
    { 
        private readonly ILogger<HomeController> _logger;
       
        private readonly CVtemplateDotNetContext _context;
        public HomeController(ILogger<HomeController> logger,CVtemplateDotNetContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult ThemUI() 
        {
            MyCollections myCollections = new() {
                Projects=_context.Projects.Include(obj=>obj.Images).ToList(),
                Users=_context.User.Include(obj=>obj.ProfilImage).ToList(),
                Educations=_context.Educations.ToList(),
                Skills=_context.Skills.ToList(),
                NetworkReferances=_context.NetworkReferances.ToList(),
            };
            
            
            return View(myCollections);
        }

        public IActionResult Index()
        {
            return View();
         }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
    public class MyCollections
        {
            
            
            public ICollection<Project> Projects { get; set; }
            public ICollection<User> Users { get; set; }
            public ICollection<Education> Educations{ get; set; }
            public ICollection<Skill> Skills  { get; set; }
            public ICollection<NetworkReferances> NetworkReferances { get; set; }

        }
}
