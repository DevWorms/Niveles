using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerilloCamina : MonoBehaviour
{
    public GameObject StartPoint;
    public GameObject EndPoint;
    public float EnemySpeed;
    private bool GoRight;
    public Animator cerillo;
    public Animator bagman;
    // Use this for initialization
    void Start()
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
    void Update()
    {
        if (bagman.GetBool("ataque_Cerillo") && GoRight)
        {
            cerillo.SetBool("atacar", true);
            EnemySpeed = 5;
            //transform.position = Vector3.MoveTowards(transform.position, EndPoint.transform.position, EnemySpeed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, StartPoint.transform.position, EnemySpeed * Time.deltaTime);
        }
        else
        {
            cerillo.SetBool("atacar", false);

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

