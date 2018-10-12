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


        if (Joy1A())
        {
            Debug.Log("joystick 1 A pressed");
        }

        if (Joy1B())
        {
            Debug.Log("joystick 1 B pressed");
        }

        if (Joy1X())
        {
            Debug.Log("joystick 1 X pressed");
        }

        if (Joy1Y())
        {
            Debug.Log("joystick 1 y pressed");
        }

        if (Joy1Start())
        {
            Debug.Log("joystick 1 start pressed");
        }

        if (Joy2A())
        {
            Debug.Log("joystick 2 A pressed");
        }

        if (Joy2Start())
        {
            Debug.Log("joystick 2 start pressed");
        }
    }

    private bool Joy1A()
    {
        return Input.GetButtonDown("joy1A");
    }

    private bool Joy1B()
    {
        return Input.GetButtonDown("joy1B");
    }

    private bool Joy1X()
    {
        return Input.GetButtonDown("joy1X");
    }

    private bool Joy1Y()
    {
        return Input.GetButtonDown("joy1Y");
    }

    private bool Joy1Start()
    {
        return Input.GetButtonDown("joy1start");
    }

    private bool Joy2A()
    {
        return Input.GetButtonDown("joy2A");
    }

    private bool Joy2Start()
    {
        return Input.GetButtonDown("joy2start");
    }
}
