using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

    //Function that changes scene to controls scene. Change "" based on scene name.
    public void ChangeMenuScene(string sceneName)
    {
        //Loads controls scene.
        SceneManager.LoadScene("ControlScene", LoadSceneMode.Single);
    }
}
