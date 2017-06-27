using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagmanMovement : PauseResume {

    public Animator anim;
    public Transform bagMan;
    public float velocidad;


    // Update is called once per frame
    override protected void PauseLoop()
    {

        anim.SetBool("isPaused",true);
        anim.SetBool("isIddle", false);
    }
    override protected void PlayLoop()
    {
        if (Input.GetKey("w"))
        {
            anim.SetBool("jumping", true);
            anim.SetBool("caminandoDer", false);
            anim.SetBool("isIddle", false);
            anim.SetBool("isAtacking", false);
            anim.SetBool("isPaused", false);
            bagMan.Translate((velocidad * new Vector2(0, 3)) * Time.deltaTime);

        }

        else if (Input.GetKey("d"))
        {
            anim.SetBool("caminandoDer", true);
            anim.SetBool("isIddle", false);
            anim.SetBool("jumping", false);
            anim.SetBool("isAtacking", false);
            anim.SetBool("isPaused", false);
            bagMan.Translate((velocidad * new Vector2(2, 0)) * Time.deltaTime);
        }
        else if (Input.GetKey("a"))
        {
            anim.SetBool("jumping", false);
            anim.SetBool("caminandoDer", false);
            anim.SetBool("isIddle", true);
            anim.SetBool("isAtacking", false);
            anim.SetBool("isPaused", false);
            bagMan.Translate((velocidad * new Vector2(-2, 0)) * Time.deltaTime);
        }
        else if (Input.GetKey("space"))
        {
            anim.SetBool("jumping", false);
            anim.SetBool("caminandoDer", false);
            anim.SetBool("isIddle", false);
            anim.SetBool("isAtacking", true);
            anim.SetBool("isPaused", false);
        }
        else
        {
            anim.SetBool("jumping", false);
            anim.SetBool("caminandoDer", false);
            anim.SetBool("isIddle", true);
            anim.SetBool("isAtacking", false);
            anim.SetBool("isPaused", false);

        }
       
        
    }

}
