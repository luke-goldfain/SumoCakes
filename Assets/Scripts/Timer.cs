using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    // MAKE SURE EACH PLAYER GAME OBJECT AND THE ROUNDMANAGER EACH AHVE THEIR OWN COPY OF TIMER!

    // Pretty simple... currentTime is set to maxTime, decrements each frame, and when it is 0
    // TimeUp is set to true. Each object that has a timer uses TimeUp to do something specific.
    [SerializeField]
    public int maxTime;
    private float currentTime;

    public bool isTimeRunOut { get; protected set; }

	// Use this for initialization
	void Start ()
    {
        // At start, currentTime set to maxTime (which is set in editor, then by each script)
        currentTime = maxTime;

        isTimeRunOut = false;
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        // currentTime decremented.
        currentTime -= Time.deltaTime;

        // if currentTime is 0, TimeUp is set to true and currentTime is set to
        // maxTime (which changes in AttackInput.cs, but doesn't change in FightResult.cs)
        if (currentTime < 0)
        {
            isTimeRunOut = true;

            currentTime = maxTime;
        }
        else
        {
            isTimeRunOut = false;
        }

        //isTimeRunOut = false;

    }

}
