using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class levelSelecter : MonoBehaviour
{
    public void ButtonClicked()
    {
        print("test");
        try
        {
            SceneManager.LoadScene(EventSystem.current.currentSelectedGameObject.name);
        }
        catch
        {
        }
    }
}
