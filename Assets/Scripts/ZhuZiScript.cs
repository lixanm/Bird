using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuZiScript : MonoBehaviour
{
    public float speed = 0.06f;
    public bool canMove = true;

    

    //每个固定帧，每秒执行固定次数
    public void FixedUpdate()
    {
        if (!canMove) return;
        
        transform.Translate(-speed, 0, 0);
        
        

    }
    //随机高度
    public void RandomHeight()
    {
        //1
        //-3
        float r = Random.Range(-2.81f-2f-1f, 1.0f-2f);
        //transform.position.Set(transform.position.x, r, transform.position.z);
        transform.SetPositionAndRotation(new Vector3(transform.position.x, r, transform.position.z), transform.rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("111");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
    }


}
