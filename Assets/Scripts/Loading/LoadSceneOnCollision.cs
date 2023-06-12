using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnCollision : MonoBehaviour
{
    public string sceneName;
    public GameObject loadingScreen;

    private bool isLoading = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isLoading && collision.gameObject.CompareTag("Player"))
        {
            StartSceneTransition();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isLoading && other.CompareTag("Player"))
        {
            StartSceneTransition();
        }
    }

    private void StartSceneTransition()
    {
        isLoading = true;

        // Activate the loading screen
        loadingScreen.SetActive(true);

        // Load the scene asynchronously
        SceneManager.LoadSceneAsync(sceneName);
    }
}