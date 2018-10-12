using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInput : MonoBehaviour {

    [SerializeField]
    private GameObject objInputManager;
    private InputManager inputManager;

    private enum state
    {
        acting,
        waiting,
    }
    private state playerState;

    [SerializeField]
    private GameObject objTimer;
    private Timer timer;

    [SerializeField]
    public int playerNumber;

    public bool Attacked { get; protected set; }
    public bool Punched { get; protected set; }
    public bool Headbutted { get; protected set; }
    public bool Kicked { get; protected set; }

	// Use this for initialization
	void Start ()
    {
        inputManager = objInputManager.GetComponent<InputManager>();

        timer = objTimer.GetComponent<Timer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // State machine. If acting, gets controller input. Controller input is interpreted by FightResult.cs
        switch (playerState)
        {
            // If acting, get player input. Once player input is got, [Attacked] is set true and
            // input is no longer gotten. (You get ONE SHOT)
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
                break;

            // If case is waiting, all variables are set false and another timer starts.
            case state.waiting:
                Attacked = false;
                Punched = false;
                Headbutted = false;
                Kicked = false;
                break;
        }

        // If timer is 0, switch states and set timer again.
        if (timer.TimeUp)
        {
            switch (playerState)
            {
                case state.acting:
                    playerState = state.waiting;
                    Debug.Log("state is now waiting for 60 frames");
                    timer.maxTime = 60;
                    break;
                case state.waiting:
                    playerState = state.acting;
                    Debug.Log("state is now acting for 300 frames");
                    timer.maxTime = 300;
                    break;
            }
        }
	}

    // In each of the following methods, Attacked and one attacking variable are set to true.
    // The other two variables remain false.
    private void AttackA()
    {
        Debug.Log("Player " + playerNumber + " punched (A)");

        Attacked = true;

        Punched = true;
    }

    private void AttackX()
    {
        Debug.Log("Player " + playerNumber + " headbutted (X)");

        Attacked = true;
        
        Headbutted = true;
    }

    private void AttackY()
    {
        Debug.Log("Player " + playerNumber + " kicked (Y)");

        Attacked = true;

        Kicked = true;
    }


}
