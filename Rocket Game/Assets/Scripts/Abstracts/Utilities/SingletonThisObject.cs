using Rocket.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket.Abstracts.Utilities
{
    public abstract class SingletonThisObject<T> : MonoBehaviour
    {
        public static T Instance { get; private set; }

        protected void MakeThisGameObjectSingleton(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}

