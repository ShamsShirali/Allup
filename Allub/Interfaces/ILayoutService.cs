using Allub.Models;

namespace Allub.Interfaces
{
    public interface ILayoutService
    {
        Task<List<Setting>> GetSetting();
    }
}
