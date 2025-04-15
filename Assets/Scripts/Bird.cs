using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public int UPSpeed = 5;
    private Rigidbody2D myrigidbody2D;
    private Animator animator;

    public GameManager gameManager;

    public float chengdu = 4;


    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        animator = transform.Find("birdShow").GetComponent<Animator>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        animator.SetInteger("state", 1);
        myrigidbody2D.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.isGameState) return;
        if(Input.GetMouseButtonDown(0))
        {
            Fly();
        }

        transform.rotation = Quaternion.Euler(0, 0, myrigidbody2D.velocity.y * chengdu);

        

    }

    public void Fly()
    {
        myrigidbody2D.velocity = new Vector2(0, UPSpeed);//线性加速度
    }

    public void ChangeState(bool isFly)
    {
        if(isFly)
        {
            animator.SetInteger("state", 0);
            myrigidbody2D.simulated = true;
        }
        else
        {
            animator.SetInteger("state", 1);
            myrigidbody2D.simulated = false;
        }
    }

}
