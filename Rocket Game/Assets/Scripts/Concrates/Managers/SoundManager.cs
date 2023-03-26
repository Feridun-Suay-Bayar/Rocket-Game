using Rocket.Abstracts.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket.Managers
{
    public class SoundManager : SingletonThisObject<SoundManager>
    {
       AudioSource[] _audioSource;

        private void Awake()
        {
            MakeThisGameObjectSingleton(this);
            _audioSource = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {
            if (!_audioSource[index].isPlaying)
            {
                _audioSource[index].Play();
            }
        }
        public void StopSound(int index) 
        {
            if (_audioSource[index].isPlaying)
            {
                _audioSource[index].Stop();
            }
        }
       
    }
}

