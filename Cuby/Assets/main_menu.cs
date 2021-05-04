using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    public void singleplayerstart()
    {
        SceneManager.LoadScene("test_lvl");
    }

    public void altf4()
    {
        Application.Quit();
    }
    public void Char() {

        SceneManager.LoadScene("test_lvl");
    }
}
