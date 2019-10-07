using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporting : MonoBehaviour
{
    public Transform teleportTarget; //new spot
    public GameObject thePlayer; //the object that is moving

    public void move()//collision
    {
        thePlayer.transform.position = teleportTarget.transform.position; //translate (equate the location to new location)
    }
}