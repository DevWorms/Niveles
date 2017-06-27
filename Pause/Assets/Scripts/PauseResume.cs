using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour {

    private BagmanPause Pause;
    private enum States {play,pause}
    private States State;

	// Use this for initialization
	void Start () {
        Pause = GameObject.Find("Pause").GetComponent<BagmanPause>();
        State = States.play;
	}
	
	// Update is called once per frame
	void Update () {
        if (Pause.isGamePaused()){
            if (State == States.play)
            {
                State = States.pause;
                
            }
          
            PauseLoop();
        }
        else
        {
            if (State == States.pause) { 
                State = States.play;
            }
            PlayLoop();
        }
		
	}

    virtual protected void PauseLoop()
    {

    }
    virtual protected void PlayLoop()
    {

    }
}
