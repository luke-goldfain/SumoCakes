using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStates { Start, Playing, Pause, Loading, End}
public class GameState : MonoBehaviour {

    private GameStates currentGameState;

    public GameStates _GameState {
        get
        {
            return currentGameState;
        }

        private set
        {
            currentGameState = value;
        }
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        UpdateGameStates();

	}

    //used to switch the Scenes
    private void UpdateGameStates()
    {
        switch (_GameState)
        {
            case GameStates.Start:
                break;

            case GameStates.Playing:
                break;

            case GameStates.Pause:
                break;

            case GameStates.Loading:
                break;

            case GameStates.End:
                break;

            default:
                break;
        }
    }
}
