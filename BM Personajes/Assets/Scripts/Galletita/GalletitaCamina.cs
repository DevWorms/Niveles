﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalletitaCamina : MonoBehaviour
{
    public GameObject StartPoint;
    public GameObject EndPoint;    
    public float EnemySpeed;
    private bool GoRight;
    public Animator galletita;
    public Animator bagman;

    // Use this for initialization
    void Start ()
    {        
        if (!GoRight)
        {
            transform.position = StartPoint.transform.position;
        }
        else
        {
            transform.position = EndPoint.transform.position;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (bagman.GetBool("ataque_Galleta") && GoRight)
        {
            galletita.SetBool("galletaAtacar", true);

            transform.position = new Vector3(transform.position.x - EnemySpeed * 3f * Time.deltaTime, transform.position.y, transform.position.z);
            
        }
        else
        {
            galletita.SetBool("galletaAtacar", false);
            if (!GoRight)
            {
                transform.position = Vector3.MoveTowards(transform.position, EndPoint.transform.position, EnemySpeed * Time.deltaTime);
                if (transform.position == EndPoint.transform.position)
                {
                    GoRight = true;
                    GetComponent<SpriteRenderer>().flipX = true;
                }
            }
            if (GoRight)
            {
                transform.position = Vector3.MoveTowards(transform.position, StartPoint.transform.position, EnemySpeed * Time.deltaTime);
                if (transform.position == StartPoint.transform.position)
                {
                    GoRight = false;
                    GetComponent<SpriteRenderer>().flipX = false;
                }
            }
        }
    }
}
