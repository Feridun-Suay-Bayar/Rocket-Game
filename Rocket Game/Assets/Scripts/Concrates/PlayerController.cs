using Rocket.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Rocket.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force;
        Rigidbody rb;
        DefaultInput _input;

        bool _isForceUp;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            _input = new DefaultInput();
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
        }
        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                rb.AddForce(Vector3.up * Time.fixedDeltaTime * _force);
            }
        }
    }
}

