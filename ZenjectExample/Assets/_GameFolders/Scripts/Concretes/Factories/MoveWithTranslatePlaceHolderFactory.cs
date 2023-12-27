using UnityEngine;
using Zenject;
using ZenjectExample.Abstracts.Movements;

namespace ZenjectExample.Factories
{
    public class MoveWithTranslatePlaceHolderFactory : PlaceholderFactory<Transform, IMover>
    {
        
    }
}