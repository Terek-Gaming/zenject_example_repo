using UnityEngine;
using ZenjectExample.Abstracts.Movements;
using ZenjectExample.Movements;

namespace ZenjectExample.Factories
{
    public class SimpleMoveFactory : IMoveFactory
    {
        public IMover Create(Transform transform)
        {
            return new MoveWithTranslate(transform);
        }
    }

    public interface IMoveFactory
    {
        IMover Create(Transform transform);
    }
}