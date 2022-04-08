using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScript_Sol : MonoBehaviour
{
    public SpriteRenderer renderer;
    public Sprite[] sprites;

    int index = 0;
    GameObject Molly;
    Manager_Sol mns;

    void Awake()
    {
        Application.targetFrameRate = 40;
    }
    
    void Start()
    {
        Molly = GameObject.Find("GameManager");
        mns = Molly.GetComponent<Manager_Sol>();
        //print(Manager_Sol.count + "스타트");
    }

    void Update()
    {
        renderer.sprite = sprites[index++];

        if(index == sprites.Length)
        {
            //print(Manager_Sol.count + "그리기");
            if (Manager_Sol.count <= 19)
                Molly.SendMessage("CreateMolly", gameObject);   //이미 다른 두더지들 다른 위치 복제 완료.
            else mns.CreateMolly(gameObject);
            
            Destroy(gameObject);        //삭제
            Manager_Sol.count--;
        }
    }

    void OnMouseDown()
    {
        Manager_Sol.count--;
        Destroy(gameObject);
    }


}
