using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{


    public Animator animator;
    static bool canJump = true;
    public float jumpCooldown = 0.49f;
    CharacterController2D controller;
   [SerializeField] private AudioClip[] clips;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController2D>();
        audioSource = GetComponent<AudioSource>();
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
                AudioClip clip = GetRandomClip();
                audioSource.PlayOneShot(clip);

            }

        }
        if(jumpCooldown <= 0) 
        {
            if (controller.m_Grounded)
            {

                animator.SetBool("Ground", true);
            }
            else
            {

                animator.SetBool("Ground", false);

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
    private AudioClip GetRandomClip()
    {

        return clips[UnityEngine.Random.Range(0, clips.Length)];
    
    }


}
