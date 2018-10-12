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

    }

    // Pretty self-explanatory class, gathers input from two controllers.

    public bool Joy1A()
    {
        return Input.GetButtonDown("joy1A");
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
