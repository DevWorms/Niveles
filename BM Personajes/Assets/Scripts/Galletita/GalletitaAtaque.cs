using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalletitaAtaque : MonoBehaviour {
    public Animator Animacion;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Animacion.SetBool("ataque_Galleta", true);
        }
        else
        {
            Animacion.SetBool("ataque_Galleta", false);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Animacion.SetBool("ataque_Galleta", false);
        }
    }
}
