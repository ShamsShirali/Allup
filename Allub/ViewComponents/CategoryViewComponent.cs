using Allub.DataAccessLayer;
using Allub.Models;
using Microsoft.AspNetCore.Mvc;

namespace Allub.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public CategoryViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<Category> categories)
        {
            //IEnumerable<Category> categories = await _context.Categories.Where(c => c.IsDeleted == false && c.IsMain).ToListAsync();

            return View(categories);
        }
    }
}
