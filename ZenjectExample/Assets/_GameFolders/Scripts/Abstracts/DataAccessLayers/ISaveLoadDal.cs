using System.Threading.Tasks;

namespace ZenjectExample.Abstracts.DataAccessLayers
{
    public interface ISaveLoadDal
    {
        Task SaveDataAsync(string key, object value);
        Task<T> LoadDataAsync<T>(string key);
    }
}