using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerilloAtaca : MonoBehaviour {
    public Animator animationc;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            animationc.SetBool("ataque_Cerillo", true);
        }
        else
        {
            animationc.SetBool("ataque_Cerillo", false);
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            animationc.SetBool("ataque_Cerillo", false);
        }
    }
}

