using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hole : MonoBehaviour
{
    public SpriteRenderer rnd;
    public Sprite[] A_normal;
    public Sprite[] A_catch;
    public Sprite[] B_normal;
    public Sprite[] B_catch;
    public Sprite[] C_normal;
    public Sprite[] C_catch;
    public Sprite[] D_normal;
    public Sprite[] D_catch;
    public RectTransform gauge;
    public Image GaugeImg;

    bool b_first = true;        //깨면 false
    bool b_second = true;
    bool b_third = true;

    bool bCatch = false;
    bool bWrongCatch;
    float life = 1f;

    int Random_num;

    void Start()
    {
        Application.targetFrameRate = 100;
        StartCoroutine(HoleCycle());
    }

    IEnumerator HoleCycle()
    {
        bWrongCatch = false;
        yield return new WaitForSeconds(Random.Range(0.5f, 3.5f));

        Random_num = Random.Range(1, 101);
        if(Random_num % 3 == 0)
        {
            bWrongCatch = true;
            yield return StartCoroutine(Hole(D_normal, D_catch, bWrongCatch));
            yield return StartCoroutine(HoleCycle());
        }
        else
        {
            if (b_first)    //1탄 두더지
            {
                yield return StartCoroutine(Hole(A_normal, A_catch, bWrongCatch));
                if (life < 0.2) status_change(1);
                yield return StartCoroutine(HoleCycle());
            }
            if (b_second)   //2탄 두더지
            {
                yield return StartCoroutine(Hole(B_normal, B_catch, bWrongCatch));
                if (life < 0.2) status_change(2);
                yield return StartCoroutine(HoleCycle());
            }
            if (b_third)    //3탄 두더지
            {
                yield return StartCoroutine(Hole(C_normal, C_catch, bWrongCatch));
                if (life < 0.2) status_change(3);
                yield return StartCoroutine(HoleCycle());
            }
        }
    }

    IEnumerator Hole(Sprite[] norm, Sprite[] cat, bool wrong)
    {
        for(int i = 0; i < norm.Length; i++)
        {
            if (bCatch)
            {
                if (wrong) life_init();
                else damage();
                break;
            }
            rnd.sprite = norm[i];
            yield return null;
        }
        if (bCatch)
        {
            for (int i = 0; i < cat.Length; i++)
            {
                rnd.sprite = cat[i];
                yield return null;
            }
            bCatch = false;
        }
    }

    void damage()
    {
        life -= 0.2f;
        gauge.offsetMin = new Vector2(1 - life, 0);
    }

    void life_init()
    {
        life = 1f;
        gauge.offsetMin = new Vector2(1 - life, 0);
    }

    void status_change(int level)
    {
        switch (level)
        {
            case 1: b_first = false;
                life = 1f;
                gauge.offsetMin = new Vector2(1 - life, 0);
                
                GaugeImg.color = new Color(1, 1, 0);    //노랑으로
                break;
            case 2: b_second = false;
                life = 1f;
                gauge.offsetMin = new Vector2(1 - life, 0);
                
                GaugeImg.color = new Color(1, 0, 0);    //빨강으로
                break;
            case 3: b_first = true; b_second = true; b_third = true;
                life = 1f;
                gauge.offsetMin = new Vector2(1 - life, 0);
                ScoreManager.singleton.ScoreAdd();      //점수 획득
                GaugeImg.color = new Color(0, 1, 0);    //초록으로
                break;
        }
    }


    void OnMouseDown()
    {
        if (bCatch) return;
        bCatch = true;
    }
    




}
