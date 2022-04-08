using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolutionScript : MonoBehaviour
{
    public SolutionScript opposite;
    public bool isFirst;
    public Sprite[] imgOpen, imgIdle, imgClose, imgCatch;

    private SpriteRenderer render;
    private int state = 0;

    void Awake()
    {
        Application.targetFrameRate = 30;
    }

    void Start()
    {
        Debug.Log("start - - - " + this +  " - - - - " + name);
        
        render = GetComponent<SpriteRenderer>();
        if (isFirst) StartCoroutine(PlayAnimation());       //isFirst가 true인 script1만 코루틴이 실행
    }                                                       //isFirst는 사실상 순서를 정하기 위한 bool 

    public IEnumerator PlayAnimation()
    {
        Debug.Log("코루틴 - - - - " + this + " - - - - " + name);

        Sprite[] _img = GetImages();

        foreach(var x in _img)          //in 뒤에는 주소변수가 온다!!
        {
            render.sprite = x;
            yield return null;
        }

        state = (state + 1) % 4;
        StartCoroutine(opposite.PlayAnimation());           //script1의 코루틴이 script2의 코루틴을 실행시키므로, isFirst 필요 x

    }

    Sprite[] GetImages()
    {
        if (state == 0) return imgOpen;
        else if (state == 1) return imgIdle;
        else if (state == 2) return imgClose;
        else return imgCatch;
    }


}


