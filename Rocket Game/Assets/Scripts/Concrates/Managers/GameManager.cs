using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket.Managers
{
    public class GameManager : MonoBehaviour
    {
        public event Action OnGameOver;
        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            MakeThisGameObjectSingleton();
        }

        private void MakeThisGameObjectSingleton()
        {
            if(Instance == null)
            {
                Instance= this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void GameOver()
        {
            if(OnGameOver != null)
            {
                OnGameOver();
            }
        }
    }
}

