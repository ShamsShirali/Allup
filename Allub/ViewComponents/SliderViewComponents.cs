using Allub.DataAccessLayer;
using Allub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Allub.ViewComponents
{
    public class SliderViewComponents:ViewComponent
    {
        private readonly AppDbContext _context;

        public SliderViewComponents(AppDbContext context)
        {
            _context = context;
        }

         public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<Slider> sliders=await _context.Sliders.Where(s=>s.IsDeleted==false).ToListAsync();
            
            return View(sliders);
        }
    }
}
