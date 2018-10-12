using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

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

    public bool Joy1A()
    {
        return Input.GetButtonDown("joy1A");
    }

    public bool Joy1B()
    {
        return Input.GetButtonDown("joy1B");
    }

    public bool Joy1X()
    {
        return Input.GetButtonDown("joy1X");
    }

    public bool Joy1Y()
    {
        return Input.GetButtonDown("joy1Y");
    }

    public bool Joy1Start()
    {
        return Input.GetButtonDown("joy1start");
    }

    public bool Joy2A()
    {
        return Input.GetButtonDown("joy2A");
    }

    public bool Joy2X()
    {
        return Input.GetButtonDown("joy2X");
    }

    public bool Joy2Y()
    {
        return Input.GetButtonDown("joy2Y");
    }

    public bool Joy2Start()
    {
        return Input.GetButtonDown("joy2start");
    }
}
