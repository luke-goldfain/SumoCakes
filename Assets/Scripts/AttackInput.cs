using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInput : MonoBehaviour {
    
    private InputManager inputManager;

    private enum state
    {
        acting,
        waiting,
    }
    private state playerState;

    private int timer;

    [SerializeField]
    public int playerNumber;

    public bool Attacked { get; protected set; }
    public bool Punched { get; protected set; }
    public bool Headbutted { get; protected set; }
    public bool Kicked { get; protected set; }

	// Use this for initialization
	void Start ()
    {
        inputManager = new InputManager();

        timer = 300;
	}
	
	// Update is called once per frame
	void Update ()
    {
        switch (playerState)
        {
            case state.acting:
                if (!Attacked)
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

                timer--;
                break;

            case state.waiting:
                Attacked = false;
                Punched = false;
                Headbutted = false;
                Kicked = false;
                timer--;
                break;
        }

        if (timer <= 0)
        {
            Debug.Log("timer hit 0");

            switch (playerState)
            {
                case state.acting:
                    playerState = state.waiting;
                    timer = 60;
                    break;
                case state.waiting:
                    playerState = state.acting;
                    timer = 300;
                    break;
            }
        }
	}

    private void AttackA()
    {
        Attacked = true;

        Punched = true;
        Headbutted = false;
        Kicked = false;
    }

    private void AttackX()
    {
        Attacked = true;

        Punched = false;
        Headbutted = true;
        Kicked = false;
    }

    private void AttackY()
    {
        Attacked = true;

        Punched = false;
        Headbutted = false;
        Kicked = true;
    }


}
