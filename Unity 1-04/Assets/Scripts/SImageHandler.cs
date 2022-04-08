using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SImageHandler : MonoBehaviour
{
    public SpriteRenderer renderer;
    public Sprite[] sprites;
    int imageindex = 0;
    GameObject manager;

    void Awake()
    {
        Application.targetFrameRate = 50;
    }

    void Start()
    {
        manager = GameObject.Find("GameManager");
    }

    void Update()
    {
        renderer.sprite = sprites[imageindex++];
        if(imageindex == sprites.Length)
        {
            manager.SendMessage("CreateMolly");
            Global.molecount--;
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        Global.molecount--;
        Destroy(gameObject);
    }
}
