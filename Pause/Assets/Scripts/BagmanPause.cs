using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagmanPause : MonoBehaviour {

    public GameObject Pausa;
    private bool isPaused;

    // Use this for initialization
    void Start () {
        isPaused = false;
        Pausa.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            isPaused = !isPaused;
            if (isPaused)
            {
                Pausa.SetActive(true);
            }
            else
            {
            
                Pausa.SetActive(false);
            }
        }
       
      

    }
    public bool isGamePaused() {

        return isPaused;
    }
}
