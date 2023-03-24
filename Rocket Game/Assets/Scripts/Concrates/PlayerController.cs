using Rocket.Inputs;
using Rocket.Movements;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace Rocket.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _turnSpeed = 10f;
        [SerializeField] float _force = 55f;

        DefaultInput _input;
        private Mover _mover;
        private Rotator _rotator;

        bool _isForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
        }
        
        void Update()
        {
            if (_input.IsForceUp)
            {
                _isForceUp= true;
            }
            else
            {
                _isForceUp = false;
            }  
            _leftRight= _input.LeftRight;
            
        }
        private void FixedUpdate()
        {
            if (_isForceUp)
            {
               _mover.FixedTick();
            }

            _rotator.FixedTick(_leftRight);
        }
    }
}

