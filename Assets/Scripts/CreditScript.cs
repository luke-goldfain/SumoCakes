using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScript : MonoBehaviour
{

    //Function that changes scene to game scene. Change "" based on scene name.
    public void ChangeMenuScene(string sceneName)
    {
        //Loads credit scene.
        SceneManager.LoadScene("CreditsScene", LoadSceneMode.Single);
    }
}
