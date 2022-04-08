using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageHandler : MonoBehaviour
{
    public SpriteRenderer renderer;
    public Sprite[] sprites;

    int index = 0;

    Manager mg;
    
    void Awake()
    {
        
        Debug.Log("어웨이크 " + gameObject);
        Application.targetFrameRate = 70;
        
    }

    void Start()
    {
        Debug.Log("각각 이미지 : " + gameObject);
        mg = GameObject.Find("Manager").GetComponent<Manager>();
    }

    void Update()
    {
        renderer.sprite = sprites[index++];
        if(index == sprites.Length)
        {
            Debug.Log("이미지 그리기 : " + gameObject);
            //GameObject.Find("Manager").SendMessage("createMolly");
            mg.createMolly();

            Destroy(gameObject);
            Debug.Log("삭제 완료 : " + gameObject);
        }
        
    }
}
