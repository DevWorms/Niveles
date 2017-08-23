using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalletotaBigBen : MonoBehaviour {

    public float EnemySpeed;    
    public Animator Galletota;
    public Animator Bagman;
    public Animator bagman;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (bagman.GetBool("trepar_Galletota"))
        {
            Galletota.SetBool("galletotaTrepar", true);

            if (Bagman.GetBool("ataque_Galletota"))
            {
                Galletota.SetBool("galletotaAtacar", true);
            }

            else
            {
                Galletota.SetBool("galletotaAtacar", false);
            }
        }

        else
        {
            Galletota.SetBool("galletotaTrepar", false);
        }
	}
}
