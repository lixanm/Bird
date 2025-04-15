using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgs : MonoBehaviour
{
    public float bgSpeed=0.01f;
    Vector3 startPos;

    public bool isMove = false;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMove) return;

        transform.Translate(-bgSpeed, 0, 0);
        if(transform.position.x<-5.63f)
        {
            transform.position = startPos;
        }

    }
}
