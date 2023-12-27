using UnityEngine;
using ZenjectExample.Services;

namespace ZenjectExample.Controllers
{
    public class CloudSaveTest_1 : MonoBehaviour
    {
        [Zenject.Inject(Id="Cloud")] public ISaveLoadService SaveLoadService { get; private set; }

        [ContextMenu(nameof(SaveData))]
        public void SaveData()
        {
            SaveLoadService.SaveData("sdfsf", this);
        }

        [ContextMenu(nameof(LoadData))]
        public void LoadData()
        {
            SaveLoadService.LoadData<object>("sdfsf");
        }
    }
}