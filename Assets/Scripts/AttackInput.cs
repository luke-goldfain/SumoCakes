using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInput : MonoBehaviour {
    
    private InputManager inputManager;

    [SerializeField]
    public int playerNumber;

    public bool Punched { get; protected set; }
    public bool Headbutted { get; protected set; }
    public bool Kicked { get; protected set; }

	// Use this for initialization
	void Start ()
    {
        inputManager = new InputManager();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (playerNumber == 1)
        {
            if (inputManager.Joy1A())
            {
                AttackA();
            }

            if (inputManager.Joy1X())
            {
                AttackX();
            }

            if (inputManager.Joy1Y())
            {
                AttackY();
            }
        }

        if (playerNumber == 2)
        {
            if (inputManager.Joy2A())
            {
                AttackA();
            }

            if (inputManager.Joy2X())
            {
                AttackX();
            }

            if (inputManager.Joy2Y())
            {
                AttackY();
            }
        }
	}

    private void AttackA()
    {
        Punched = true;
        Headbutted = false;
        Kicked = false;
    }

    private void AttackX()
    {
        Punched = false;
        Headbutted = true;
        Kicked = false;
    }

    private void AttackY()
    {
        Punched = false;
        Headbutted = false;
        Kicked = true;
    }


}
