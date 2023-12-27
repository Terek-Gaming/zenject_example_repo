using System.Threading.Tasks;
using UnityEngine;
using ZenjectExample.Abstracts.DataAccessLayers;

namespace ZenjectExample.DataAccessLayers
{
    public class LocalSaveLoadDal : ISaveLoadDal
    {
        int _index = 0;
        
        public async Task SaveDataAsync(string key, object value)
        {
            await Task.Yield();
            _index++;
            Debug.Log("Data saved on local side => " + _index);
        }

        public async Task<T> LoadDataAsync<T>(string key)
        {
            await Task.Yield();
            Debug.Log("Data loaded on local side " + _index);

            return default;
        }
    }
}