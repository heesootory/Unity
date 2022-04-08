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
    BoxCollider boxcol;

    void Awake()
    {
        Application.targetFrameRate = 10;
    }

    void Start()
    {
        boxcol = GetComponent<BoxCollider>();
        go = GameObject.Find("GameManager");
    }
    
    void Update()
    {
        switch (state)
        {
            case 0: change_state(sprNormal); break;
            case 1: change_state(sprCatch); break;
        }
    }

    void change_state(Sprite[] _img)
    {
        renderer.sprite = _img[index++];

        if(index == _img.Length)
        {
            index = 0;
            Destroy(gameObject);
            Global.total--;
            print(Global.total);
        }
    }

    void shoot()
    {
        if (state == 1) return;
        
        index = 0;
        state = 1;
        go.SendMessage("CreateMolly");
        Destroy(boxcol);
    }

    void OnMouseDown()
    {
        Global.click++;
        print("클릭......................................" + Global.click);
        shoot();
    }
}
