using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;


    public float sidemovespeed = 40f;
    float sidemove = 100f;
    bool jump = false;

    float oldplayerpositionx = 0f;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            FindObjectOfType<AudioManager>().Play(SceneManager.GetActiveScene().name);
        }
        catch
        {
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log( sidemove = Input.GetAxisRaw("Horizontal") * sidemovespeed); //General Movement l,r
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        
        if(this.transform.position.y < -10) // check if player is falling an reset
        {
            AktionOnCollision();
        }
        
        if(this.oldplayerpositionx == 0f) // check first Frame and set position
        {
            this.oldplayerpositionx = this.transform.position.x;
        }
        else 
        {
            if (this.transform.position.x < this.oldplayerpositionx) // check if player is standing and reset
            {
                AktionOnCollision();
            }
            else
            {
                this.oldplayerpositionx = this.transform.position.x;
            }
        }
    }

    private void FixedUpdate()
    {
        controller.Move(sidemove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    /* Niklas Dorsch alter Collisionscode
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Collide")
        {
            if ((this.transform.position.x - coll.collider.transform.position.x) < 0)
            {
            if ((this.transform.position.y - coll.collider.transform.position.y) < 0)
                {
                   
                }
                else
                {
                    SceneManager.LoadScene("test_lvl");

                }

            }
            
        }
    }
    */
    private void AktionOnCollision()
    {
        // Animation / Sound after Collision

        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // restart Scene

    }
}
