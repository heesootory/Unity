using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole1 : MonoBehaviour
{
    public SpriteRenderer renderer;
    public Sprite[] sprNormal, sprClose, sprCatch;

    bool bCatch = false;

    void Awake()
    {
        Application.targetFrameRate = 20;
    }

    void Start()
    {
        StartCoroutine(LifeCycle());
    }

    IEnumerator LifeCycle()
    {
        yield return StartCoroutine(LifeNormal());

        if (bCatch)
        {
            yield return StartCoroutine(LifeEnd(sprCatch));
            GameObject.Find("GameManager").SendMessage("CreateMole");
        }
        else yield return StartCoroutine(LifeEnd(sprClose));

        GameObject.Find("GameManager").SendMessage("ShowMoleCount", -1);
        Destroy(gameObject);
    }

    IEnumerator LifeNormal()
    {
        for(int i = 0; i<sprNormal.Length; i++)
        {
            if (bCatch) break;

            renderer.sprite = sprNormal[i];
            yield return null;
        }
    }

    IEnumerator LifeEnd(Sprite[] _img)
    {
        for(int i = 0; i < _img.Length; i++)
        {
            renderer.sprite = _img[i];
            yield return null;
        }
    }

    void OnMouseDown()
    {
        if (bCatch) return;
        bCatch = true;
    }

}
