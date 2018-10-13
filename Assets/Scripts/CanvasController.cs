using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{

    private AudioManager audioManager;

    [SerializeField]
    private GameObject player1;
    [SerializeField]
    private GameObject player2;

    private Component p1script;
    private Component p2script;

    [SerializeField]
    private GameObject roundManager;

    private Component rmscript;

    [SerializeField]
    private int pointsToWin;

    [SerializeField]
    private GameObject canvas;

    bool GameEnded;

    // Use this for initialization
    void Start()
    {
        //p1script = player1.GetComponent<AttackInput>();
        //p2script = player2.GetComponent<AttackInput>();

        //rmscript = roundManager.GetComponent<FightResult>();

        GameEnded = false;

        audioManager = AudioManager.instance;
        
        if (audioManager == null)
        {
            Debug.LogError("No audio manager found in this scene");
        }

        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        audioManager.PlaySound("Win");

        if (player1.transform.position.x <= -pointsToWin - 2 || player1.transform.position.x >= pointsToWin - 2)
        {
            GameEnded = true;
        }


        canvas.SetActive(GameEnded);


        player1.GetComponent<AttackInput>().enabled = !GameEnded;
        player2.GetComponent<AttackInput>().enabled = !GameEnded;
        roundManager.GetComponent<FightResult>().enabled = !GameEnded;

       


        // TODO: Set an image on canvas to reflect winner
    }
}