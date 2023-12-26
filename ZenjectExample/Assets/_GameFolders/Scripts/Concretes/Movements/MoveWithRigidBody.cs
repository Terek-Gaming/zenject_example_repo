using UnityEngine;
using ZenjectExample.Abstracts.Movements;

namespace ZenjectExample.Movements
{
    public class MoveWithRigidBody : IMover
    {
        readonly float _speed = 5f;
        readonly Rigidbody2D _rigidbody2D;
        
        Vector2 _movement;

        public MoveWithRigidBody(Transform transform)
        {
            _rigidbody2D = transform.GetComponent<Rigidbody2D>();
        }
        
        public void Tick(Vector2 direction)
        {
            _movement = _speed * Time.deltaTime * direction;
        }

        public void FixedTick()
        {
            _rigidbody2D.velocity = _movement;
        }
    }
}