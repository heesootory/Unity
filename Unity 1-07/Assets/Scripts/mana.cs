using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mana : MonoBehaviour
{
    GameObject Img;
    GameObject anchor;
    RectTransform Img_Rect;
    RectTransform anchor_Rect;

    int click_num = -1;
    int step = 0;


    void Start()
    {
        Img = GameObject.Find("Image 1");
        anchor = GameObject.Find("Anchor");
        Img_Rect = Img.GetComponent<RectTransform>();
        anchor_Rect = anchor.GetComponent<RectTransform>();


    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            
            
        }
    }
}
