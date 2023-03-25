using Rocket.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
        public void ExitClicked()
        {
            GameManager.Instance.Exit();
        }
    }
}

