using Allub.Models;
using Allub.ViewModels.BasketVMs;

namespace Allub.Interfaces
{
    public interface ILayoutService
    {
        Task<List<Setting>> GetSetting();
        Task<IEnumerable<Category>> GetCategories();
        Task<List<BasketVM>> GetBasket();
    }
}
