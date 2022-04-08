using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole2 : MonoBehaviour
{
    public SpriteRenderer renderer;
    public Sprite[] sprNormal, sprClose, sprCatch;

    int aniindex = 0;
    int state = 0;

    void Awake()
    {
        Application.targetFrameRate = 20;
    }

    void Update()
    {
        switch(state)
        {
            case 0: UpdateSprite(sprNormal, false, 1); break;
            case 1: UpdateSprite(sprClose, true, 0); break;
            case 2: UpdateSprite(sprCatch, true, 0); break;
                
        }
    }

    void UpdateSprite(Sprite[] _img, bool _destroy, int _nextstate)
    {
        renderer.sprite = _img[aniindex++];

        if(aniindex == _img.Length)
        {
            aniindex = 0;
            if (_destroy)
            {
                if(state == 2)
                    GameObject.Find("GameManager").SendMessage("CreateMole");

                GameObject.Find("GameManager").SendMessage("ShowMoleCount", -1);
                Destroy(gameObject);
            }
            else state = _nextstate;
        }
    }

    public void Shoot()
    {
        if (state == 2) return;
        state = 2;
        aniindex = 0;
    }
}
