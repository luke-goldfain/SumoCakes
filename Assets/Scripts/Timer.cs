using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    
    public int maxTime;
    private int currentTime;

    public bool TimeUp { get; protected set; }

	// Use this for initialization
	void Start ()
    {
        currentTime = maxTime;

        TimeUp = false;
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        currentTime--;

        if (currentTime <= 0)
        {
            TimeUp = true;

            currentTime = maxTime;
        }
        else TimeUp = false;
    }

}
