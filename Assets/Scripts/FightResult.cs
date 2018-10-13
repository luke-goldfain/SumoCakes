using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightResult : MonoBehaviour {

    // Player objects, applied in editor, representing players 1 and 2
    [SerializeField]
    private AttackInput player1;
    [SerializeField]
    private AttackInput player2;

    // Timer object, applied in editor, representing the Round Timer.
    // MAKE SURE THIS IS THE SAME TIMER OBJECT AS THE PLAYER ONES!
    [SerializeField]
    private GameObject objTimer;
    private Timer timer;

    [SerializeField]
    private GameObject timerSprite;

    public Transform space { get; protected set; }

	// Use this for initialization
	void Start ()
    {
        timer = objTimer.GetComponent<Timer>();

        player1.transform.position = new Vector3(-2, 0, 0);
        player2.transform.position = new Vector3(2, 0, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        // TranslateSpace only actually does anything when this object's timer's TimeUp is true
        TranslateSpace();
	}

    private int DetermineRound()
    {
        // Both players are translated by the amount of units here. 
        // Numbers subject to change!

        // Player 2 victories
        if (player1.Punched && player2.Headbutted)
        {
            return 3;
        }
        else if (player1.Headbutted && player2.Kicked)
        {
            return 2;
        }
        else if (player1.Kicked && player2.Punched)
        {
            return 1;
        }

        // Player 1 victories
        else if (player2.Punched && player1.Headbutted)
        {
            return -3;
        }
        else if (player2.Headbutted && player1.Kicked)
        {
            return -2;
        }
        else if (player2.Kicked && player1.Punched)
        {
            return -1;
        }
        // Default case (ties and one-player-does-nothing rounds)
        else return 0;
    }

    private void TranslateSpace()
    {
        // If this game object's timer hits 0, player objects are transformed
        // based on the round's results.
        if (timer.isTimeRunOut)
        {
            if (timerSprite.activeSelf == true)
            {
                timerSprite.SetActive(false);
            }
            else timerSprite.SetActive(true);

            player1.transform.Translate(DetermineRound(), 0, 0);
            player2.transform.Translate(DetermineRound(), 0, 0);
        }
    }
}
