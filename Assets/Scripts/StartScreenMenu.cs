using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScreenMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
