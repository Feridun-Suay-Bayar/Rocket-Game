using Rocket.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket.Movements
{
    public class Rotator
    {
        Rigidbody _rb;
        PlayerController _controller;

        public Rotator(PlayerController controller)
        {
            _rb = controller.GetComponent<Rigidbody>();
            _controller = controller;
        }

        public void FixedTick(float direction)
        {
            if (direction == 0)
            {
                if (_rb.freezeRotation) { _rb.freezeRotation = false; }
                return;
            }
            if (!_rb.freezeRotation) { _rb.freezeRotation = true; }

            _controller.transform.Rotate(Vector3.back * Time.deltaTime * direction * _controller.TurnSpeed);

        }
    }
}

