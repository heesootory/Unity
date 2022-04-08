using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScript32 : MonoBehaviour
{
    private SpriteRenderer render;
    public Sprite[] sprites;

    void Start()
    { 
        render = GetComponent<SpriteRenderer>();

        StartCoroutine(changeCo());
    }

    IEnumerator changeCo()
    {
        for (int i = 0; i < sprites.Length; i++)
        {
            render.sprite = sprites[i];
            yield return null;
        }
    }
}
