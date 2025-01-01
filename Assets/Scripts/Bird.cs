using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public int UPSpeed;
    private Rigidbody2D myrigidbody2D;
    private Animator animator;

    void Start()
    {
        UPSpeed = 5;
        myrigidbody2D = GetComponent<Rigidbody2D>();
        animator = transform.Find("birdShow").GetComponent<Animator>();

        animator.SetInteger("state", 1);
        myrigidbody2D.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)==true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, UPSpeed);
        }

    }
}
