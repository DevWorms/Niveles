using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalletitaCamina : MonoBehaviour
{
    public GameObject StartPoint;
    public GameObject EndPoint;
    private AreaEffector2D galletita_T;
    public float EnemySpeed;
    private bool GoRight;
    public Animator galletita;
    public Animator bagman;

    // Use this for initialization
    void Start ()
    {
        galletita_T = GetComponent<AreaEffector2D>();
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
        if (bagman.GetBool("GalletitaAttack") && GoRight)
        {
            galletita.SetBool("atacar", true);
            galletita_T.enabled = true;

        }
        else
        {
            galletita.SetBool("atacar", false);
            galletita_T.enabled = false;
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
