using Allub.DataAccessLayer;
using Allub.Interfaces;
using Allub.Models;
using Microsoft.EntityFrameworkCore;

namespace Allub.Services
{
    public class LayoutService: ILayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Setting>> GetSetting()
        {
            List<Setting> settings=await _context.Settings.ToListAsync();

            return settings;
        }
    }
}
