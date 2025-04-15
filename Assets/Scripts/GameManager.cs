using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;//UI相关命名空间
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject tut;
    public GameObject score;
    public GameObject bird;
    private bool isGameReady = false;
    public bool isGameState = false;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        tut = GameObject.Find("tut");
        score= GameObject.Find("score");
        bird= GameObject.Find("bird");
        GameObject.Find("bgs").GetComponent<Bgs>().isMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameReady) return;
        if (isGameState) return;
        if (Input.GetMouseButtonDown(0))
        {
            tut.GetComponent<UIManager>().HideUI();
            bird.GetComponent<Bird>().ChangeState(true);//飞的状态
            bird.GetComponent<Bird>().Fly();//飞
            isGameState = true;
        }
    }

    public void PlayBtnClick()
    {
        tut.GetComponent<UIManager>().ShowUI();
        score.GetComponent<UIManager>().ShowUI();
        isGameReady = true;
    }
    /// <summary>
    /// 
    /// </summary>
    public void GameOver()
    {
        if (isGameState == false) return;

        isGameReady = false;
        isGameState = false;

        GameObject.Find("ZhuZiController").GetComponent<ZhuZiController>().StopMove();
        GameObject.Find("bgs").GetComponent<Bgs>().isMove=false;
    }

    public int a = 0;

    public void GetScore()
    {
        scoreText.text = (int.Parse(scoreText.text) + 1).ToString();
    }

}
