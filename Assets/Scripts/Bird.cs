using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public int UPSpeed;
    private Rigidbody2D myrigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        UPSpeed = 5;
        myrigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //0�����1�Ҽ�
        if(Input.GetMouseButtonDown(0)==true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, UPSpeed);
        }

    }
}
