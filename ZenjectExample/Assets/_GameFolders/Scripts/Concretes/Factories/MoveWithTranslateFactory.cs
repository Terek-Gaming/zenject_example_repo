using UnityEngine;
using Zenject;
using ZenjectExample.Abstracts.Movements;
using ZenjectExample.Movements;

namespace ZenjectExample.Factories
{
    public class MoveWithTranslateFactory : IFactory<Transform, IMover>
    {
        public IMover Create(Transform transform)
        {
            return new MoveWithTranslate(transform);
        }
    }
}