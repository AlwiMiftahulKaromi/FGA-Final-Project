using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public void BackButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
