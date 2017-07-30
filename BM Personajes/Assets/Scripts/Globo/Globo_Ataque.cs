using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo_Ataque : MonoBehaviour {
    public Animator animation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            animation.SetBool("ataque_Globo",true);
        }
        else
        {
            animation.SetBool("ataque_Globo", false);
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            animation.SetBool("ataque_Globo", false);
        }
    }
}

