using Rocket.Abstracts.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [Range(0,1)]
        [SerializeField] float _factor;
        [SerializeField] float _speed;

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

            _factor = Mathf.Abs(sinWave);

            Vector3 offset = _direction * _factor;
            transform.position = startPosition + offset;
        }
    }
}

