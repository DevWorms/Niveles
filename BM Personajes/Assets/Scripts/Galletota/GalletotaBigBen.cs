using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalletotaBigBen : MonoBehaviour {

    public float EnemySpeed;    
    public Animator Galletota;
    public Animator Bagman;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Bagman.GetBool("ataque_Galletota"))
        {
            Galletota.SetBool("galletotaAtacar", true);
        }
        else
        {
            Galletota.SetBool("galletotaAtacar", false);
        }
	}
}
