﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //Function that changes scene to controls scene. Change "" based on scene name.
    public void ChangeMenuScene(string sceneName)
    {
        //Loads main menu scene.
<<<<<<< HEAD
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Single);
=======
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
>>>>>>> MainMenu2
    }
}
