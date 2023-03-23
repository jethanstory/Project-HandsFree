using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAtPhoneScr : MonoBehaviour
{
    public bool isLooking;
    //public GameObject fpsPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameVisible()
    {
        isLooking = true;
    }

    void OnBecameInvisible()
    {
        isLooking = false;
    }

    // private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    // {
    //     if(other.gameObject.tag == "Looking") //on the object you want to pick up set the tag to be anything, in this case "object"
    //     {
    //         //canpickup = true;  //set the pick up bool to true
    //         isLooking = true;
            
    //     }
    // }
    // private void OnTriggerExit(Collider other)
    // {
    //     //canpickup = false; //when you leave the collider set the canpickup bool to false
    //     isLooking = false;
    // }
}
