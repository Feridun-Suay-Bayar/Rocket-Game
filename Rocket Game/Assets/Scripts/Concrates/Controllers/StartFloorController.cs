using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket.Controllers
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision collision)
        {
            PlayerController playerController = collision.collider.GetComponent<PlayerController>();

            if (playerController != null)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}

