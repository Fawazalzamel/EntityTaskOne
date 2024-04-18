using EntityTaskOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityTaskOne.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var db = new BlogContext();
            return View(db.Blog.ToList());
        }

        public IActionResult Blog() { 

            using (var context = new BlogContext())
            {
                var blogs = context.Blog.ToList();
                return View(blogs);
            }
        
        }
    }
}
