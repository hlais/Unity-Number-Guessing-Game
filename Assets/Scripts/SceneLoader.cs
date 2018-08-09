using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//added name space
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {



    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
