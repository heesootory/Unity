using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    RectTransform canvas_Rect;
    RectTransform Img_Rect;
    RectTransform anchor_Rect;
    
    int click_num = -1;
    int step = 0;

    float p_x, p_y;                         //이미지 pivot
    float p_x_max, p_x_min, p_y_max, p_y_min;   //이미지 anchor

    float a_x_max, a_x_min, a_y_max, a_y_min;   //흰점 anchor

    float c_width, c_height;
    float a_x, a_y;

    void Start()
    {
        canvas_Rect = GameObject.Find("Canvas").GetComponent<RectTransform>();
        Img_Rect = GameObject.Find("Image 1").GetComponent<RectTransform>();
        anchor_Rect = GameObject.Find("Anchor").GetComponent<RectTransform>();

        c_width = canvas_Rect.rect.width;
        c_height = canvas_Rect.rect.height;

        p_x = Img_Rect.pivot.x;
        p_y = Img_Rect.pivot.y;

        p_x_max = Img_Rect.anchorMax.x;
        p_x_min = Img_Rect.anchorMin.x;
        p_y_max = Img_Rect.anchorMax.y;
        p_y_min = Img_Rect.anchorMin.y;

        a_x_max = anchor_Rect.anchorMax.x;
        a_x_min = anchor_Rect.anchorMin.x;
        a_y_max = anchor_Rect.anchorMax.y;
        a_y_min = anchor_Rect.anchorMin.y;

        a_x = anchor_Rect.position.x;
        a_y = anchor_Rect.position.y;

        //print("스크린 폭 : " + Screen.width);
        //print("스크린 높이 : " + Screen.height);
        //print("캔버스 폭 : " + c_width);
        //print("캔버스 높이 : " + c_height);

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            step = (++click_num) % 32; // 0, 1, 2, ...30, 31
            //print("마우스" + step);
            change(step);
        }
    }

    void change(int step)
    {
        if (step < 2) Img_sizeUpDown(step);
        else if (step < 12) Rotate_Img(step);
        else if (step < 22) Rotate_both(step);
        else Rotate_anchor(step);
    }

    void Img_sizeUpDown(int step)
    {
        if (step == 0)
        {
            Img_Rect.anchorMax = new Vector2(1f, 1f);
            Img_Rect.anchorMin = new Vector2(0f, 0f);
            Img_Rect.sizeDelta = new Vector2(0, 0);
        }
        else
        {
            Img_Rect.anchorMax = new Vector2(0.5f, 0.5f);
            Img_Rect.anchorMin = new Vector2(0.5f, 0.5f);
            Img_Rect.sizeDelta = new Vector2(210, 98);
        }
    }

    void Rotate_Img(int step)
    {
        pivot_way(step - 2, ref p_x, ref p_y);

        Img_Rect.pivot = new Vector2(p_x, p_y);
    }

    void Rotate_both(int step)
    {
        anchor_way(step - 12, ref a_x_max, ref a_x_min, ref a_y_max, ref a_y_min);
        anchor_way(step - 12, ref p_x_max, ref p_x_min, ref p_y_max, ref p_y_min);
        pivot_way(step - 12, ref p_x, ref p_y);

        anchor_Rect.anchorMax = new Vector2(a_x_max, a_y_max);
        anchor_Rect.anchorMin = new Vector2(a_x_min, a_y_min);
        Img_Rect.anchorMax = new Vector2(p_x_max, p_y_max);
        Img_Rect.anchorMin = new Vector2(p_x_min, p_y_min);
        Img_Rect.pivot = new Vector2(p_x, p_y);
    }

    void Rotate_anchor(int step)
    {
        position_way(step - 22, ref a_x, ref a_y);

        anchor_Rect.position = new Vector2(a_x, a_y);
    }

    void pivot_way(int step, ref float x, ref float y)
    {
        switch (step)
        {
            case 0: x -= 0.5f; break;
            case 1: y += 0.5f; break;
            case 2: x += 0.5f; break;
            case 3: x += 0.5f; break;
            case 4: y -= 0.5f; break;
            case 5: y -= 0.5f; break;
            case 6: x -= 0.5f; break;
            case 7: x -= 0.5f; break;
            case 8: y += 0.5f; break;
            case 9: x += 0.5f; break;
        }
    }

    void anchor_way(int step, ref float x_max, ref float x_min, ref float y_max, ref float y_min)
    {
        switch (step)
        {
            case 0: x_max -= 0.5f; x_min -= 0.5f; break;
            case 1: y_max += 0.5f; y_min += 0.5f; break;
            case 2: x_max += 0.5f; x_min += 0.5f; break;
            case 3: x_max += 0.5f; x_min += 0.5f; break;
            case 4: y_max -= 0.5f; y_min -= 0.5f; break;
            case 5: y_max -= 0.5f; y_min -= 0.5f; break;
            case 6: x_max -= 0.5f; x_min -= 0.5f; break;
            case 7: x_max -= 0.5f; x_min -= 0.5f; break;
            case 8: y_max += 0.5f; y_min += 0.5f; break;
            case 9: x_max += 0.5f; x_min += 0.5f; break;
        }
    }

    void position_way(int step, ref float x, ref float y)
    {
        switch (step)
        {
            case 0: x -= Screen.width / 2; break;
            case 1: y += Screen.height / 2; break;
            case 2: x += Screen.width / 2; break;
            case 3: x += Screen.width / 2; break;
            case 4: y -= Screen.height / 2; break;
            case 5: y -= Screen.height / 2; break;
            case 6: x -= Screen.width / 2; break;
            case 7: x -= Screen.width / 2; break;
            case 8: y += Screen.height / 2; break;
            case 9: x += Screen.width / 2; break;
        }
    }

    

}
