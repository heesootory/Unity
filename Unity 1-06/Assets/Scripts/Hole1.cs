using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole1 : MonoBehaviour
{
    public SpriteRenderer render;
    public Sprite[] images;

    int imgindex = 0;

    void Awake()
    {
        Application.targetFrameRate = 30;
    }

    void Update()
    {
        if (imgindex < images.Length)
            render.sprite = images[imgindex];
        imgindex++;

    }

    public void Reset()
    {
        imgindex = 0;
    }
}
