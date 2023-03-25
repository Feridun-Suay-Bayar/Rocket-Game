using Rocket.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClick()
        {
            GameManager.Instance.LoadLevelScene();
        }
        public void NoClick()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}

