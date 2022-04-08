using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QHole : MonoBehaviour
{
    public SpriteRenderer render;
    public Sprite[] Imgtype1, Imgtype2, Imgtype3, Imgtype4; //76,76,76,78

    int index = 0;  //이미지 순서
    int Molly = 0;  //0,1,2,3종류

    void Awake()
    {
        Application.targetFrameRate = 30;
    }

    void Update()
    {
        if (index == 76) index = 0;
        switch (Molly % 4)
        {
            case 0:
                render.sprite = Imgtype1[index];
                break;
            case 1:
                render.sprite = Imgtype2[index];
                break;
            case 2:
                render.sprite = Imgtype3[index];
                break;
            case 3:
                render.sprite = Imgtype4[index];
                break;
        }
        index++;
    }

    public void Click()
    {
        Molly++;
    }
}
