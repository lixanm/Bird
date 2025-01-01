using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject tut;
    public GameObject score;
    public GameObject bird;
    private bool isGameReady = false;
    public bool isGameState = false;

    // Start is called before the first frame update
    void Start()
    {
        tut = GameObject.Find("tut");
        score= GameObject.Find("score");
        bird= GameObject.Find("bird");
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameReady) return;
        if (isGameState) return;
        if (Input.GetMouseButtonDown(0))
        {
            tut.GetComponent<UIManager>().HideUI();
            bird.GetComponent<Bird>().ChangeState(true);//·É
            isGameState = true;
        }
    }

    public void PlayBtnClick()
    {
        tut.GetComponent<UIManager>().ShowUI();
        score.GetComponent<UIManager>().ShowUI();
        isGameReady = true;
    }

    

}
