using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static string previousScene;

    public void LoadOptionsMenu()
    {
        previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("OptionsMenu");
    }

    public void LoadPreviousScene()
    {
        if (!string.IsNullOrEmpty(previousScene))
        {
            SceneManager.LoadScene(previousScene);
        }
    }
}