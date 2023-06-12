using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScriptOnCollision : MonoBehaviour
{
    public string sceneName;
    public string scriptName;

    private bool hasLoadedScript = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!hasLoadedScript && collision.gameObject.CompareTag("Player"))
        {
            LoadScript();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasLoadedScript && other.CompareTag("Player"))
        {
            LoadScript();
        }
    }

    private void LoadScript()
    {
        hasLoadedScript = true;

        // Load the scene if a scene name is provided
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }

        // Load the script if a script name is provided
        if (!string.IsNullOrEmpty(scriptName))
        {
            GameObject targetObject = GameObject.Find(scriptName);
            if (targetObject != null)
            {
                MonoBehaviour script = targetObject.GetComponent<MonoBehaviour>();
                if (script != null)
                {
                    script.enabled = true;
                }
            }
        }
    }
}
