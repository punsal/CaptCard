using UnityEngine;

namespace App.Runtime.Config
{
    [System.Serializable]
    public class AppConfig
    {
        [SerializeField] private string sceneToLoad;
        [SerializeField] private float sceneLoadDelay;

        public string GetSceneToLoad()
        {
            return sceneToLoad;
        }

        public float GetSceneLoadDelay()
        {
            return sceneLoadDelay;
        }
    }
}
