using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Character_Select : MonoBehaviour
{


    public GameObject player;
    public Sprite skin;


    public void Cube() 
    {



       
            player.GetComponent<SpriteRenderer>().sprite = skin;
    }
    
}
