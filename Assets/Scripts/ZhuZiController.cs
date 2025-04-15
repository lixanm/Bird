using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuZiController : MonoBehaviour
{
    public Transform ZhuZis;
    public GameObject ZhuZiPrefab;

    //要拿取判断游戏开始的变量
    public GameManager gm;

    public float SpawTime=2f;

    private List<GameObject> zhuzis = new List<GameObject>();

    public bool ZhuZiIsMove = true;

    private void Start()
    {
        //开启携程
        StartCoroutine(SpawnAZhuZi());
    }

    public void StartMove()
    {
        ZhuZiIsMove = true;
        foreach (GameObject item in zhuzis)
        {
            item.GetComponent<ZhuZiScript>().canMove = true;
        }
    }
    public void StopMove()
    {
        ZhuZiIsMove = false;
        foreach (GameObject item in zhuzis)
        {
            item.GetComponent<ZhuZiScript>().canMove = false;
        }
    }
    //
    public void SpawOneZhuZi()
    {
        GameObject zhuzi = GameObject.Instantiate(ZhuZiPrefab,ZhuZis);
        zhuzi.GetComponent<ZhuZiScript>().RandomHeight();

        zhuzis.Add(zhuzi);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (ZhuZiIsMove) StopMove();
            else StartMove();
        }
        
    }

    //携程
    IEnumerator SpawnAZhuZi()
    {
        while(true)
        {
            yield return new WaitForSeconds(SpawTime);


            if (!gm.isGameState) continue;
            if (!ZhuZiIsMove) continue;
            SpawOneZhuZi();
        }    
        
    }
    

}
