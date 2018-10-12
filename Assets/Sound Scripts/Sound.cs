// Code used from Brackleys Introduction to Audio in Unity

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
[System.Serializable] //Used so we can see the options within Unity itself

public class Sound //Class used to change factors of our audio source like volume, pitch etc. 

{

    public string name; //name of the sound

    public AudioClip clip; //links the audio clip

    public float volume; //change the volume
    
    public float pitch; //change the pitch

    public bool loop; //if you want to loop the sound


    [HideInInspector]
    public AudioSource source; //the access variable of the audio source. We can call methods using this. 

}