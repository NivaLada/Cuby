using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
