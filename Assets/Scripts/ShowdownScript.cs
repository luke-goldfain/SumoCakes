using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowdownScript : MonoBehaviour {
    //Function that changes scene to game scene. Change "" based on scene name.
    public void ChangeMenuScene(string sceneName)
    {
        //Loads game scene.
        SceneManager.LoadScene("ShowdownScene", LoadSceneMode.Single);
    }
}
