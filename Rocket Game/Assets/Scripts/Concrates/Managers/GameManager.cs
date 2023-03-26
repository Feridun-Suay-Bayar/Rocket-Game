using Rocket.Abstracts.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rocket.Managers
{
    public class GameManager : SingletonThisObject<GameManager>
    {
        public event Action OnGameOver;
        public event Action OnMissionSucced;

        private void Awake()
        {
            MakeThisGameObjectSingleton(this);
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
            SoundManager.Instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
            SoundManager.Instance.PlaySound(2);
        }
        public void LoadMenuScene()
        { 
            StartCoroutine(LoadMenuSceneAsync());
        }
        private IEnumerator LoadMenuSceneAsync()
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.PlaySound(1);
        }
        public void Exit()
        {
            Application.Quit();
        }
    }
}

