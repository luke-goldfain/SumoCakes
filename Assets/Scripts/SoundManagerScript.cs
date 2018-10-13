using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {
    public static AudioClip playerJump, playerDeath, checkpointGet;
    public static AudioClip doHeadBut6, doKick4, doPunch3;
    static AudioSource audioSrc;
    // Use this for initialization
    void Start () {
        //playerJump = Resources.Load<AudioClip>("jump");
        doHeadBut6 = Resources.Load<AudioClip>("HeadBut6");
        doKick4 = Resources.Load<AudioClip>("Kick4");
        doPunch3 = Resources.Load<AudioClip>("Punch3");
        audioSrc = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            /*case "doJump":
                audioSrc.PlayOneShot(playerJump);
                //Debug.Log("Playing jump sound effect.");
                break;
            case "playerDies":
                audioSrc.PlayOneShot(playerDeath);
                Debug.Log("Playing death sound effect.");
                break;
            case "hitCheckpoint":
                audioSrc.PlayOneShot(checkpointGet);
                //Debug.Log("Playing jump sound effect.");
                break;*/
            case "useHeadbutt":
                audioSrc.PlayOneShot(doHeadBut6);
                //Debug.Log("Playing jump sound effect.");
                break;
            case "useKick":
                audioSrc.PlayOneShot(doKick4);
                //Debug.Log("Playing jump sound effect.");
                break;
            case "usePunch":
                audioSrc.PlayOneShot(doPunch3);
                //Debug.Log("Playing jump sound effect.");
                break;
        }
    }
}
