using ZenjectExample.Abstracts.DataAccessLayers;
using ZenjectExample.Services;

namespace ZenjectExample.Managers
{
    public abstract class SaveLoadManager : ISaveLoadService
    {
        protected ISaveLoadDal _saveLoadDal;

        public void SaveData(string key, object value)
        {
            _saveLoadDal.SaveDataAsync(key, value);
        }

        public T LoadData<T>(string key)
        {
            return _saveLoadDal.LoadDataAsync<T>(key).ConfigureAwait(false).GetAwaiter().GetResult();
        }
    }

    public class LocalSaveLoadManager : SaveLoadManager
    {
        public LocalSaveLoadManager(ISaveLoadDal saveLoadDal)
        {
            _saveLoadDal = saveLoadDal;
        }
    }
    
    public class CloudSaveLoadManager  : SaveLoadManager
    {
        public CloudSaveLoadManager(ISaveLoadDal saveLoadDal)
        {
            _saveLoadDal = saveLoadDal;
        }
    }
}