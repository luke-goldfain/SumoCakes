using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RematchScript : MonoBehaviour
{
    //Function that changes scene to game scene. Change "" based on scene name.
    public void ChangeMenuScene(string sceneName)
    {
        //Loads game scene.
        SceneManager.LoadScene("ControlScene", LoadSceneMode.Single);
    }
}
