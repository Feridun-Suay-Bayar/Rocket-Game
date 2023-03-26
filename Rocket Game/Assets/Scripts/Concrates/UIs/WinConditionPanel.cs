using Rocket.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rocket.UIs
{
    public class WinConditionPanel : MonoBehaviour
    {
        public void YesChick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }
}

