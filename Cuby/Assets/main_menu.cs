using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    public void singleplayerstart()
    {
        SceneManager.LoadScene("levelselecter");
    }

    public void altf4()
    {
        Application.Quit();
    }
    public void Char() {

        SceneManager.LoadScene("Character_select");
    }
}
