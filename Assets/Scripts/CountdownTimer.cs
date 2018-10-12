using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownTimer : MonoBehaviour {

    public int timeLeft = 5;
    public Text countdownText;
	void Start ()
    {
        StartCoroutine("LoseTime");
	}
	
	// Update is called once per frame
	void Update ()
    {
        countdownText.text = ("" + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times up";
        }
	}

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
