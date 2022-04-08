using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScript31 : MonoBehaviour
{
    public SpriteRenderer render;
    public Sprite[] sprites;

    void Start()
    {
        //changeSub();
        StartCoroutine(changeCo());
    }

    //void changeSub()
    //{
    //    for(int i = 0; i<sprites.Length; i++)
    //    {
    //        render.sprite = sprites[i];
    //    }
    //}

    IEnumerator changeCo()
    {
        for(int i = 0; i<sprites.Length; i++)
        {
            render.sprite = sprites[i];
        }
        yield return null;
    }

}
