using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;       //Public variable to store a reference to the player game object


    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position + new Vector3(2, 0, 0);
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set camera's transform to be the same as the player's
        transform.position = player.transform.position + offset;
    }
}
