using Rocket.Abstracts.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _speed;

        float _factor;
        Vector3 startPosition;
        private const float FULL_CYCLE = Mathf.PI * 2f;

        private void Awake()
        {
            startPosition = transform.position;
        }

        private void Update()
        {
            float cycle = Time.time / _speed;
            float sinWave = Mathf.Sin(cycle * FULL_CYCLE);

            //_factor = Mathf.Abs(sinWave);

            _factor = sinWave / 2f + 0.5f;

            Vector3 offset = _direction * _factor;
            transform.position = startPosition + offset;
        }
    }
}

