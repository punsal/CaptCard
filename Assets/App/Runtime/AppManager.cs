using System.Collections;
using App.Runtime.Config;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace App.Runtime {
    public class AppManager : MonoBehaviour
    {
        private const string AppConfigPath = "appconfig";
        
        private AppConfig _config;
        private WaitForSeconds _wait;
        
        private void Start()
        {
            var appConfigJson = Resources.Load<TextAsset>(AppConfigPath);
            _config = JsonUtility.FromJson<AppConfig>(appConfigJson.text);
            
            _wait = new WaitForSeconds(_config.GetSceneLoadDelay());
            StartCoroutine(LoadScene(_config.GetSceneToLoad()));
        }

        private IEnumerator LoadScene(string sceneName)
        {
            yield return _wait;
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}