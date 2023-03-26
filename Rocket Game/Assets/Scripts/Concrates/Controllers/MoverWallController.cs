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

        Vector3 startPosition;

        private void Awake()
        {
            startPosition = transform.position;
        }

        private void Update()
        {
            Vector3 offset = _direction * _factor;
            transform.position = startPosition + offset;
        }
    }
}

