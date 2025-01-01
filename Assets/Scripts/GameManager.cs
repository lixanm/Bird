using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject tut;
    public GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        tut = GameObject.Find("tut");
        score= GameObject.Find("score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBtnClick()
    {
        tut.GetComponent<UIManager>().ShowUI();
        score.GetComponent<UIManager>().ShowUI();
    }

}
