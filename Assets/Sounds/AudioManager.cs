using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds; //used to make an array of sounds and change their factors accordingly in the Awake method

    public static AudioManager instance; //to detect the instance of AudioManager in Unity

    void Start() //use this method for default sounds that will play
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            GameObject _go = new GameObject("Sound_ " + i + "_" + sounds[i].name);
            sounds[i].SetSource (_go.AddComponent<AudioSource>());
        }

        PlaySound("Theme");
    }

    void Awake()
    {

        if (instance != null)
        {
            Debug.LogError("More than one AudioManager in the scene.");
        } else
        {
            instance = this;
        }

        if (instance == null) //To remove duplicate instances of AudioManager, even though it's static. 
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject); //Doesn't break the sounds when switching scenes

        foreach (Sound s in sounds) //See Sound.cs to see the different factors affected
        {
            s.source = gameObject.AddComponent<AudioSource>(); //We need to store the Audio Source in a variable 
                                                               //but we don't really want to see it in the inspector

            s.source.clip = s.clip;

            s.source.volume = s.volume; //volume changer
            s.source.pitch = s.pitch; //pitch mixer
            s.source.loop = s.loop; //loop's the sound clip
            s.source.mute = s.mute;
        }
    }

    public void PlaySound(string _name)
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].name == _name)
            {
                sounds[i].Play();
                return;
            }
        }

        // no sound with _name
        Debug.LogWarning("AudioManager: Sound not found in list: " + _name);
    }
}

/*
 * Add this code to wherever you want to play a certain sound:  FindObjectOfType<AudioManager>().Play("PlayerDeath");
 * Use that line of code anywhere, whenever you want to play any sound. Simple change the string name. 
 * This line of code is NOT to be put in AudioManager.cs or in Sound.cs. Place it in the particular class of the source code. 
 *
 */