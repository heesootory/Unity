using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public SpriteRenderer rnd;
    public Sprite[] imgNormal;
    public Sprite[] imgClose;
    public Sprite[] imgCatch;
    public RectTransform gauge;

    bool bCatch;
    float life = 1f;

    void Start()
    {
        Application.targetFrameRate = 10;
        StartCoroutine(HoleCycle());
    }

    IEnumerator HoleCycle()
    {
        bCatch = false;
        yield return new WaitForSeconds(Random.Range(0.5f, 3.5f));
        yield return StartCoroutine(HandleNormal());

        if (bCatch)
        {
            life -= 0.2f;
            gauge.offsetMin = new Vector2(1 - life, 0f);
            yield return StartCoroutine(HandleEnd(imgCatch));
        }
        else yield return StartCoroutine(HandleEnd(imgClose));

        if (life > 0.2) StartCoroutine(HoleCycle());
        else Destroy(gameObject);
    }

    IEnumerator HandleEnd(Sprite[] _img)
    {
        for (int i = 0; i < _img.Length; i++)
        {
            rnd.sprite = _img[i];
            yield return null;
        }
    }

    IEnumerator HandleNormal()
    {
        for (int i = 0; i < imgNormal.Length; i++)
        {
            if (bCatch) break;
            rnd.sprite = imgNormal[i];
            yield return null;
        }
    }

    void OnMouseDown()
    {
        if (bCatch) return;
        bCatch = true;
    }


}
