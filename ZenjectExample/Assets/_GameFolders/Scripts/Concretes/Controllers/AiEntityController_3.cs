﻿using UnityEngine;
using Zenject;
using ZenjectExample.Abstracts.Movements;

namespace ZenjectExample.Controllers
{
    public class AiEntityController_3 : MonoBehaviour
    {
        [SerializeField] Vector2 _startPosition;
        [SerializeField] Vector2 _endPosition;
        [SerializeField] Transform _transform;

        Vector2 _direction;
        IMover _mover;

        [Inject]
        public void Constructor(IMover mover)
        {
            _mover = mover;
            _mover.SetTranslate(_transform);
        }

        void OnValidate()
        {
            if (_transform == null) _transform = GetComponent<Transform>();
        }

        void Start()
        {
            _direction = _startPosition;
        }

        protected virtual void Update()
        {
            MoveInputProcess();
        }

        void FixedUpdate()
        {
            _mover.FixedTick();
        }

        protected void MoveInputProcess(float speed = 1f)
        {
            if (Vector2.Distance(_direction, _transform.position) < 0.1f)
            {
                _direction = _startPosition == _direction ? _endPosition : _startPosition;
            }

            Vector2 direction = _direction - (Vector2)_transform.position;
            direction = direction.normalized;
            
            _mover.Tick(direction * speed);
        }
    }
}