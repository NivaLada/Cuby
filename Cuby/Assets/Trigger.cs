using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour 
{
    private Scene scene;
void start()
    {
        scene = SceneManager.GetActiveScene();
    }
    void OnTriggerEnter(Collider Other)
    {
        if(Other.gameObject.tag == "Player")
        {
            Application.LoadLevel(scene.name);
        }
    }

}
