using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInput : MonoBehaviour {
    
    private InputManager testInput;

	// Use this for initialization
	void Start ()
    {
        testInput = new InputManager();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (testInput.Joy1A())
        {
            AttackA();
        }
	}

    private void AttackA()
    {
        Debug.Log("Pancake 1 Attacks");
    }
}
