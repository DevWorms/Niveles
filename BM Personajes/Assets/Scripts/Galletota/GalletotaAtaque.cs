using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalletotaAtaque : MonoBehaviour {
    public Animator animacion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            animacion.SetBool("ataque_Galletota", true);
        }
        else
        {
            animacion.SetBool("ataque_Galletota", false);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            animacion.SetBool("ataque_Galletota", false);
        }
    }
}
