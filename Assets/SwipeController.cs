using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class SwipeController : MonoBehaviour
{
    [SerializeField] GameObject MainUI, LevelUI, NextButton, PrevButton;
    [SerializeField] RectTransform page1, page2;
    private Vector2 shiftvector = new Vector2(0.66f, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Next()
    {
        page1.DOAnchorMin(page1.anchorMin - shiftvector, 1);
        page1.DOAnchorMax(page1.anchorMax - shiftvector, 1);
        page2.DOAnchorMin(page2.anchorMin - shiftvector, 1);
        page2.DOAnchorMax(page2.anchorMax - shiftvector, 1).OnComplete(NextComp);
    }

    public void Previous()
    {
        page1.DOAnchorMin(page1.anchorMin + shiftvector, 1);
        page1.DOAnchorMax(page1.anchorMax + shiftvector, 1);
        page2.DOAnchorMin(page2.anchorMin + shiftvector, 1);
        page2.DOAnchorMax(page2.anchorMax + shiftvector, 1).OnComplete(PreviousComp);

    }
    public void NextComp()
    {
        NextButton.gameObject.SetActive(false);
        PrevButton.gameObject.SetActive(true);
    }

    public void PreviousComp()
    {
        NextButton.gameObject.SetActive(true);
        PrevButton.gameObject.SetActive(false);
    }

    public void Exit()
    {
        MainUI.SetActive(true);
        LevelUI.SetActive(false);

    }
}
