using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleController : MonoBehaviour
{
    public SpriteRenderer renderer;
    public Sprite[] sprNormal, sprCatch;

    int index = 0;
    int state = 0;

    GameObject go;

    void Awake()
    {
        Application.targetFrameRate = 20;
    }

    void Start()
    {
        go = GameObject.Find("GameManager");
        StartCoroutine(Cycle());
    }

    IEnumerator Cycle()
    {
        yield return StartCoroutine(Cycle_Normal());

        if(state == 1) yield return StartCoroutine(Cycle_Catch());
    }

    IEnumerator Cycle_Normal()
    {
        for(int i = index; i< sprNormal.Length; i++)
        {
            if (state == 1) break;
            renderer.sprite = sprNormal[i];
            yield return null;
        }
        
        if (state == 0) FadeOut();
    }

    IEnumerator Cycle_Catch()
    {
        for(int i = index; i< sprCatch.Length; i++)
        {
            renderer.sprite = sprCatch[i];
            yield return null;
        }

        FadeOut();
        go.SendMessage("CreateMolly");

    }

    void FadeOut()
    {
        Destroy(gameObject);
        Global.total--;
        print(Global.total);
    }
    
    void shoot()
    {
        if (state == 1) return;
        index = 0;
        state = 1;
    }

    void OnMouseDown()
    {
        shoot();
    }
}
