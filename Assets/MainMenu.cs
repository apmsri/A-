using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Map1()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Map2()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Map3()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
