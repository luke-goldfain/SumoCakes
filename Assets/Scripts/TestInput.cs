using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {


        if (Input.GetButtonDown("joy1A"))
        {
            Debug.Log("joystick 1 A pressed");
        }

        if (Input.GetButtonDown("joy1B"))
        {
            Debug.Log("joystick 1 B pressed");
        }

        if (Input.GetButtonDown("joy1X"))
        {
            Debug.Log("joystick 1 X pressed");
        }
    }
}
