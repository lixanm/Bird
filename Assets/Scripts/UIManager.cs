using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public CanvasGroup canvasGroup;

    public float time = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowUI()
    {
        canvasGroup.DOFade(1, time);
    }

    public void HideUI()
    {
        canvasGroup.DOFade(0, time).onComplete = ()=>
        {
            gameObject.SetActive(false);
        };
    }

}
