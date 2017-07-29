using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloboCamina : MonoBehaviour {
    public GameObject StartPoint;
    public GameObject EndPoint;
    private AreaEffector2D globo_T;
    public float EnemySpeed;
    private bool GoRight;
    public Animator globo;
    public Animator bagman;

    // Use this for initialization
    void Start () {
        globo_T = GetComponent<AreaEffector2D>();
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
	void Update () {
        if (bagman.GetBool("ataque_Globo")&& GoRight)
        {
            globo.SetBool("atacar", true);
            globo_T.enabled= true;
            
        }
        else {
            globo.SetBool("atacar", false);
            globo_T.enabled = false;
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
