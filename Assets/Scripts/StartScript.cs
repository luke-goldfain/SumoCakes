using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

   

	// Use this for initialization
	public void ChangeMenuScene(string sceneName)
    {
        SceneManager.LoadScene("ControlScene", LoadSceneMode.Single);
    }
}
