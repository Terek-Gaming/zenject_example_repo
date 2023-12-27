using UnityEngine;
using ZenjectExample.Abstracts.Movements;

namespace ZenjectExample.Movements
{
    public class MoveWithTranslate : IMover
    {
        readonly float _speed = 5f;
        Transform _transform;
        
        Vector2 _movement;
        
        public MoveWithTranslate(Transform transform)
        {
            _transform = transform;
        }

        public MoveWithTranslate()
        {
            
        }

        public void SetTranslate(Transform transform)
        {
            _transform = transform;
        }
        
        public void Tick(Vector2 direction)
        {
            _movement = _speed * Time.deltaTime * direction;
        }

        public void FixedTick()
        {
            _transform.Translate(_movement);
        }
    }
}