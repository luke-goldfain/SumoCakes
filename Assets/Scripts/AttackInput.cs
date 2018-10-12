using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInput : MonoBehaviour {
    
    private InputManager inputManager;

    [SerializeField]
    private int playerNumber;

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
        Debug.Log("Pancake " + playerNumber + " uses A attack");
    }

    private void AttackX()
    {
        Debug.Log("Pancake " + playerNumber + " uses X attack");
    }

    private void AttackY()
    {
        Debug.Log("Pancake " + playerNumber + " uses Y attack");
    }


}
