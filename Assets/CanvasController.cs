using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {

    [SerializeField]
    private GameObject canvas;

    bool GameEnded;

	// Use this for initialization
	void Start ()
    {
        GameEnded = false;

        canvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        canvas.SetActive(GameEnded);

        // TODO: Set an image on canvas to reflect winner
	}
}
