using UnityEngine;

namespace ZenjectExample.Abstracts.Movements
{
    public interface IMover
    {
        void Tick(Vector2 direction);
        void FixedTick();
    }
}