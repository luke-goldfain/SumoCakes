using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInput : MonoBehaviour {

    // Input manager, applied in editor, that grabs controller inputs.
    [SerializeField]
    private GameObject objInputManager;
    private InputManager inputManager;

    // Simple state machine enum
    private enum state
    {
        acting,
        waiting,
    }
    private state playerState;

    // Timer object, applied in editor, used to determine when rounds end and start.
    // MAKE SURE THIS IS THE SAME GAMEOBJECT THAT ROUNDMANAGER USES!
    [SerializeField]
    private GameObject objTimer;
    private Timer timer;

    // Int applied in editor denoting the player's number. 1 for player 1, 2 for player 2.
    [SerializeField]
    public int playerNumber;

    // Booleans denoting whether the player attacked, and what attack they used. Referenced by RoundManager (FightResult.cs).
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

        // If timer is 0, switch states and set timer to maxTime again.
        if (timer.isTimeRunOut)
        {
            switch (playerState)
            {
                case state.acting:
                    playerState = state.waiting;
                    break;
                case state.waiting:
                    playerState = state.acting;
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
