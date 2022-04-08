using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScript1 : MonoBehaviour
{
    public SpriteRenderer renderer;
    public Sprite[] sprites;

    int imageindex = 0;

    GameObject manager;
    Manager1 mng;

    void Awake()
    {
        Application.targetFrameRate = 70;
    }

    void Start()
    {
        Debug.Log("이미지 스타트 : " + name);
        manager = GameObject.Find("GameManager");
        mng = manager.GetComponent<Manager1>();

    }

    void Update()
    {
        renderer.sprite = sprites[imageindex];      //원본은 맵 가운데 두개이므로, 결국 clone들만 그리게 됨.
        if(++imageindex == sprites.Length)
        {
            Debug.Log("이미지 그리기 : " + name);
            mng.CreateMolly();
            //manager.SendMessage("CreateMolly");
            Debug.Log("이미지 삭제 : " + name);
            Destroy(gameObject);
        }
    }


}
