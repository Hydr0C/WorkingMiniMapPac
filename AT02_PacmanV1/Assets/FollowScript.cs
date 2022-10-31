using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform player; //creates a slot to put in an object

    void LateUpdate()
    {
        Vector3 newPosition = player.position; // finds the player's position
        newPosition.y = transform.position.y; // updates the variables to the player's new position
        transform.position = newPosition; // moves the camera to the new position

    }
}

