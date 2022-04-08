using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager2 : MonoBehaviour
{
    public GameObject original;

    void Start()
    {
        Debug.Log(name + " 스타트");
        CreateMolly();
    }

    public void CreateMolly()
    {
        Debug.Log(name + " 크리에이트");
        StartCoroutine(CreateObject());
    }

    IEnumerator CreateObject()
    {
        float x = Random.Range(-7, 7);
        float y = Random.Range(-4, 4);
        
        Instantiate(original, new Vector2(x, y), Quaternion.identity);
        Debug.Log("복제 " + original);
        yield return null;
    }
}
