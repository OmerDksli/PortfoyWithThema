using BussinesLogicLayer;
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

        
        // GET: Users/Edit/5
        public async Task<IActionResult> ImageEdit(int? id)
        {
            if (id == null || _context.ImagePaths == null)
            {
                return NotFound();
            }

            var imagePath = await _context.ImagePaths.FindAsync(id);
            if (imagePath == null)
            {
                return NotFound();
            }
            return View(imagePath);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ImageEdit(int id, ImagePath imagePath)
        {
            if (id != imagePath.Id)
            {
                return NotFound();
            }


            
            
            if (ModelState.IsValid)
            {
                _context.editImage(imagePath);
                try
                {
                   
                    if (imagePath.ImageFile != null)
                    {
                        ImageCalibration imageCalibration = new();
                        imagePath.CvImagePath = imageCalibration.ImageSaveInFileAsync(imagePath.ImageFile).Result;
                     }
                    
                    _context.Update(imagePath);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                    if (!(_context.ImagePaths?.Any(e => e.Id == imagePath.Id)).GetValueOrDefault())
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(imagePath);
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
