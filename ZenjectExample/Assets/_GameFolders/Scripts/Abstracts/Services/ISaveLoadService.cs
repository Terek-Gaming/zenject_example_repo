namespace ZenjectExample.Services
{
    public interface ISaveLoadService
    {
        public void SaveData(string key, object value);
        public T LoadData<T>(string key);
    }
}