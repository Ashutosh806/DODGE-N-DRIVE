using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        Debug.Log("Reloading");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            // Load the next level in build order
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            // If the current scene is the last one, load the first scene (looping)
            SceneManager.LoadScene(0);
        }
    }
}
