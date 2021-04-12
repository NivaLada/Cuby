using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;


    public float sidemovespeed = 40f;
    float sidemove = 100f;
    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log( sidemove = Input.GetAxisRaw("Horizontal") * sidemovespeed); //General Movement l,r
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(sidemove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
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
}
    

