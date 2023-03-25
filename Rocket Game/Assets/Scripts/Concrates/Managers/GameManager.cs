using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rocket.Managers
{
    public class GameManager : MonoBehaviour
    {
        public event Action OnGameOver;
        public event Action OnMissionSucced;
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
        public void MissionSucced()
        {
            if (OnMissionSucced != null)
            {
                OnMissionSucced();
            }
        }
        public void LoadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }
        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
        }
        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }
        private IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }
        public void Exit()
        {
            Application.Quit();
        }
    }
}

