using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rocket.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishLights;
        [SerializeField] GameObject _finishFireWorksLights;

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();

            if(player == null)
            {
                return;
            }
            if(collision.GetContact(0).normal.y == -1)
            {
                _finishLights.SetActive(true);
                _finishFireWorksLights.SetActive(true);
            }
            else
            {
                //GameOver
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}

