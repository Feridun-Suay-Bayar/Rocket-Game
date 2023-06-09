using Rocket.Controllers;
using Rocket.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rocket.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController playerController = collision.collider.GetComponent<PlayerController>();

            if(playerController != null && playerController.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

