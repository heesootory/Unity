using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_manager : MonoBehaviour
{

    RectTransform image, anchor;

    float[] px = { 0f, 0f, 0.5f, 1f, 1f, 1f, 0.5f, 0f, 0f, 0.5f };
    float[] py = { 0.5f, 1f, 1f, 1f, 0.5f, 0f, 0f, 0f, 0.5f, 0.5f };

    float[] ax = { 0f, 0f, 0.5f, 1f, 1f, 1f, 0.5f, 0f, 0f, 0.5f };
    float[] ay = { 0.5f, 1f, 1f, 1f, 0.5f, 0f, 0f, 0f, 0.5f, 0.5f };

    float[] sx = { 640f, 640f, 0f, -640f, -640f, -640f, 0f, 640f, 640f, 0f };
    float[] sy = { 0f, -360f, -360f, -360f, 0f, 360f, 360f, 360f, 0f, 0f };

    int index = 0;
    bool bInit = true;

    void Start()
    {
        image = GameObject.Find("Image 1").GetComponent<RectTransform>();
        anchor = GameObject.Find("Anchor").GetComponent<RectTransform>();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Change();
        }
    }

    void Change()
    {
        if (bInit)
        {
            if(index == 0)
            {
                image.anchorMin = new Vector2(0f, 0f);
                image.anchorMax = new Vector2(1f, 1f);
                image.offsetMin = new Vector2(50f, 0f);
                image.offsetMax = new Vector2(-50f, 0f);
            }
            else
            {
                image.anchorMin = image.anchorMax = new Vector2(0.5f, 0.5f);
                image.sizeDelta = new Vector2(210f, 98f);
                bInit = false;
            }
            index = (index + 1) % 2;
        }
       
    }





}
