using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Sol : MonoBehaviour
{
    public GameObject origin;
    public static int count = 0;

    void Start()
    {        
        CreateMolly(origin);
    }

    public void CreateMolly(GameObject ori)   //다른 위치에서 클론 생성
    {
        count++;
        StartCoroutine(CopyMolly(ori));
    }

    IEnumerator CopyMolly(GameObject o)
    {
        float x = Random.Range(-7, 7);
        float y = Random.Range(-4, 4);
        Instantiate(o, new Vector2(x, y), Quaternion.identity);

        yield return null;
    }

    

}
