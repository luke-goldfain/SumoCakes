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

    [Range(0f, 3f)]
    public float volume = 0.7f; //change the volume

    [Range(0.5f, 1.5f)]
    public float pitch = 1; //change the pitch

    public bool loop; //if you want to loop the sound

    public bool mute; //mute the source


    [HideInInspector]
    public AudioSource source; //the access variable of the audio source. We can call methods using this. 

    public void SetSource (AudioSource _source)
    {
        source = _source;
        source.clip = clip;
    }

    public void Play()
    {
        source.volume = volume;
        source.pitch = pitch;
        source.Play();
    }
}