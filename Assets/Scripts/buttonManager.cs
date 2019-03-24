using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager: MonoBehaviour
{
    public void newGameBtn (string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void exitGameBtn()
    {
        Application.Quit();
    }
}
