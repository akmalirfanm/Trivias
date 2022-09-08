using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Trivias.Global.SaveData
{
    public class SaveData : MonoBehaviour
    {
        public static Action<int> OnLoadLevelFinished;
        public static SaveData instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void OnEnable()
        {
            
            
        }

        private void OnDisable()
        {
            
        }

        protected void SavePlayerProgress()
        {
            
        }

        
    }
}
