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
        Mover _mover;
        Rotator _rotator;
        Fuel _fuel;

        bool _canForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }
        
        void Update()
        {
            if (_input.IsForceUp && !_fuel.isEmpty)
            {
                _canForceUp= true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.01f);
            }  
            _leftRight= _input.LeftRight;
            
        }
        private void FixedUpdate()
        {
            if (_canForceUp)
            {
               _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }

            _rotator.FixedTick(_leftRight);
        }
    }
}

