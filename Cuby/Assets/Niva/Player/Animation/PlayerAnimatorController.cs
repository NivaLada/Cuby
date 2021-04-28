using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{


    public Animator animator;
    static bool canJump = true;
    public float jumpCooldown = 0.49f;

    // Start is called before the first frame update
    void Start()
    {

    }
   
    // Update is called once per frame
    void Update()
    {
        jumpCooldown -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            if (CoolDownFunction())
            {

                animator.SetTrigger("Jump");

            }

        }
        

    }
    public bool CoolDownFunction()
    {
       
    
        if (jumpCooldown <= 0)
        {
            
            jumpCooldown = 0.49f;
            return true;
        }
        return false;
    }


}
