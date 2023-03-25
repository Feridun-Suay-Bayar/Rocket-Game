using Rocket.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket.Movements
{
    public class Mover
    {
        Rigidbody _rb;
        PlayerController _playerController;
        
        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rb= playerController.GetComponent<Rigidbody>();
        }
        public void FixedTick()
        {
            _rb.AddRelativeForce(Vector3.up * Time.fixedDeltaTime * _playerController.Force);
        }
        
    }
    
}

   
